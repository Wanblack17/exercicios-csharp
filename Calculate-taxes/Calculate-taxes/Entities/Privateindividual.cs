using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_taxes.Entities
{
    public class Privateindividual : calculationBasis
    {
        public Privateindividual()
        {
        }

        public Privateindividual(string name, double annualIncome, double health) : base(name, annualIncome)
        {
            HealthExpenses = health;
        }

        public double HealthExpenses{ get; set; }


        public override double Calculatetax()
        {
            if(AnnualIncome < 20000)
            {
                if (HealthExpenses > 0)
                {
                    return (AnnualIncome * 0.15) - (HealthExpenses / 2);
                }
                else
                {
                    return (AnnualIncome * 0.15);
                }
            }
            else
            {
                if (HealthExpenses > 0)
                {
                    return (AnnualIncome * 0.25) - (HealthExpenses / 2);
                }
                else
                {
                    return (AnnualIncome * 0.25);
                }
            }
        }






    }
}
