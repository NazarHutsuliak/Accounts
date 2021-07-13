
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;

namespace AccountsLibrary
{
    public class AdapterFromYaml : IDataAdapter
    {
        private readonly string _content;
        public AdapterFromYaml(string pathToFile)
        {
            _content = File.ReadAllText(pathToFile);
        }

        public List<AccountsModel> GetData()
        {
            var deserializer = new Deserializer();
            return deserializer.Deserialize<List<AccountsModel>>(_content);
        }
    }
}
