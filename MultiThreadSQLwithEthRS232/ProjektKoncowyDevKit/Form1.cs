using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Data.SqlServerCe;
using System.Reflection;

namespace ProjektKoncowyDevKit
{
    public partial class Form1 : Form
    {
        public Thread w1, w2;
        TcpClient Client2 = new TcpClient();
        TcpClient Client = new TcpClient();
        BinaryWriter SWrite = null;
        BinaryWriter SWrite2 = null;
        BinaryReader Sread = null;
        BinaryReader Sread2 = null;
        public bool isStop = false, isStop2 = false, opened = false, opened2 = false;
        int napiecie, napiecie2, prad, prad2;
        static Mutex mut;

        public void watek()
        {
            if (opened)
            {
                try
                {
                    String strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    //dodaje do sciezki programu exe nazwe pliku bazy danych 
                    String strFullPathToMyFile = Path.Combine(strAppDir, "AppDatabase1.sdf");
                    //definicja obiektu polaczenia z bazą 
                    string sdfPath = @"ścieżka do bazy\AppDatabase1.sdf";
                    //SqlCeConnection conn = new SqlCeConnection("Data Source = " + strFullPathToMyFile);
                    SqlCeConnection conn = new SqlCeConnection("Data Source = " + sdfPath);
                    conn.Open();//proba polaczenia z bazą //-dodawanie danych 
                    SqlCeCommand cmd = conn.CreateCommand();//obiekt polecenia do bazy 

                    while (!isStop)
                    {
                        try
                        {
                            mut.WaitOne();

                            try
                            {
                                string message;
                                message = "1";
                                SWrite.Write(Convert.ToByte(message)); //zamienia na int i wysyla 
                                napiecie = Sread.ReadInt16(); //odczyt odpowiedzi w postaci int 
                                string czas = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                cmd.CommandText = "INSERT INTO Pomiary ([Data],[Wartosc],[Wielkosc]) Values(" + "'" + czas + "'" + "," + napiecie + ",'V')";
                                cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 //-wyswietlanie danych
                                message = "2";
                                SWrite.Write(Convert.ToByte(message)); //zamienia na int i wysyla 
                                int response = Sread.ReadInt16();
                                prad = response;
                                czas = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                cmd.CommandText = "INSERT INTO Pomiary ([Data],[Wartosc],[Wielkosc]) Values(" + "'" + czas + "'" + "," + prad + ",'A')";
                                cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 
                            }
                            catch (Exception ex)
                            {
                                ErrorLabel.Text = "Błąd " + ex.Message;
                            }
                        }
                        finally
                        {
                            mut.ReleaseMutex();//wylaczenie muteksu
                            Thread.Sleep(100);
                        }
                    }
                    conn.Close();//zamknac polaczenie z baza 
                }
                catch (Exception ex)
                {                }
            }
        }

        public void watek2()
        {
            if (opened2)
            {
                try
                {
                    String strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    //dodaje do sciezki programu exe nazwe pliku bazy danych 
                    String strFullPathToMyFile = Path.Combine(strAppDir, "AppDatabase1.sdf");
                    //definicja obiektu polaczenia z bazą 
                    string sdfPath = @"ścieżka do bazy\AppDatabase1.sdf";
                    // SqlCeConnection conn = new SqlCeConnection("Data Source = " + strFullPathToMyFile);
                    SqlCeConnection conn = new SqlCeConnection("Data Source = " + sdfPath);
                    conn.Open();//proba polaczenia z bazą //-dodawanie danych 
                    SqlCeCommand cmd = conn.CreateCommand();//obiekt polecenia do bazy 

                    while (!isStop2)
                    {
                        try
                        {
                            mut.WaitOne();
                            try
                            {
                                string message;
                                message = "1";
                                SWrite2.Write(Convert.ToByte(message)); //zamienia na int i wysyla 
                                napiecie2 = Sread2.ReadInt16(); //odczyt odpowiedzi w postaci int 
                                string czas = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                cmd.CommandText = "INSERT INTO Pomiary ([Data],[Wartosc],[Wielkosc]) Values(" + "'" + czas + "'" + "," + napiecie2 + ",'V')";
                                cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 //-wyswietlanie danych
                                message = "2";
                                SWrite2.Write(Convert.ToByte(message)); //zamienia na int i wysyla 
                                int response = Sread2.ReadInt16();
                                prad2 = response;
                                czas = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                cmd.CommandText = "INSERT INTO Pomiary ([Data],[Wartosc],[Wielkosc]) Values(" + "'" + czas + "'" + "," + prad2 + ",'A')";
                                cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 //-wyswietlanie danych
                                //    cmd.CommandText = "DELETE FROM Pomiary"; cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 //-wyswietlanie danych
                            }
                            catch (Exception ex)
                            {
                                ErrorLabel.Text = "Błąd " + ex.Message;
                            }
                        }
                        finally
                        {
                            mut.ReleaseMutex();//wylaczenie muteksu
                            Thread.Sleep(100);
                        }

                    }
                    conn.Close();//zamknac polaczenie z baza 
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = "błąd " + ex.Message;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            Client.Connect(IPAddress.Parse("192.168.56.1"), 10000);
            Client2.Connect(IPAddress.Parse("192.168.56.1"), 10001);

            try
            { //najpierw sprawdzenie, czy muteks nie jest juz utworzony
                mut = new Mutex();//nie bylo muteksu
                ErrorLabel.Text = "Dołączono do Mutexu test";
            }
            catch (Exception ex) //nie ma muteksu.
            {
                //     mut = new Mutex();//nie bylo muteksu
                ErrorLabel.Text = "Błąd " + ex.Message;
            }
        }

        private void but2_eth_stop(object sender, EventArgs e)
        {
            isStop2 = true;
            but_Stop_Eth.Enabled = false;
            but_Start_Eth.Enabled = true;
        }

        private void but2_eth_start(object sender, EventArgs e)
        {
            try
            {
                NetworkStream Stream2 = Client2.GetStream();
                SWrite2 = new BinaryWriter(Stream2);//strumien zapisu
                Sread2 = new BinaryReader(Stream2); //strumien odczytu

                ErrorLabel.Text = "Połączono z 2 metexem";
                timer1.Interval = 1000;
                timer1.Enabled = true;
                opened2 = true;
                isStop2 = false;

                w2 = new Thread(watek2);//obiekt watku 
                w2.Start();//start watku z procedura watek1
                but_Stop_Eth.Enabled = true;
                but_Start_Eth.Enabled = false;
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                ErrorLabel.Text = "Błąd połączenia 2." + " " + ex.Message;
                opened = false;
                but_Stop_Eth.Enabled = false;
                but_Start_Eth.Enabled = true;
            }
        }

        private void but1_eth_start(object sender, EventArgs e)
        {
            try
            {
                NetworkStream Stream = Client.GetStream();
                SWrite = new BinaryWriter(Stream);//strumien zapisu
                Sread = new BinaryReader(Stream); //strumien odczytu

                ErrorLabel.Text = "Połączono z 1 metexem";
                timer1.Interval = 1000;
                timer1.Enabled = true;
                opened = true;

                isStop = false;
                w1 = new Thread(watek);//obiekt watku 
                w1.Start();//start watku z procedura watek1
                but_Start_RS.Enabled = false;
                but_Stop_RS.Enabled = true;
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                ErrorLabel.Text = "Błąd połączenia 1." + " " + ex.Message;
                opened = false;
                but_Start_RS.Enabled = true;
                but_Stop_RS.Enabled = false;
            }
        }

        private void but1_eth_stop(object sender, EventArgs e)
        {
            isStop = true;
            but_Stop_RS.Enabled = false;
            but_Start_RS.Enabled = true;
        }

        private void TimerTIK(object sender, EventArgs e)
        {
            Data.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            Wart_U_RS.Text = Convert.ToString(napiecie);
            Wart_I_RS.Text = Convert.ToString(prad);
            Wart_U_Eth.Text = Convert.ToString(napiecie2);
            Wart_I_Eth.Text = Convert.ToString(prad2);
        }

        private void ClickMenu1(object sender, EventArgs e)
        {
            Form3 okno = new Form3();
            okno.ShowDialog();
        }

        private void ClickMenu2(object sender, EventArgs e)
        {
            Form2 okno = new Form2();
            okno.ShowDialog();
        }

        private void ClickMenu3(object sender, EventArgs e)
        {
            Close();
        }
    }
}