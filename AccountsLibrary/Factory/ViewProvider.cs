using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsLibrary
{
    public class ViewProvider
    {
        public static IView CreateView(string DrawTo)
        {
            var view = DrawTo;
            if (view == "console")
                return new ViewToConsole(new List<AccountsModel>());
            else throw new Exception("...");
        }
    }
}
