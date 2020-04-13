using System;
using System.Linq;
using System.IO.Ports;
using System.Collections.Generic;
using System.Text;

namespace PCRS232Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przykład rs232 na konsole PC");
            SerialPort serial = new SerialPort();
            serial.PortName = "COM1";
            serial.BaudRate = 9600;
            //serial.BaudRate = 19200;
            serial.Parity = Parity.None;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.Handshake = Handshake.None;
            serial.Open();
            //serial.ReadTimeout = 1000;//wprowadzenie timeoutu odczytu
            for (int i = 0; i < 10; i++)
            {
               // string linia = serial.ReadLine();//odbior i blokada!
                //Console.WriteLine("Odebrano: " + linia);
                try //zabezpieczenie na wystapienie timeoutu
                {
                    string linia = serial.ReadLine(); //odbior
                    Console.WriteLine("Odebrano: " + linia);
                }
                catch
                {//w przypadku timeout program wchodzi w ta czesc
                    Console.WriteLine("Timeout. Brak danych do odbioru");
                }
            }
            serial.Close();
            Console.WriteLine("Naciśnij enter...");
            Console.ReadLine();
        }
    }
}
