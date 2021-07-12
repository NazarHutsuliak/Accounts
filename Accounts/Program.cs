using System;
using System.IO;
using AccountsLibrary;
using System.Collections.Generic;
using CommandLine;
using AccountsLibrary.Options;
namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<ProgranOptions>(args).WithParsed<ProgranOptions>(p => { });


            Console.ReadKey();
        }
    }
}