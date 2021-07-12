using System;
using System.IO;
using AccountsLibrary;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Please enter file name : ");

            string fileName = Console.ReadLine();
            string file = File.ReadAllText(fileName);

            var adapters = new AdaperFromJson(file);
            new ViewToConsole(adapters.accountsModel);

            Console.ReadKey();
        }
    }
}
