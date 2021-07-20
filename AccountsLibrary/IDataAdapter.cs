using System.Collections.Generic;
using Accounts;
namespace Accounts
{
    public interface IDataAdapter
    {
        List<AccountsModel> GetData();
    }
}
