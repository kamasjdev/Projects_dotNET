using System;
using System.Linq;
using System.IO.Ports;
using System.Collections.Generic;
using System.Text;

namespace DevKitKonsolaEcho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Program demonstracyjny połączenie RS232");
            Console.WriteLine("");
            Console.WriteLine("Połącz DevKit z PC za pomocą RS232. ");
            Console.WriteLine("Uruchom Putty i pisz na klawiaturze PC.");
            Console.WriteLine("q = koniec.");
            Console.WriteLine("---------------------------------------");
            SerialPort com = new SerialPort();
            com.PortName = "COM1";  //COM3
            com.BaudRate = 115200;     //9600
            com.Parity = Parity.None;
            com.DataBits = 8;
            com.StopBits = StopBits.One;
            com.Handshake = Handshake.None;
            com.Open();
            com.ReadTimeout = 1000;//wprowadzenie timeoutu
            while (true)
            {
                int znak = 0;
                try //zabezpieczenie na wystapienie timeoutu
                {
                    znak = com.ReadChar(); //odbior
                    Console.Write((char)znak);
                }
                catch
                { }//Nie ma komunikatu o bledzie
                if (znak.Equals('q')) break;//wyjscie
            }
            com.Close();
        }
    }
}
