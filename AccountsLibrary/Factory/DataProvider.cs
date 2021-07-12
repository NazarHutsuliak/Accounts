using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AccountsLibrary
{
    public class DataProvider
    {
        public static IDataAdapter Create(string PathToFile)
        {
            var extension = Path.GetExtension(PathToFile);
            if (extension == ".json")
                return new AdaperFromJson(PathToFile);
            else throw new Exception("...");
        }
    }
}
