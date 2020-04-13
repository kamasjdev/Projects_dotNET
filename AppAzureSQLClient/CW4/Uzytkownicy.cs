using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW4
{
    public partial class Uzytkownicy : Form
    {
        public Uzytkownicy()
        {
            InitializeComponent();
        }

        private void Uzytkownicy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'labdbDataSet.VKonta' . Możesz go przenieść lub usunąć.
            this.vKontaTableAdapter.Fill(this.labdbDataSet.VKonta);

        }
    }
}
