using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PassV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // data collection
            Console.WriteLine("Please input your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your BirthDay");
            string birthday = Console.ReadLine();
            Console.WriteLine("Please input your LuckyNumber");
            string luckynumber = Console.ReadLine();
            Console.WriteLine("Please input your Pet Name");
            string petname = Console.ReadLine();
            // Data Encription
            string full = (name+birthday+luckynumber+petname);
            byte[] bite = Encoding.Default.GetBytes(full);
            var hexString = BitConverter.ToString(bite);
            hexString = hexString.Replace("-", "");
            // Generate Random Number
            Random casualnumber = new Random();
            int numero1 = casualnumber.Next(1, 999);
            // Add A Simbol
            string simbol = ("%");
            // Add Random Number And Show Result
            Console.WriteLine("your Secure Password is = "+name+hexString+simbol+numero1);
            Thread.Sleep(9000);
         }
    }
}
