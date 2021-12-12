using Core.Utilities.Results;
using Entities.Conctrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult <List<Car>> GetCarsByBrandID(int id);
        IDataResult <List<Car>> GetCarsByColorID(int id);
        IDataResult< List<CarDetailDto>> GetCarDetails();
    }
}
