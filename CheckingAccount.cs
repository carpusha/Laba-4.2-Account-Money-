using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{

    internal class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        public CheckingAccount(string accountNumber, decimal balance, bool isBlocked, decimal overdraftLimit)
        : base(accountNumber, balance, isBlocked)
        {
            OverdraftLimit = overdraftLimit;
        }


    }

}
