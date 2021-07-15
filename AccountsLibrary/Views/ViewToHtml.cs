using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace AccountsLibrary
{
   public class ViewToHtml : IView
    {
          public void Draw (List<AccountsModel> accountsModel)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<table>");

            stringBuilder.Append("<tr><th>Name</th><th>Surname</th><th>Balance</th><th>Currency</th><th>City</th><th>Age</th></tr>");
            var rows = from r in accountsModel
                       let row = "<tr><td>" + r.Name + "</td><td>" + r.Surname + "</td><td>" + r.Balance +
                       "</td><td>" + r.Currency + "</td><td>" + r.RegistrationCity + "</td><td>" + r.Age + "</td></tr>"
                       select row;

            rows.ToList().ForEach(rows => stringBuilder.Append("<tr>" + rows + "</tr"));

            stringBuilder.Append("</table>");

            System.IO.File.WriteAllText(@"d:\bank.html", stringBuilder.ToString());
        }
    }
}
