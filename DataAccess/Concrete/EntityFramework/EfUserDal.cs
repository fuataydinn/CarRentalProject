﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfUserDal:EfEntityRepositoryBase<User,RentAcarDBContext>,IUserDal
    {
    }
}
