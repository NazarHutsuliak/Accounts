using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace AccountsLibrary
{
    public class AdapterFromJson : IDataAdapter
    {
        private readonly string _content;
        public AdapterFromJson(string pathToFile)
        {
            _content = File.ReadAllText(pathToFile);
        }

        public List<AccountsModel> GetData()
        {
            return JsonSerializer.Deserialize<List<AccountsModel>>(_content);
        }
    }
}
