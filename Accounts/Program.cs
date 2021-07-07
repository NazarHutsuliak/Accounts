using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using AccountsLibrary;
namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {

            var accountsData = new AccountData();
            accountsData.getStringFromLinkToFile();


            





            foreach (var item in accountsData)
            {
                var str = String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                    item.Name, item.Surname, item.Balance, item.Currency, item.RegistrationCity, item.Age);

                Console.WriteLine("-------------------------------------------------------------------------------------");

                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
