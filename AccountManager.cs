using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class AccountManager
    {
        public List<Account> Accounts { get; set; }

        public AccountManager()
        {
            this.Accounts = new List<Account>();
        }

        public decimal TotalBalance()
        {
            decimal total = 0;
            foreach (var account in Accounts)
            {
                if (!account.IsBlocked)
                {
                    total += account.Balance;
                }
            }
            return total;
        }

        public decimal TotalPositiveBalance()
        {
            decimal total = 0;
            foreach (var account in Accounts)
            {
                if (!account.IsBlocked && account.Balance > 0)
                {
                    total += account.Balance;
                }
            }
            return total;
        }

        public decimal TotalNegativeBalance()
        {
            decimal total = 0;
            foreach (var account in Accounts)
            {
                if (account.Balance < 0)
                {
                    if (account.IsBlocked)
                    {
                        Console.WriteLine($"Заблокована карта з негативним балансом: {account.AccountNumber}, Баланс: {account.Balance}");
                    }
                    total += account.Balance;
                }
            }
            return total;
        }

        public void PrintAccountStatus(string accountNumber)
        {
            var account = Accounts.Find(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                string status = account.IsBlocked ? "Заблоковано" : "Активно";
                Console.WriteLine($"Рахунок {account.AccountNumber}: {status}");
            }
            else
            {
                Console.WriteLine("Рахунок не знайдено.");
            }
        }


        public List<Account> SearchAccounts(string keyword)
        {
            return Accounts.Where(account => account.AccountNumber.StartsWith(keyword)).ToList();
        }

        public void SortAccountsByBalance()
        {
            Accounts = Accounts.OrderBy(account => account.Balance).ToList();
        }
    }
}
