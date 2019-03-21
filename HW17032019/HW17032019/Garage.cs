using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17032019
{
    class Garage : IGarage
    {
        private List<Car> cars = new List<Car>();
        private List<string> CarTypes = new List<string>();

        public Garage(List<string> carTypes )
        {
            CarTypes = carTypes;
                
        }
        public void AddCar(Car car)
        {
            
            if(cars == null)
            {
                throw new CarNullException();
            }
            if(cars.Contains(car))
            {
                throw new CarAlredyHereException();
            }
            if(car.TotalLost)
            {
                throw new WeDoNotFixTotalLostExption();
            }
            if(!CarTypes.Contains(car.Brand))
            {
                throw new WrongGarageException();
            }
            if(! car.NeedsRepair)
            {
                throw new RepairMismatchException();
            }
            else
            {
                cars.Add(car);
            }

        }
        public void TakeOutCar(Car car)
        {
            if(car == null)
            {
                throw new CarNullException();
            }
            if(! cars.Contains(car))
            {
                throw new CarNotInGarageException();
            }
            if(car.NeedsRepair)
            {
                throw new CarNotReadyExcption();
            }
            else
            {
                cars.Remove(car);
            }
        }
        public bool FixCar(Car car)
        {
            if(car == null)
            {
                throw new CarNullException();
            }
            if(! cars.Contains(car))
            {
                throw new CarNotInGarageException();
            }
            if(! car.NeedsRepair)
            {
                throw new RepairMismatchException();
            }
            return !car.NeedsRepair;
        }
    }
}
