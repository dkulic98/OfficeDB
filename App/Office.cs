using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Office
    {
        string name; //ime tvrtke
        public string Name
        {
            get { return name; }
        }
        string field; //čime se bavi
        int founded; //godina osnivanja
        List<Computer> Computers = new List<Computer>(); //lista računala u tvrtki
        HashSet<Owner> Owners = new HashSet<Owner>(); //vlasnici tvrtke

        public Office(string name, string field, int founded)
        {
            this.name = name;
            this.field = field;
            this.founded = founded;
        }

        public void AddComputer(Computer C)
        {
            Computers.Add(C);
        }

        public void AddOwner(Owner O)
        {
            Owners.Add(O);
        }

        public Owner FindOwner(Owner O)
        {
            if (Owners.Contains(O))
                return O;
            else
                return null;
        }

        public void RemoveComputer(Computer C)
        {
            Computers.Remove(C);
            Console.WriteLine("Računalo je uklonjeno.");
        }

        public void RemoveOwner(Owner O)
        {
            O = FindOwner(O);
            if (O != null)
            {
                Owners.Remove(O);
                Console.WriteLine("Vlasnik je uklonjen.");
            }
        }

        public void ComputeAll()
        {
            foreach (Computer C in Computers)
                C.Compute();
        }

        public double CalculateYear()
        {
            double sum = 0.0;
            foreach (Computer C in Computers)
                sum = sum + C.CalculateYear();
            return (double)sum/Computers.Count;
        }

        public void PrintComputers()
        {
            Console.WriteLine(@"Računala u tvrtki:");
            foreach (Computer C in Computers)
            {
                Console.WriteLine(C);
            }
        }

        public void PrintOwners()
        {
            Console.WriteLine(@"Vlasnici tvrtke:");
            foreach (Owner O in Owners)
            {
                Console.WriteLine(O);
            }
        }

        public override string ToString()
        {
            string str = name + " je tvrtka osnovana " + founded + " godine. Uža specijalnost je " + field + ". Ima " + Computers.Count + " računala.";
            return str;
        }
    }
}
