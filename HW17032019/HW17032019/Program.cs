using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17032019
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage( new List<string> { "Volvo Xc90", "Chevrolet Camaro", "Maserati", });
            Car car = new Car("Honda ", true, false);
            Car car1 = new Car("Volvo", false, false);
            Car car2 = new Car("Lamborgini", true, false);
            g.AddCar(car);
            g.FixCar(car1);
            g.TakeOutCar(car2);
            Console.WriteLine(g);
            

        }
    }
}
