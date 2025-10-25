using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public string Name { get; set; }
        public int Hours { get; set; }

        public double ValuePerHour { get; set; }




        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.Append(Name);

            sb.AppendLine(" - R$" + Payment());

            return sb.ToString();

        }


    }
}
