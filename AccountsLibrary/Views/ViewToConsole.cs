using System;
using System.Collections.Generic;
namespace AccountsLibrary
{
   public class ViewToConsole : IViews
    {
  
        public ViewToConsole(List<AccountsModel> accountsModel)
        {
  
            DrawHeader();
            DrawTable(accountsModel);
        }

        public string DrawHeader()
        {
            return String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                    "Name", "Surname", "Balance", "Currency", "City", "Age");
        }

        public void DrawTable(List<AccountsModel> accountsModel)
        {
            Console.WriteLine("\nAcounts Table");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            foreach (var item in accountsModel)
            {
                var result = String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                    item.Name, item.Surname, item.Balance, item.Currency, item.RegistrationCity, item.Age);

                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine(result);
            }
        }
    }
}
