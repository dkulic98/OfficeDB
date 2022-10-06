using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office1 = new Office("Elektro", "elektronika", 2012);
            Office office2 = new Office("Programming", "programiranje", 2015);

            Owner owner1 = new Owner("Ilija", "Matić");
            Owner owner2 = new Owner("Laura", "Matić");
            Owner owner3 = new Owner("Marin", "Ilić");

            office1.AddOwner(owner1);
            office1.AddOwner(owner2);
            office2.AddOwner(owner1);
            office2.AddOwner(owner3);

            owner1.AddOffice(office1);
            owner1.AddOffice(office2);
            owner2.AddOffice(office1);
            owner3.AddOffice(office2);

            Laptop laptop = new Laptop("AsusTek Computer Incorporated", "X756UQK", 2017, "Windows 10", "Asus");
            Desktop desktop1 = new Desktop("Avenio", "Avenio ProOffice", 2016, "Windows 7", "HP");
            Desktop desktop2 = new Desktop("HP Company", "OMEN 875-0019ny", 2018, "FreeDOS", "Logitech");
            Tablet tablet1 = new Tablet("Acer Incorporated", "Iconia One 8 B1-850", 2016, "Android 5.1", "8 inch");
            Tablet tablet2 = new Tablet("Samsung Electronics", "Galaxy Tab S6", 2019, "Android 9.0", "10,5 inch");

            office1.AddComputer(laptop);
            office1.AddComputer(desktop1);
            office1.AddComputer(tablet1);

            office2.AddComputer(laptop);
            office2.AddComputer(desktop2);
            office2.AddComputer(tablet2);

            Console.WriteLine(office1);
            office1.PrintOwners();
            office1.ComputeAll();
            Console.WriteLine("Prosječna starost računala u ovoj tvrtki je: " + office1.CalculateYear() + "\n");

            Console.WriteLine(office2);
            office2.PrintOwners();
            office2.ComputeAll();
            Console.WriteLine("Prosječna starost računala u ovoj tvrtki je: " + office2.CalculateYear() + "\n");

            Console.WriteLine(owner1);
            owner1.PrintOffices();
            Console.WriteLine();

            office1.RemoveComputer(laptop);
            office2.RemoveComputer(tablet2);
            office2.RemoveOwner(owner1);
            owner1.RemoveOffice(office2);
            Console.WriteLine();

            Console.WriteLine("Nakon uklanjanja računala:\n" + office1);
            office1.PrintOwners();
            office1.PrintComputers();
            Console.WriteLine("Prosječna starost računala je: " + office1.CalculateYear() + "\n");

            Console.WriteLine("Nakon uklanjanja računala:\n" + office2);
            office2.PrintOwners();
            office2.PrintComputers();
            Console.WriteLine("Prosječna starost računala je: " + office2.CalculateYear() + "\n");
        }
    }
}
