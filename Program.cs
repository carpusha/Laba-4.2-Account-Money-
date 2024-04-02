using ConsoleApp28;

SavingsAccount savingsAccount1 = new SavingsAccount("001", 1000, false, 5.00m);
CheckingAccount checkingAccount1 = new CheckingAccount("002", -500, true, 200);

AccountManager manager = new AccountManager();
manager.Accounts = new List<Account> { savingsAccount1, checkingAccount1 };

manager.PrintAccountStatus("001"); 
 manager.PrintAccountStatus("002"); 
Console.WriteLine("Загальний баланс: " + manager.TotalBalance());
     
Console.WriteLine("Загальний позитивний баланс: " + manager.TotalPositiveBalance());     
 Console.WriteLine("Загальний негативний баланс: " + manager.TotalNegativeBalance());
 List<Account> foundAccounts = manager.SearchAccounts("00");
foreach (var account in foundAccounts)
{
Console.WriteLine("Знайдено рахунок: " + account.AccountNumber);
}

manager.SortAccountsByBalance();
Console.WriteLine("Рахунки після сортування:");
foreach (var account in manager.Accounts)
{
    Console.WriteLine("Рахунок " + account.AccountNumber + " з балансом " + account.Balance);
}

