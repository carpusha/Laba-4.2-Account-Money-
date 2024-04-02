using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public bool IsBlocked { get; set; }

        public Account(string accountNumber, decimal balance, bool isBlocked)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.IsBlocked = isBlocked;
        }


        public void BlockAccount()
        {
            this.IsBlocked = true;
        }

        public void UnblockAccount()
        {
            this.IsBlocked = false;
        }
    }

}
