using Core.Utilities.Results;
using Entities.Conctrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer customer);
        IResult Delete(Customer custome);
        IResult Update(Customer custome);
    }
}
