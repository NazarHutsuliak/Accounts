
namespace AccountsLibrary.Options
{
    public class Builder 
    {
        private readonly ProgranOptions _options;

        public Builder(ProgranOptions options)
        {
            _options = options;
        }

        public int Build()
        {
            var dataProvider = DataProvider.Create(_options.pathToFile);
            var accounts = dataProvider.GetData();

            ViewProvider.CreateView(_options.drawTo).Draw(accounts);

            return 0;
        }

    }
}
