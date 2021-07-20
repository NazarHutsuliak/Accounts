using System;
using Program.Options;
using CommandLine;


namespace Program
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