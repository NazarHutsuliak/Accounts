﻿using System;
using AccountsLibrary;
using CommandLine;
using AccountsLibrary.Options;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<ProgranOptions>(args)
                .MapResult((options) => new Builder(options).Build(), 
                errs => 1);
            Console.ReadKey();
        }
    }
}