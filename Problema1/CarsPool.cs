using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public  class CarsPool
    {
        private static List<Car> _available = new List<Car>();

        public static CarsPool pool = new CarsPool();


        public static CarsPool GetInstance()
        {
            return pool;
        }


        public Car checkCar(String carName, String color, int transm, int eng, int type)
        {
            if (type == 0)
            {
                Sedan sedan = (Sedan)_available.Find(item => item.GetName() == carName && item.GetColor() == color && item.GetTransm()==transm && item is Sedan);
                if (sedan != null)
                {
                    Console.WriteLine("Masina sedan a mai fost produsa! Va vom livra produsul intr-un timp mai scurt!");
                    return sedan;
                }
                else
                {
                    Console.WriteLine("Nu am mai vandut acest tip de masina sedan.Masina va fi livrata de indata ce va fi produsa. Va garantam ca merita asteptarea! ");
                    sedan = new Sedan(carName, color, transm, eng);
                    _available.Add(sedan);
                    return sedan;
                }
            }
            else
            {
                Coupe coupe = (Coupe)_available.Find(item => item.GetName() == carName && item.GetColor() == color && item.GetTransm() == transm && item is Coupe);
                if (coupe != null)
                {
                    Console.WriteLine("Masina coupe a mai fost produsa! Va vom livra produsul intr-un timp mai scurt!");
                    return coupe;
                }
                else
                {
                    Console.WriteLine("Nu am mai vandut acest tip de masina coupe . Masina va fi livrata, de indata ce va fi produsa. Va garantam ca merita asteptarea! ");
                    coupe = new Coupe(carName, color, transm, eng);
                    _available.Add(coupe);
                    return coupe;
                }
            }
        }

        public void displayAllCarsEver()
        {
            if(_available.Count == 0)
                Console.WriteLine("Nu am vandut produs/vandut nicio masina! ");
            else
                _available.ForEach(item=> Console.WriteLine(item.GetName() + "  " + item.GetType().Name + "  " + item.GetColor()));
        }


    }
}
