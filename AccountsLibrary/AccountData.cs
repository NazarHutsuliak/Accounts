using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
namespace AccountsLibrary
{
    public interface IAccounts
    {

        public string DrawHeader()
        {
            return String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                "Name", "Surname", "Balance", "Currency", "City", "Age"); ;

        }

    }

    public class AccountData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public string RegistrationCity { get; set; }
        public int Age { get; set; }

        public string getStringFromLinkToFile()
        {
            string fileName = Console.ReadLine();
            return File.ReadAllText(fileName);

        }

        public string DrawLine()
        {
            return String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                Name, Surname, Balance, Currency, RegistrationCity, Age);
        }
    }


    public class AccountsFromJson : AccountData, IAccounts
    {
        public AccountsFromJson()
        {
            var accountsFromJson = JsonSerializer.Deserialize<List<AccountData>>(getStringFromLinkToFile());
            DrawHeader();
            DrawLine();
        }
        public string DrawHeader()
        {
            return String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                "Name", "Surname", "Balance", "Currency", "City", "Age"); ;

        }
        

    }
}
