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
    public partial class Pojedynczo : Form
    {
        public Pojedynczo()
        {
            InitializeComponent();
        }

        private void osobyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osobyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.labdbDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'labdbDataSet.Osoby' . Możesz go przenieść lub usunąć.
            this.osobyTableAdapter.Fill(this.labdbDataSet.Osoby);

        }
    }
}
