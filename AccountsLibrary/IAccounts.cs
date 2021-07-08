using System.Collections.Generic;
namespace AccountsLibrary
{
    public interface IAccounts
    {
        string Name { get; set; }
        string Surname { get; set; }
        decimal Balance { get; set; }
        string Currency { get; set; }
        string RegistrationCity { get; set; }
        int Age { get; set; }

        string getStringFromLinkToFile();

        List<AccountsFromJson> InitList();

        string DrawHeader();
    }
}
