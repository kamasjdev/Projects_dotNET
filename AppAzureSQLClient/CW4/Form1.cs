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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabela f = new Tabela();
            f.ShowDialog();     // pokaz okno
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pojedynczo p = new Pojedynczo();
            p.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            login f = new login();//tworzenie obiektu okna
            if (f.ShowDialog() == DialogResult.Cancel)//wyświetlenie okna
            {
                Close();//anulowano bez logowania
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uzytkownicy u = new Uzytkownicy();
            u.ShowDialog();
        }
    }
}
