using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using Xunit;
using AccountsWithSum;
using Accounts;

namespace AccountsLibraryTests
{
    public class BalanceSumTest
    {
        [Fact]
        public void test1()
        {

            //Arrange

            var with = new List<AccountsModelWithSumBalance>()
           {
               new AccountsModelWithSumBalance()
               {
                   Name = "Name",
                   Surname = "Surname",
                   Balance = 51,
                   Currency = "Curency",
                   RegistrationCity = "city",
                   Age = 10
               }
           };
            var expected = with.Select(x => x.Balance);

            var list = new List<AccountsModel>()
           {
               new AccountsModel()
               {
                   Name = "Name",
                   Surname = "Surname",
                   Balance = new List<decimal> { 1, 2, 3, 45 },
                   Currency = "Curency",
                   RegistrationCity = "city",
                   Age = 10
               }
           };

            // Act

            var a = new AccountsModelWithSumBalance();
            var a2 = a.GetAccountsWithSumBalances(list);
            var actual = a2.Select(x => x.Balance);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
