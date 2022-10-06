using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Desktop : Computer
    {
        string mouse;

        public Desktop(string manufacturer, string model, int year, string OS, string mouse)
            : base(manufacturer, model, year, OS)
        {
            this.mouse = mouse;
        }

        public override void Compute()
        {
            int sum = 0;
            for (int i = 1; i < 10; i++) 
            {
                sum += i;
            }
            Console.WriteLine(this + " Ovo računalo računa zbroj svih brojeva do 10. Rezultat je " + sum + ".");
        }

        public override string ToString()
        {
            string str = "Stolno računalo " + base.ToString();
            return str;
        }
    }
}
