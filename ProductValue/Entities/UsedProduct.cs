﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;


namespace ProductValue.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }

        public override string ToString()
        {
            return ($"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(manufacture date: {ManufactureDate})");
        }
    }
}
