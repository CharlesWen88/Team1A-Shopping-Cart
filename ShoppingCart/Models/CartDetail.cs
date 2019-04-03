﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class CartDetail
    {
        public int CartId { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string LastUpdateDate { get; set; }
    }
}