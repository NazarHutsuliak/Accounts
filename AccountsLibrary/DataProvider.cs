using System;
using System.IO;
using Accounts.Adapters;
namespace Accounts
{
    public class DataProvider
    {
        public static IDataAdapter Create(string pathToFile)
        {
            return Path.GetExtension(pathToFile) switch
            {
                ".json" => new AdapterFromJson(pathToFile),
                ".yaml" => new AdapterFromYaml(pathToFile),
                _ => throw new Exception("Unknown dile format"),
            };
        }
    }
}
