using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //if type == 0 -> Sedan sedan = CarsPool.checkCar(...)
            
            //creez seller
            //??
            String clientfname, clientsname, name, color;
            int type, transm, eng, age;
            int option;
            

            Seller salesman = new Seller("John", "Smith", 39);
            Client exist;
            //CarsPool pool;
            Console.WriteLine("Buna ziua!Astazi voi fi vanzatorul dumneavoastra! Alegeti o optiune : ");
            CarsPool pool = CarsPool.GetInstance();

            while (true)
            {
                Console.WriteLine("\n-----------------------------------------------------------------------------\n");
                Console.WriteLine("1. Afiseaza clienti - Tasta 1");
                Console.WriteLine("2. Cumpara masina - Tasta 2");
                Console.WriteLine("3. Afiseaza toate masinile vandute - Tasta 3");
                Console.WriteLine("4. Vinde masina - Tasta 4");
                Console.WriteLine("5. Afiseaza masinile unui client - Tasta 5\n\n");
                option = int.Parse(Console.ReadLine());


                if (option == 1)
                {
                    salesman.DisplayClients();
                }


                else if (option == 2)
                {
                    Console.WriteLine(" Primul nume: ");
                    clientfname = Console.ReadLine();
                    Console.WriteLine(" Prenumele: ");
                    clientsname = Console.ReadLine();
                    Console.WriteLine(" Varsta: ");
                    age = int.Parse(Console.ReadLine());

                    Console.WriteLine(" Tipul masinii:   Sedan - Tasta '0' ; Coupe - Tasta '1') : ");
                    type = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Numele masinii pe care doriti sa o achizitionati: ");
                    name = Console.ReadLine();
                    Console.WriteLine(" Culoarea masinii dorite: ");
                    color = Console.ReadLine();
                    Console.WriteLine(" Cutie manuala - Tasta '0'         Cutie automata - Tasta '1' ");
                    transm = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Diesel - Tasta '0'       Benzina - Tasta '1'");
                    eng = int.Parse(Console.ReadLine());

                    //caut clientu'

                    exist = salesman.searchClient(clientfname);
                    if (exist != null) //daca clientul a mai cumparat
                    {
                        Console.WriteLine("\n++++Dumneavoastra ati mai cumparat de la noi! Vom verifica daca este nevoie sau nu sa producem masina dorita...");
                        Car car = pool.checkCar(name, color, transm, eng, type);
                        exist.AddCar(car);
                    }
                    else
                    {
                        Console.WriteLine("\n----Nu ati mai cumparat de la noi!");
                        Console.WriteLine("Vom verifica daca este nevoie sau nu sa producem masina dorita...\n");
                        Car car = pool.checkCar(name, color, transm, eng, type);

                        exist = new Client(clientfname, clientsname, age);
                        exist.AddCar(car);
                        salesman.AddClient(exist);
                    }
                }


                else if (option == 3)
                {
                    pool.displayAllCarsEver();
                }


                else if (option == 4)
                {
                    Console.WriteLine(" Primul nume al clientului care doreste sa vanda: ");
                    clientfname = Console.ReadLine();
                    Console.WriteLine(" Numele masinii : ");
                    name = Console.ReadLine();
                    exist = salesman.searchClient(clientfname);
                    if (exist != null) //clientul exista ->sterg masina -> afisez
                    {
                        Console.WriteLine("\nBefore: ");
                        exist.displayCars();
                        exist.RemoveCar(name);
                        Console.WriteLine("\nAfter: ");
                        exist.displayCars();
                    }
                    else
                    {
                        Console.WriteLine("\nNe pare rau! Nu puteti vinde deoarece nu sunteti clientul nostru!\n");
                    }
                }


                else if (option == 5)
                {
                    Console.WriteLine(" Primul nume: ");
                    clientfname = Console.ReadLine();
                    exist = salesman.searchClient(clientfname);
                    if (exist != null) //clientul exista ->afisez masinile
                    {
                        exist.displayCars();
                    }
                    else
                        Console.WriteLine("Persoana pe care o cautati nu este clientul nostru!");
                }

                else
                {
                    break;
                }

            }
        }
    }
}
