using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    { 
        List<Car> GetAllCars();
        void AddCar(Car car);
        void DeleteCar(Car car);
        void UpdateCar(Car car);
        List<Car> GetCarById(int carId);
    }
}
