using System.Collections.Generic;
using AccountsWithSum;
namespace AccountsView
{
    public interface IView
    {
        void Draw(IEnumerable<AccountsModelWithSumBalance> accountsModel);
    }
}
