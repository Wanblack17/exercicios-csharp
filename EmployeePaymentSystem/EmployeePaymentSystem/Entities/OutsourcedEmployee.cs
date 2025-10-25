using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public OutsourcedEmployee()
        {
        }
        public double AdittionalCharge { get; set; }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double adittionalcharge) : base(name, hours, valuePerHour)
        {
            AdittionalCharge = adittionalcharge;
        }

        public override double Payment()
        {
            double Pluspayment = AdittionalCharge * 1.1;
            return base.Payment() + Pluspayment;
        }

    }


}

