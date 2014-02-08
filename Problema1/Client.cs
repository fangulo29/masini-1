using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Client: Persoana
    {

        List<Car> _cars = new List<Car>();

        public Client(String fname, String sname, int age)
            : base(fname, sname, age)
        {
        }

        public void AddCar (Car car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(String carname)
        {
            Car temp = _cars.Find(item => item.GetName() == carname);
            _cars.Remove(temp);
        }

        public void displayCars()
        {
            //daca lista nu e goala
            if (_cars.Count == 0)
                Console.WriteLine("Nu mai detineti nicio masina cumparata de la noi!");
            else
            {
                Console.WriteLine("::::::::Masinile domnului {0}:::::::: ", this.GetName());
                _cars.ForEach(item => Console.WriteLine(item.GetName() + "  " + item.GetType().Name));
            }

        }
    }
}
