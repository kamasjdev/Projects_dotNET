using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool wyswietl_tabele = false;
        int KolorR = 0, KolorG, KolorB;

        private void ShowUnshowTable(object sender, EventArgs e)
        {
            wyswietl_tabele = (wyswietl_tabele) ? false : true;
            if (wyswietl_tabele)
            {
                timer1.Interval = 1000;
                pomiaryDataGridView.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                pomiaryDataGridView.Visible = false;
                timer1.Enabled = false;
                label2.ForeColor = System.Drawing.Color.Black;
                label2.Text = "Zamknięto połączenie";
            }
        }

        private void pomiaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pomiaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.boxJenkinsDataSet);

        }

        private void Refreshing1s(object sender, EventArgs e)
        {
            string istcpconn = "";
           // string queryString = "SELECT TOP 2 [polaczenia] FROM Archiwum"; // komenda przeszukiwanie tabeli konta i sprawdzająca dane loginu i hasla             
            string queryString = "SELECT [polaczenia] FROM pomiary"; // komenda przeszukiwanie tabeli konta i sprawdzająca dane loginu i hasla             
                                                                     //komenda do połaczenia z bazą             
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BoxJenkinsConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(queryString, conn);
                conn.Open();

                //połączenie z bazą danych
                using (SqlDataReader Areader = cmd.ExecuteReader())
                {
                    while (Areader.HasRows) //jeśli są rekordy.
                    {
                        if
                         (!Areader.Read())
                            break;    //odczyt rekordu
                        if (Areader["polaczenia"].ToString().Equals("M"))
                        {
                            label2.ForeColor = System.Drawing.Color.Green; ;
                            istcpconn = "Połączono z Symulatorem Mutex";
                            label2.Text = istcpconn;
                        }
                        if (Areader["polaczenia"].ToString().Equals("N"))
                        {
                            label2.ForeColor = System.Drawing.Color.Red; ;
                            istcpconn = "Brak Połączenia z Symulatorem";
                            label2.Text = istcpconn;
                        }

                    }
                    //rozłączenie z bazą danych
                }
                conn.Close();
                //rozłączenie z bazą danych
            }
            if (istcpconn == "")
            {
                label2.ForeColor = System.Drawing.Color.Black;
                istcpconn = "Baza nie posiada danych";
                label2.Text = istcpconn;
            }
            if(istcpconn == "M")
            {
                label2.ForeColor = System.Drawing.Color.Green;
                istcpconn = "Połączono z Symulatorem Mutex";
                label2.Text = istcpconn;
            }
            this.pomiaryTableAdapter.Fill(this.boxJenkinsDataSet.Pomiary);
            label6.ForeColor = Color.FromArgb(KolorR, KolorG, KolorB);
            KolorR = KolorR + KolorB;
            KolorG = KolorG +5;
            KolorB = KolorB + KolorG;
            
            KolorR = (KolorR > 255) ? KolorR = 0 : KolorR = KolorR;
            KolorG = (KolorG > 255) ? KolorG = 0 : KolorG = KolorG;
            KolorB = (KolorB > 255) ? KolorB = 0 : KolorB = KolorB;
        }
    }
    
}
