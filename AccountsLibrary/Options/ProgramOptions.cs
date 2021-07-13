
using CommandLine;

namespace AccountsLibrary
{
    public class ProgranOptions
    {
        [Option('p', "path", Required = true, HelpText = "Path to file ")]
        public string PathToFile { get; set; } = string.Empty;

        [Option('d', "draw", Required = true, HelpText = "Draw file to")]
        public string DrawTo { get; set; } = string.Empty;
    }        

}
