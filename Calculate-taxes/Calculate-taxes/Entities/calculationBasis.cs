using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_taxes.Entities
{
    public abstract class calculationBasis
    {
        protected calculationBasis()
        {
        }

        protected calculationBasis(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        
        public abstract double Calculatetax();

    }
}
