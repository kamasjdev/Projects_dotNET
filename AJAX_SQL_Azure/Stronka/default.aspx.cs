using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stronka
{
    public partial class _default : System.Web.UI.Page
    {

        bool zalogowano()
        {
            string queryString = "SELECT * FROM konta where login=@login and haslo=@haslo"; // komenda przeszukiwanie tabeli konta i sprawdzająca dane loginu i hasla
            string connectionString = ConfigurationManager.ConnectionStrings["labdbConnectionString"].ConnectionString; //komenda do połaczenia z bazą
            using (SqlConnection connection = new SqlConnection(connectionString)) //polaczenie z baza danych
            {
                SqlCommand command = new SqlCommand(queryString, connection); //wyslanie komendy 
                command.Parameters.AddWithValue("login", TextBox1.Text); //odczyt loginu z pola tekstowego
                command.Parameters.AddWithValue("haslo", TextBox2.Text); //odczytanie hasla z pola tekstowego
                connection.Open();  //otwarcie polaczenia
                SqlDataReader reader = command.ExecuteReader(); //odczyt przychodzacych informacji
                try
                {
                    if (!reader.Read()) //brak konta
                    {
                        
                        Session["zalogowano"] = "";//brak danych logowania
                        return false;
                    }
                    else //jest konto
                    {
                        Session["zalogowano"] = reader["nazwisko"] + " " + reader["imie"];
                        return true;
                    }
                }
                finally
                {
                    reader.Close(); //zamkniecie polaczenia
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            if (zalogowano())
            {
                Label2.ForeColor = System.Drawing.Color.Black;
                Label2.Text = "Zalogowano: " + Session["zalogowano"].ToString();
                LinkButton2.Visible = true;
                LinkButton1.Visible = false;
                panelLogin.Visible = false;
                panelTabela.Visible = true;
                LinkButton2.Text = "Wyloguj " + Session["zalogowano"].ToString();
                Label3.Text = "Web chat";

            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "Złe konto lub hasło!";      
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label2.Text = "wylogowano";
            LinkButton2.Visible = false;
            LinkButton1.Visible = true;
            Session["zalogowano"] = "";
            panelTabela.Visible = false;
            panelLogin.Visible = true;
            Label3.Text = "Azure Web Chat";

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            GridView1.DataBind();//aktualizacja elementu
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (tresc.Text.Length == 0) return;//walidacja
            if (Session["zalogowano"] is null || Session["zalogowano"].ToString().Length == 0) return;
            //brak logowania
            //podstawienie do zapisu
            SqlDataSource1.InsertParameters["login"].DefaultValue = Session["zalogowano"].ToString();
            SqlDataSource1.InsertParameters["tresc"].DefaultValue = tresc.Text;
            SqlDataSource1.InsertParameters["data"].DefaultValue = DateTime.Now.ToString();
            SqlDataSource1.Insert();
            SqlDataSource1.DataBind();
            tresc.Text = "";
        }
    }
}