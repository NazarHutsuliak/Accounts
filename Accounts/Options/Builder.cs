using Accounts;
using System.Collections.Generic;
using AccountsWithSum;
using AccountsView;
namespace Program.Options
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

            var accountsWithSum = new AccountsModelWithSumBalance();
            var result = accountsWithSum.GetAccountsSumBalances(accounts);

            ViewProvider.CreateView(_options.drawTo).Draw(result);

            return 0;
        }

    }
}
