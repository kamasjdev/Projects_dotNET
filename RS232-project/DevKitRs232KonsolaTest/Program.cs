using System;
using System.Linq;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace DevKitRs232KonsolaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przykład rs232 na konsole. ");
            SerialPort serial = new SerialPort();//Deklaracja obiektu
            serial.PortName = "COM1";//port w DEVKIT!
            serial.BaudRate = 9600;
           // serial.BaudRate = 19200;
            serial.Parity = Parity.None;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.Handshake = Handshake.None;
            serial.Open();//otwiera port
            //wysylanie ciagow znakow na ekranie devKit i do rs232
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Linia " + i);//ekran
                Thread.Sleep(1000);//opoznienie 1 sek
                serial.WriteLine("Linia " + i);// \r na poczatek linii odpowiedź w terminalu
            }
            serial.WriteLine("Koniec");
            serial.Close();//zamyka port
            Console.WriteLine("Naciśnij enter by zakończyć...");
            Console.ReadLine();
        }
    }
}
