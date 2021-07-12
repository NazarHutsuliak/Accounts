using System.Collections.Generic;
namespace AccountsLibrary
{
    public interface IDataAdapter
    {
        List<AccountsModel> GetData();

    }
}
