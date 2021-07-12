using System.Collections.Generic;
using System.Text.Json;

namespace AccountsLibrary
{
    public class AdaperFromJson : IAdapters
    {
        public List<AccountsModel> accountsModel = new List<AccountsModel>();

        public AdaperFromJson(string file)
        {
            accountsModel = JsonSerializer.Deserialize<List<AccountsModel>>(file);
        }

    }
}
