using System;
using System.Collections.Generic;

namespace AccountsLibrary
{
    public class ViewProvider
    {
        public static IView CreateView(string drawTo)
        {
            return drawTo switch
            {
                "console" => new ViewToConsole(new List<AccountsModel>()),
                "html" => new ViewToHtml(new List<AccountsModel>()),
                _ => throw new Exception("..."),
            };
        }
    }
}
