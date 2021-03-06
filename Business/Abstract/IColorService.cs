using Core.Utilities.Results;
using Entities.Conctrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
       
       }
}
