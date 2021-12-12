using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentAcarDBContext>, ICustomerDal

    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentAcarDBContext context=new RentAcarDBContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserID
                             select new CustomerDetailDto
                             {
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email
                             };
                return result.ToList();
            }
        }
    }
}
