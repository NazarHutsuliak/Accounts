
using System.Collections.Generic;

namespace AccountsLibrary.Options
{
    public class Builder 
    {
        ProgranOptions _options;

        public Builder(ProgranOptions options)
        {
            _options = options;
        }

        public int Build()
        {
            IDataAdapter dataProvider = DataProvider.Create(_options.PathToFile);
            List<AccountsModel> accounts = dataProvider.GetData();

            IView view = ViewProvider.CreateView(_options.DrawTo);
            view.Draw(accounts);

            return 0;
        }

    }
}
