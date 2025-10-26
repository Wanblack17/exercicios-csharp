using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Exceptions.Exceps;

namespace Exceptions.Entities
{
    public class Account
    {
        

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance  { get; set; }
        
        public double WithDrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw (double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Insufficient balance!");
            }
            else if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            Balance -= amount;
        }



    }
}
