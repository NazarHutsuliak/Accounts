using System;
using AccountsLibrary;
namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Please enter file name : ");

            IAccounts accounts = new AccountsFromJson();
            var accountslist = accounts.InitList();

            Console.WriteLine("\nAcounts Table");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine(accounts.DrawHeader()); 

            foreach (var item in accountslist)
            {
                var result = String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                    item.Name, item.Surname, item.Balance, item.Currency, item.RegistrationCity, item.Age);

                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
