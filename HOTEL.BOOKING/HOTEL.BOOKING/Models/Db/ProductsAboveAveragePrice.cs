using System;
using System.Collections.Generic;

#nullable disable

namespace HOTEL.BOOKING.Models.Db
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
