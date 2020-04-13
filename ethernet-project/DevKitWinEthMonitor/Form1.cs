using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;



namespace DevKitWinEthMonitor
{
    public partial class Monitor_Pomiarow : Form
    {
        TcpClient Client2 = new TcpClient();
        TcpClient Client = new TcpClient();
        BinaryWriter SWrite = null;
        BinaryWriter SWrite2 = null;
        BinaryReader Sread = null;
        BinaryReader Sread2 = null;
        bool opened = false;

        public Monitor_Pomiarow()
        {
            InitializeComponent();
        }

        private void Connect_To_IP(object sender, EventArgs e)
        {
            Status.Text = "";
            Historia_Pomiarow.Visible = true;
            Historia_Pomiarow.BackColor = Color.White;
            try
            {
                Client.Connect(IPAddress.Parse(IP_pom.Text), Convert.ToInt32(TCP_Box.Text));
                Client2.Connect(IPAddress.Parse(IP_pom2.Text), Convert.ToInt32(TCP_Box_2.Text));
                NetworkStream Stream = Client.GetStream();
                NetworkStream Stream2 = Client2.GetStream();
                SWrite = new BinaryWriter(Stream);//strumien zapisu
                Sread = new BinaryReader(Stream); //strumien odczytu
                SWrite2 = new BinaryWriter(Stream2);//strumien zapisu
                Sread2 = new BinaryReader(Stream2);
                Status.ForeColor = Color.Lime;
                
                Status.Text = "Połączono";
                timer1.Interval = 1000;
                timer1.Enabled = true;
                opened = true;
            }
            catch (Exception ex)
            {
                Status.ForeColor = Color.Red;
                timer1.Enabled = false;
                Status.Text = "Błąd połączenia." + " " + ex.Message;
                opened = false;
            }
        }

        private void Disconnect_IP(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (opened)
            {
                SWrite.Close();
                Client.Close();
                Client2.Close();
            }
            Close();
        }

        private void Zegarr(object sender, EventArgs e)
        {
            int[] tablica_nap = new int[5];
            int[] tablica_prad = new int[5];
            Historia_Pomiarow.Visible = true;
            Historia_Pomiarow.BackColor = Color.White;
            Nap1.BackColor = Color.White;
            Nap2.BackColor = Color.White;
            Nap3.BackColor = Color.White;
            Nap4.BackColor = Color.White;
            Nap5.BackColor = Color.White;
            Prad1.BackColor = Color.White;
            Prad2.BackColor = Color.White;
            Prad3.BackColor = Color.White;
            Prad4.BackColor = Color.White;
            Prad5.BackColor = Color.White;

            string message;
            for (int i = 0; i < 5; i++)
            {
                message = Convert.ToString(i+1);
                SWrite.Write(Convert.ToByte(message)); //zamienia na int i wysyla 
                int response = Sread.ReadInt16(); //odczyt odpowiedzi w postaci int 
                tablica_nap[i] = response;

                message = Convert.ToString((i + 1) * 10 + (i + 1));
                SWrite.Write(Convert.ToByte(message)); //zamienia na int i wysyla 
                response = Sread.ReadInt16();
                tablica_prad[i] = response;
                Thread.Sleep(1);
            }

            Nap1.Text = Convert.ToString(tablica_nap[0]);
            Prad1.Text = Convert.ToString(tablica_prad[0]);
            Nap2.Text = Convert.ToString(tablica_nap[1]);
            Prad2.Text = Convert.ToString(tablica_prad[1]);
            Nap3.Text = Convert.ToString(tablica_nap[2]);
            Prad3.Text = Convert.ToString(tablica_prad[2]);
            Nap4.Text = Convert.ToString(tablica_nap[3]);
            Prad4.Text = Convert.ToString(tablica_prad[3]);
            Nap5.Text = Convert.ToString(tablica_nap[4]);
            Prad5.Text = Convert.ToString(tablica_prad[4]);

            int licznik = 0;
            int p1, p2, p3, p4;
            try
            {
                p1 = Convert.ToInt32(Napiecie_od.Text);
                p2 = Convert.ToInt32(Napiecie_do.Text);
            }
            catch
            {
                p1 = 0;
                p2 = 25;
            }

            for (int i = 0; i < 5; i++)
            {
                int indeks;
                Historia_Pomiarow.Items.Add("Napięcie: " + tablica_nap[i] + " [V]" + "\nPrąd: " + tablica_prad[i] + " [A]");
                if (tablica_nap[i] > p1 && tablica_nap[i] < p2)
                {
                    indeks = i+1;
                    licznik += 1;
                    switch (indeks)
                    {
                        case 1:
                            Nap1.BackColor = Color.White;
                            break;
                        case 2:
                            Nap2.BackColor = Color.White;
                            break;
                        case 3:
                            Nap3.BackColor = Color.White;
                            break;
                        case 4:
                            Nap4.BackColor = Color.White;
                            break;
                        case 5:
                            Nap5.BackColor = Color.White;
                            break;
                    }
                }
                else
                {
                    indeks = i+1;
                    switch (indeks)
                    {
                        case 1:
                            Nap1.BackColor = Color.Red;
                            break;
                        case 2:
                            Nap2.BackColor = Color.Red;
                            break;
                        case 3:
                            Nap3.BackColor = Color.Red;
                            break;
                        case 4:
                            Nap4.BackColor = Color.Red;
                            break;
                        case 5:
                            Nap5.BackColor = Color.Red;
                            break;
                    }
                }
                Thread.Sleep(1);
            }
           
            if (licznik == 5)
            {
                panel1.BackColor = Color.Lime;
                string wiadomosc = "1";
                SWrite2.Write(Convert.ToByte(wiadomosc)); //zamienia na int i wysyla 
                int odp = Sread2.ReadInt16(); //odczyt odpowiedzi w postaci int 
            }
            else
            {
                panel1.BackColor = Color.Red;
                string wiadomosc = "2";
                SWrite2.Write(Convert.ToByte(wiadomosc)); //zamienia na int i wysyla 
                int odp = Sread2.ReadInt16(); //odczyt odpowiedzi w postaci int 
            }

            int licznik2 = 0;

            try
            {
                p3 = Convert.ToInt32(Prad_od.Text);
                p4 = Convert.ToInt32(Prad_do.Text);
            }
            catch
            {
                p3 = 0;
                p4 = 25;
            }

            for (int i = 0; i < 5; i++)
            {
                int indeks;

                if (tablica_prad[i] > p3 && tablica_prad[i] < p4)
                {
                    indeks = i+1;
                    licznik2 += 1;
                    switch (indeks)
                    {
                        case 1:
                            Prad1.BackColor = Color.White;
                            break;
                        case 2:
                            Prad2.BackColor = Color.White;
                            break;
                        case 3:
                            Prad3.BackColor = Color.White;
                            break;
                        case 4:
                            Prad4.BackColor = Color.White;
                            break;
                        case 5:
                            Prad5.BackColor = Color.White;
                            break;
                    }
                }
                else
                {
                    indeks = i+1;
                    switch (indeks)
                    {
                        case 1:
                            Prad1.BackColor = Color.Red;
                            break;
                        case 2:
                            Prad2.BackColor = Color.Red;
                            break;
                        case 3:
                            Prad3.BackColor = Color.Red;
                            break;
                        case 4:
                            Prad4.BackColor = Color.Red;
                            break;
                        case 5:
                            Prad5.BackColor = Color.Red;
                            break;
                    } 
                }
                Thread.Sleep(1);
            }

            if (licznik2 == 5)
            {
                panel2.BackColor = Color.Lime;
                string wiadomosc = "11";
                SWrite2.Write(Convert.ToByte(wiadomosc)); //zamienia na int i wysyla 
                int odp = Sread2.ReadInt16(); //odczyt odpowiedzi w postaci int 
            }
            else
            {
                panel2.BackColor = Color.Red;
                string wiadomosc = "22";
                SWrite2.Write(Convert.ToByte(wiadomosc)); //zamienia na int i wysyla 
                int odp = Sread2.ReadInt16(); //odczyt odpowiedzi w postaci int 
            }

            Historia_Pomiarow.SelectedIndex = Historia_Pomiarow.Items.Count - 1;
            try
            {
                if (Historia_Pomiarow.TopIndex != Historia_Pomiarow.SelectedIndex)
                    // Make the currently selected item the top item in the ListBox.
                    Historia_Pomiarow.TopIndex = Historia_Pomiarow.SelectedIndex;
            }
            catch { }
        }

        private void Clear_ListBox(object sender, EventArgs e)
        {
            Historia_Pomiarow.Items.Clear();
        }
    }
}
