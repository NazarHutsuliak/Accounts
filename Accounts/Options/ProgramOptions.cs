
using CommandLine;

namespace AccountsLibrary
{
    public class ProgranOptions
    {
        [Option('p', "path", Required = true, HelpText = "Write a path to file for parse ")]
        public string PathToFile { get; set; } = string.Empty;

        [Option('d', "draw", Required = true, HelpText = "Choose your file will parse to")]
        public string DrawTo { get; set; } = string.Empty;
    }        

}
