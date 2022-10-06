using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Laptop : Computer
    {
        string touchpad;

        public Laptop(string manufacturer, string model, int year, string OS, string touchpad) 
            : base(manufacturer, model, year, OS)
        {
            this.touchpad = touchpad;
        }

        public override void Compute()
        {
            int sum = 0;
            for (int i = 2; i < 10; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(this + " Ovo računalo računa zbroj svih parnih brojeva do 10. Rezultat je " + sum + ".");
        }

        public override string ToString()
        {
            string str = "Prijenosno računalo (laptop) " + base.ToString();
            return str;
        }
    }
}
