using System;
using System.Collections.Generic;
using AccountsWithSum;
namespace AccountsView.Views
{
   public class ViewToConsole : IView
    {
  
        public ViewToConsole()
        {
            DrawHeader();  
        }

        private void DrawHeader()
        {
            Console.WriteLine("\nAcounts Table\n");
            Console.WriteLine(String.Format("| {0,12} | {1,15} | {2,8} | {3,8} | {4,20} | {5,3} |",
                    "Name", "Surname", "Balance", "Currency", "City", "Age"));
        }

        public void Draw (IEnumerable<AccountsModelWithSumBalance> accountsModel)
        {
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
