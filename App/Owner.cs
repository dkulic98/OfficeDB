using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Owner
    {
        string owner_name; //ime vlasnika
        public string OwnerName
        {
            get { return owner_name; }
        }
        string owner_surname; //prezime vlasnika
        public string OwnerSurname
        {
            get { return owner_surname; }
        }
        HashSet<Office> Offices = new HashSet<Office>(); //tvrtke

        public Owner(string owner_name, string owner_surname)
        {
            this.owner_name = owner_name;
            this.owner_surname = owner_surname;
        }

        public void AddOffice(Office O)
        {
            Offices.Add(O);
        }

        public Office FindOffice(Office O)
        {
            if (Offices.Contains(O))
                return O;
            else
                return null;
        }

        public void RemoveOffice(Office O)
        {
            O = FindOffice(O);
            if (O != null)
            {
                Offices.Remove(O);
                Console.WriteLine("Tvrtka je uklonjena.");
            }
        }

        public void PrintOffices()
        {
            Console.WriteLine(@"Tvrtke: ");
            foreach (Office O in Offices)
            {
                Console.WriteLine(O);
            }
        }

        public override string ToString()
        {
            string str = owner_name + ' ' + owner_surname;
            return str;
        }
    }
}
