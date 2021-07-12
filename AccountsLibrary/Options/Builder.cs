using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsLibrary.Options
{
    public class Builder : ProgranOptions
    {
        public List<AccountsModel> Input()
        {
            IDataAdapter dataProvider = DataProvider.Create(PathToFile);
            return dataProvider.GetData();
        }


        public void Output()
        {
            IView view = ViewProvider.CreateView(DrawTo);
            view.Draw(Input());
        }

    }
}
