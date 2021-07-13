using System.Collections.Generic;

namespace AccountsLibrary
{
    public interface IView
    {
        void Draw(List<AccountsModel> accountsMode);
    }
}
