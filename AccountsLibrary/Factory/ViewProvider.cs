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
                "console" => new ViewToConsole(),
                "html" => new ViewToHtml(),
                _ => throw new Exception("..."),
            };
        }
    }
}
