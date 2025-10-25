using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_taxes.Entities
{
    public class LegalEntity : calculationBasis
    {
        public LegalEntity()
        {
        }

        public LegalEntity(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            NumberEmployees = employees;
        }

        public int NumberEmployees { get; set; }

        public override double Calculatetax()
        {
            if(NumberEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }

    }
}
