﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyDatabaseUsingDapper
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int StockLevel { get; set; }
        public bool OnSale { get; set; }
    }
}
