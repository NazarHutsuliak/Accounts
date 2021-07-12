using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace AccountsLibrary
{
    public class AdaperFromJson : IDataAdapter
    {
        private readonly string _content;
        public AdaperFromJson(string PathToFile)
        {
            _content = File.ReadAllText(PathToFile);
        }

        public List<AccountsModel> GetData()
        {
            return JsonSerializer.Deserialize<List<AccountsModel>>(_content);
        }
    }
}
