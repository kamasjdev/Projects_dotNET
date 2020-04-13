using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DevKitOknoRS232
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void P1_On(object sender, EventArgs e)
        {
            int liczba = 1;
            try //zabezpieczenie na wystapienie timeoutu
            {
                Console.Write((char)liczba);
                serialPort1.WriteLine((Convert.ToString(liczba)));
            }
            catch
            { }//Nie ma komunikatu o bledzie
        }

        private void P1_Off(object sender, EventArgs e)
        {
            int liczba = 2;
            try //zabezpieczenie na wystapienie timeoutu
            {
                Console.Write((char)liczba);
                serialPort1.WriteLine(Convert.ToString(liczba));
            }
            catch
            { }//Nie ma komunikatu o bledzie
        }

        private void P2_On(object sender, EventArgs e)
        {
            int liczba = 11;
            try //zabezpieczenie na wystapienie timeoutu
            {
                Console.Write((char)liczba);
                serialPort1.WriteLine(Convert.ToString(liczba));  
            }
            catch
            { }//Nie ma komunikatu o bledzie
        }

        private void P2_Off(object sender, EventArgs e)
        {
            int liczba = 22;
            try //zabezpieczenie na wystapienie timeoutu
            {
                Console.Write((char)liczba);
                serialPort1.WriteLine(Convert.ToString(liczba));
            }
            catch
            { }//Nie ma komunikatu o bledzie
        }

        private void Openn(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd" + ex.Message);
                return;
            }
            serialPort1.ReadTimeout = 1000;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();//wyzwolenie stopera
            try
            {
                serialPort1.DiscardInBuffer();//czyszczenie pozostalosci bufora
                //serialPort1.WriteLine(komenda);//polecenie
                //… oczekiwanie na odpowiedz
                string linia = serialPort1.ReadLine();//odczyt potwierdzenia
            }
            catch {}
            stopWatch.Stop();//zatrzymanie stopera
            label4.Text = "Czas odpowiedzi:" + stopWatch.Elapsed.TotalMilliseconds;
        }

        private void Closee(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = serialPort1.ReadExisting();//czytanie istniejących danych
            Console.WriteLine("Data Received:");
            Console.Write(indata);

            try
            {
                string linia = serialPort1.ReadExisting();
                //ListBox1.Items.Add(linia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd odczytu danych z portu" + ex.Message);
            }
        }
    }
}