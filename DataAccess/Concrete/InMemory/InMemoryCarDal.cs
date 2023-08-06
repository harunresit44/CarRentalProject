using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{BrandId=1, CarId=1, ColorId=1, DailyPrice=200000, Description="Doğan SLX", ModelYear=1998},
                new Car{BrandId=2, CarId=2, ColorId=3, DailyPrice=1000000, Description="M5 E60", ModelYear=2005},
                new Car{BrandId=3, CarId=3, ColorId=2, DailyPrice=700000, Description="i20", ModelYear=2015},
                new Car{BrandId=4, CarId=4, ColorId=5, DailyPrice=2000000, Description="525D", ModelYear=2012},
                new Car{BrandId=5, CarId=5, ColorId=6, DailyPrice=9000000, Description="C63", ModelYear=2008},
            };
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }


        public void DeleteCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Car> GetCarById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
            
        }

      
        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;

        }
    }
}
