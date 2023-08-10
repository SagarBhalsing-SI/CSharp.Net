using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    delegate string DelegateCurrency(double x);

    internal class Currency
    {
        public string FormatCurrency(double x)
        {
            return $"Currency:{x}";
        }
        public string PercentageCurrency(double x) 
        {
            return $"Percentage Currency:{x*100}";
        }

        public void DisplayCurrency(List<double> number,DelegateCurrency Formatter)
        {
            foreach(double i in number) 
            {
                Formatter(i);
            }
        }
        
        
    }

}
