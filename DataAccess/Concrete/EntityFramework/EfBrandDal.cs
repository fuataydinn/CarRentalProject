﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfBrandDal : EfEntityRepositoryBase<Brand,RentAcarDBContext>,IBrandDal
    {
        
    }
}