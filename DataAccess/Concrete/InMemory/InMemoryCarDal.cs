using DataAccess.Abstract;
using Entities.Conctrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarID=1,BrandID=1,ColorID=1,_Description="Otomobil",DailyPrice=200,ModelYear=2021},
                new Car{CarID=2,BrandID=1,ColorID=2,_Description="Otomobil",DailyPrice=200,ModelYear=2021},
                new Car{CarID=3,BrandID=2,ColorID=1,_Description="SUV",DailyPrice=200,ModelYear=2021},
                new Car{CarID=4,BrandID=2,ColorID=1,_Description=" SUV",DailyPrice=200,ModelYear=2021},
                new Car{CarID=5,BrandID=3,ColorID=3,_Description="Minibüs",DailyPrice=200,ModelYear=2021},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarID==car.CarID);
            _cars.Remove(carToDelete);
          
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate._Description = car._Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
