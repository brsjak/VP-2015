using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public class Converter
    {
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public decimal Multiplier { get; set; }

        public Converter(string currencyFrom, string currencyTo, decimal multiplier)
        {
            CurrencyFrom = currencyFrom;
            CurrencyTo = currencyTo;
            Multiplier = multiplier;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", CurrencyFrom, CurrencyTo);
        }
    }
}
