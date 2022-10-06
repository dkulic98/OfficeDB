using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    abstract class Computer
    {
        string manufacturer; //proizvođač
        string model; //model računala
        public string Model
        {
            get { return model; }
        }

        int year; //godina proizvodnje
        string OS; //operacijski sustav

        public Computer(string manufacturer, string model, int year, string OS)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.year = year;
            this.OS = OS;
        }

        public virtual double CalculateYear()
        {
            return year;
        }
        
        public virtual void Compute()
        {
            Console.WriteLine("Greška.");
        }

        public override string ToString()
        {
            string str = manufacturer + ", model " + model + ", godine proizvodnje " + year + " ima instaliran " + OS + " operacijski sustav.";
            return str;
        }
    }
}
