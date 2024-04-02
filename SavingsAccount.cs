using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, decimal balance, bool isBlocked, decimal interestRate)
        : base(accountNumber, balance, isBlocked)
        {
           this.InterestRate = interestRate;
        }
    }

}
