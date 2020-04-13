using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BackEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ip = "", polaczenia = "";
        int KolorR = 0, KolorG, KolorB;

        private void Set_IP(object sender, EventArgs e)
        {
            ip = textBox1.Text;//podstaw IP swojego komputera 
            if (textBox1.Text == "")
            {
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Uzupełnij pole!";
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Ustawiono " + ip;
            }
        }

        private void Stop(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Text = "Zamknięto połączenie";
        }

        private void Start(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                polaczenia = "M";
                timer1.Interval = 500;
                timer1.Enabled = true;
                label4.ForeColor = System.Drawing.Color.Green;
                label3.ForeColor = System.Drawing.Color.Green;
                label3.Text = "Połączono";
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Uzupełnij pole!";
                polaczenia = "N";
                timer1.Enabled = false;
            }
        }

        private void Receive_and_Send(object sender, EventArgs e)
        {
            string u="", i="";

            if (ip == "")
            {
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Sprawdz pole IP!";
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Brak adresu IP, nie połączono";
                polaczenia = "N";
            }
            else
            {
                TcpClient tcp = new TcpClient();
                try
                {
                    tcp.Connect(IPAddress.Parse(ip), 10000);//otwiera polaczenie
                    if(label3.Text != "Połączono")
                    {
                        label3.ForeColor = System.Drawing.Color.Green;
                        label3.Text = "Połączono";
                    }
                    BinaryWriter sw = new BinaryWriter(tcp.GetStream());//strumien zapisu                 
                    BinaryReader sr = new BinaryReader(tcp.GetStream());//strumien odczytu 
                    try
                    {
                        sw.Write(Convert.ToByte(1));//odczyt napiecia 1                 
                        u = sr.ReadInt16().ToString();
                        label10.Text = u;
                        sw.Write(Convert.ToByte(2));//odczyt pradu 1                 
                        i = sr.ReadInt16().ToString();
                        label12.Text = i;
                    }
                    catch (Exception error)
                    {
                        label3.ForeColor = System.Drawing.Color.Red;
                        label3.Text = "Wystąpił błąd: " + error.Message;
                    }
                    
                } 
                catch(Exception ex)
                {
                    label3.ForeColor = System.Drawing.Color.Red;
                    label3.Text = "Błąd " + ex.Message;
                    tcp.Close();
                    polaczenia = "N";//osobny try dla bazy i dla tcp
                }

                polaczenia = "M";//osobny try dla bazy i dla tcp

                try
                {
                    if(i == "") 
                    {
                        i = "0";
                        polaczenia = "N";
                    }
                    if (u == "")
                    {
                        u = "0";
                        polaczenia = "N";
                    }
                    SqlConnection MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BoxJenkinsConnectionString"].ConnectionString); //obiekt odpowiadający za połączenie z bazą danych;
                    string sql = "TRUNCATE TABLE [dbo].[Pomiary]"; //polecenie SQL wypełniające pola bazy danych o odpowiednie wartości napięcia, daty itd.
                    DataToBase(MyConnection, sql, label7);
                    sql = "insert into Pomiary([Wartosc],[Jednostka],[Data odczytu], [polaczenia]) values('" + float.Parse(u) + "','V'," + "'" + DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss") + "'," + "'" + polaczenia + "'" + ")"; //polecenie SQL wypełniające pola bazy danych o odpowiednie wartości napięcia, daty itd.
                    DataToBase(MyConnection, sql, label7);
                    sql = "insert into Pomiary([Wartosc],[Jednostka],[Data odczytu], [polaczenia]) values('" + float.Parse(i) + "','A'," + "'" + DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss") + "'," + "'" + polaczenia + "'" + ")"; //polecenie SQL wypełniające pola bazy danych o odpowiednie wartości napięcia, daty itd.
                    DataToBase(MyConnection, sql, label7);
                    sql = "insert into Archiwum([Wartosc],[Jednostka],[Data odczytu], [polaczenia]) values('" + float.Parse(u) + "','V'," + "'" + DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss") + "'," + "'" + polaczenia + "'" + ")"; //polecenie SQL wypełniające pola bazy danych o odpowiednie wartości napięcia, daty itd.
                    DataToBase(MyConnection, sql, label7);
                    sql = "insert into Archiwum([Wartosc],[Jednostka],[Data odczytu], [polaczenia]) values('" + float.Parse(i) + "','A'," + "'" + DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss") + "'," + "'" + polaczenia + "'" + ")"; //polecenie SQL wypełniające pola bazy danych o odpowiednie wartości napięcia, daty itd.
                    DataToBase(MyConnection, sql, label7);
                }
                catch (Exception error)
                {
                    label7.ForeColor = System.Drawing.Color.Red;
                    label7.Text = "Wystąpił błąd: " + error.Message;
                }

                label6.ForeColor = Color.FromArgb(KolorR, KolorG, KolorB);
                KolorR += 10;
                KolorG += 25;
                KolorB += 15;
                KolorR = (KolorR > 255) ? KolorR = 0 : KolorR = KolorR - 1;
                KolorG = (KolorG > 255) ? KolorG = 0 : KolorG = KolorG - 1;
                KolorB = (KolorB > 255) ? KolorB = 0 : KolorB = KolorB - 1;
            }
        }

        private void DataToBase(SqlConnection Con, string polecenie, System.Windows.Forms.Label l)
        {
            try
            {
                using (SqlCommand MyCommand = new SqlCommand(polecenie, Con)) //wysłanie polecenia i automatycznie zamyka i zwalnia zasoby
                {
                    MyCommand.Connection.Open();
                    int res = MyCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                l.Text = ex.Message;
            }
            finally
            {
                using (SqlCommand MyCommand = new SqlCommand(polecenie, Con)) //wysłanie polecenia i automatycznie zamyka i zwalnia zasoby
                {
                    MyCommand.Connection.Close();
                }
            }
        }

    }
}
