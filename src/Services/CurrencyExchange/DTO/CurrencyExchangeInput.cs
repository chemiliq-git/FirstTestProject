﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyExchange.DTO
{
    public class CurrencyExchangeInput
    {
        public string FromCurrency { get; set; }
     
        public string ToCurrency { get; set; }

        public decimal Quantity { get; set; }
    }
}
