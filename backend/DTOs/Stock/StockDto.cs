using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTOs.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        //This ensures that property is never null when accessed
        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }
    }
}