using System;
using System.Collections.Generic;

namespace AccountsLibrary
{
    public class ViewProvider
    {
        public static IView CreateView(string DrawTo)
        {
            if (DrawTo == "console")
                return new ViewToConsole(new List<AccountsModel>());
            else throw new Exception("...");
        }
    }
}
