using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace AccountsLibrary
{
    public class AccountsFromJson:IAccounts
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

        public List<AccountsFromJson> InitList()
        {
            return JsonSerializer.Deserialize<List<AccountsFromJson>>(getStringFromLinkToFile());
        }

        public string DrawHeader()
        {
            return String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                    "Name", "Surname", "Balance", "Currency", "City", "Age");
        }

    }
}
