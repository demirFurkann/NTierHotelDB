﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Extra:BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }


        //Relational propeteis

        public virtual List<OrderExtra> OrderExtras { get; set; }

		public override string ToString()
		{
            return $"Yemek İsmi : {Name} \n Fiyatı :{UnitPrice}";
		}


	}
}
