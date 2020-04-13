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

namespace CW4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        bool zalogowano()
        {
            string queryString = "SELECT * FROM konta where login=@login and haslo=@haslo";
            string connectionString = ConfigurationManager.ConnectionStrings["CW4.Properties.Settings.labdbConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("login", textBox1.Text);
                command.Parameters.AddWithValue("haslo", textBox2.Text);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try {
                    if (!reader.Read())//brak konta
                        return false;
                    else //jest konto
                        return true;
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logowanie
            if (zalogowano())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                label5.Text = "Złe konto lub hasło";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
