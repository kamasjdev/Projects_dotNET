using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;
using System.Reflection;
using System.IO.Ports;
using System.Threading;
namespace JedenWatek
{
    class Program
    {
        /// <summary>
        /// Klasa z procedura watku
        /// </summary>
        static Mutex mut;
        class Watek
        {
            /// <summary>
            /// Zmienna zatrzymujaca watek
            /// </summary>
            public bool isStop = false;
            /// <summary>
            /// Procedura uruchamiana w watku
            /// </summary>
            public void ProcWatek()
            {
                try
                {
                    String strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    String strFullPathToMyFile = Path.Combine(strAppDir, "AppDatabase1.sdf");
                    string sdfpath = @"sciezka\AppDatabase1.sdf";
                    SqlCeConnection conn = new SqlCeConnection("Data Source = " + sdfpath);
                    conn.Open();//proba polaczenia z bazą //-dodawanie danych 
                    SqlCeCommand cmd = conn.CreateCommand();//obiekt polecenia do bazy
                
                while (!isStop)//dziala w petli
                {
                    SerialPort serial = new SerialPort();//Deklaracja obiektu
                    serial.PortName = "COM3";//port w DEVKIT!
                    serial.BaudRate = 115200;
                    serial.Parity = Parity.None;
                    serial.DataBits = 8;
                    serial.StopBits = StopBits.One;
                    serial.Handshake = Handshake.None;

                    if (serial.IsOpen)
                        serial.Close();
                    try
                        {

                           serial.Open(); //otwarcie polaczenia RS232
                            serial.WriteLine("I");
                            string data = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            string odp = serial.ReadLine();
                            cmd.CommandText = "INSERT INTO Pomiary ([Data],[Wartosc],[Wielkosc]) Values(" + "'" + data + "'" + "," + odp + ",'V')";
                            cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 //-wyswietlanie danych
                            int WartI = Convert.ToInt16(odp);
                            Console.WriteLine("Watek 1 I " + WartI + "[A]");
                            serial.WriteLine("U");
                            odp = serial.ReadLine();
                            int WartU = Convert.ToInt16(odp);
                            Console.WriteLine("Watek 1 U " + WartU + "[V]");
                             Thread.Sleep(1000);
                             data = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                             cmd.CommandText = "INSERT INTO Pomiary ([Data],[Wartosc],[Wielkosc]) Values(" + "'" + data + "'" + "," + odp + ",'I')";
                             cmd.ExecuteNonQuery();//uruchomienie polecenia SQL 1 //-wyswietlanie danych 
                            serial.Close();
                         }
                        catch
                        {
                            Console.WriteLine("Błąd otwarcia portu");
                        }
                    finally
                    {
                        //mut.ReleaseMutex();//wylaczenie muteksu
                        Thread.Sleep(100);
                    }
                    }
                }
                catch
                {

                }
                }
            }
        
        /// <summary>
        /// Program glowny
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Watek w1 = new Watek();//obiekt z procedura watku
            Thread t1 = null;//obiekt na watek. Na razie pusty!
            Console.WriteLine("Info:");
            Console.WriteLine("1-start pomiarow");
            Console.WriteLine("2-stop pomiarow");
            Console.WriteLine("3-wyswietlanie danych");
            Console.WriteLine("4-koniec programu");

            try
            {
                //pobiera sciezke programu exe
                String strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                //dodaje do sciezki programu exe nazwe pliku bazy danych
                String strFullPathToMyFile = Path.Combine(strAppDir, "AppDatabase1.sdf");
                string sdfpath = @"sciezka\AppDatabase1.sdf";
                SqlCeConnection conn = new SqlCeConnection("Data Source = " + sdfpath);
                conn.Open();//proba polaczenia z bazą
                SqlCeCommand cmd = conn.CreateCommand();//obiekt polecenia do bazy
                while (true)
                {
                    string zn = Console.ReadLine();//czyta klawisz
                    if (zn == "4")//koniec programu
                    {
                        if ((t1 != null))
                        { //sprawdzenie, czy watek juz nie dziala
                            Console.WriteLine("Watek ciagle działa!");
                            continue; //wraca na poczatek while
                        }
                        Console.WriteLine("Koniec pracy");
                        break; //koniec
                    }
                    if (zn == "1")//wlacza watek
                    {
                        if ((t1 != null))
                        { //sprawdzenie, czy watek juz nie dziala
                            Console.WriteLine("Watek juz działa!");
                            continue; //wraca na poczatek while
                        }
                        w1.isStop = false; //warunek dzialania watku
                        t1 = new Thread(w1.ProcWatek); //obiekt watku
                        t1.Start(); // uruchomienie w watku
                        Console.WriteLine("Start watek");
                    }
                    if (zn == "2")//wylacza watek
                    {
                        if ((t1 == null))
                        { //sprawdzenie, czy watek dziala
                            Console.WriteLine("Watek juz nie działa!");
                            continue; //wraca na poczatek while
                        }
                        w1.isStop = true;
                        t1 = null;
                        Console.WriteLine("Stop watek");
                    }
                        if (zn == "3")//wyswietlanie danych
                        {
                            
                                cmd.CommandText = "select * from Pomiary ";
                                SqlCeDataReader reader = cmd.ExecuteReader();//obiekt do odczytu danych 
                                try
                                {
                                
                                while (true)//petla po rekordach tabeli
                                {
                                    if (!reader.Read()) break; //EOF
                                    string wart = reader["wartosc"].ToString();//odczyt z pola wartosc
                                    string wielk = reader["wielkosc"].ToString();//odczyt z pola wielkosc
                                    Console.WriteLine("rekord: " + wart + ", " + wielk); //wyswietlenie
                                }

                                }
                                catch (Exception ex) { Console.WriteLine("Błąd " + ex.Message); }
                         //   w1.isStop = false; //warunek dzialania watku
                          //  t1 = new Thread(w1.ProcWatek); //obiekt watku
                          //  t1.Start(); // uruchomienie w watku
                         //   Console.WriteLine("Start watek");
                        

                    }
                }
                conn.Close();//zamknac polaczenie z baza
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd " + ex.Message);
            } 

        }
        
    }
}
