using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Conctrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }   
    }
}
