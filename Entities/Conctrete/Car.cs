using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Conctrete
{
   public class Car:IEntity
    {
        public int CarID { get; set; }
        public string CarName { get; set; } 
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string _Description { get; set; }
    }
}
