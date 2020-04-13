using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.SqlServerCe;

namespace ProjektKoncowyDevKit
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            String strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            //dodaje do sciezki programu exe nazwe pliku bazy danych 
            String strFullPathToMyFile = Path.Combine(strAppDir, "Database1.sdf");
            string sdfPath = @"ścieżka do bazy\AppDatabase1.sdf";
            //definicja obiektu polaczenia z bazą 
            //SqlCeConnection conn = new SqlCeConnection("Data Source = " + strFullPathToMyFile);
            SqlCeConnection conn = new SqlCeConnection("Data Source = " + sdfPath);
            try
            {
                conn.Open();//proba polaczenia z bazą //-dodawanie danych 
                //odczyt rekordow z tabeli
                SqlCeDataAdapter a = new SqlCeDataAdapter("SELECT * FROM pomiary", conn);
                //obiekt wirtualnej tabeli w pamieci
                DataTable t = new DataTable();
                //wypelnienie tabel w pamieci
                a.Fill(t);
                //polaczenie tabeli z gridem. Dane są wyświetlone!
                dataGrid1.DataSource = t;
                conn.Close();//zamknac polaczenie z baza 
            }
            catch (Exception ex)
            {
                conn.Close();//zamknac polaczenie z baza 
                ErrorsLabel.Text = "Błąd " + ex.Message;
            }
        }
    }
}