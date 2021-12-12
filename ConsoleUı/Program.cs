using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Conctrete;
using System;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { CarID = 3};
            var result = carManager.Delete(car);
            Console.WriteLine(result.Message);
            



           }

    }
}
