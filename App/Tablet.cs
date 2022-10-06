using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Tablet : Computer
    {
        string touchscreen;

        public Tablet(string manufacturer, string model, int year, string OS, string touchscreen)
            : base(manufacturer, model, year, OS)
        {
            this.touchscreen = touchscreen;
        }

        public override void Compute()
        {
            int sum = 0;
            for (int i = 1; i < 10; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(this + " Ovo računalo računa zbroj svih neparnih brojeva do 10. Rezultat je " + sum + ".");
        }

        public override string ToString()
        {
            string str = "Prijenosno računalo (tablet) " + base.ToString();
            return str;
        }
    }
}
