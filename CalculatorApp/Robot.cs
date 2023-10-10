using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Robot
    {
        public string name;
        private string _serialNumber;
        public Robot(string serialNumber)
        {
            _serialNumber = serialNumber;   
            Console.WriteLine("Konstruktor");
        }
        public void SayHello()
        {
            Console.WriteLine("Cześć! Jestem robot. Mój seryjny numer to:" + _serialNumber);
        }
        public DateTime GetCurrentDate()
        {
            return DateTime.Now;    
        }
    }
}
