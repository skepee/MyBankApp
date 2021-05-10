using Microsoft.EntityFrameworkCore;
using MyBankApp.Api.Context;
using System;
using System.Linq;
using Xunit;

namespace UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void Test_GetBalance()
        {
            string dbName = Guid.NewGuid().ToString();
            DbContextOptions<MyBankAppContext> options = new DbContextOptionsBuilder<MyBankAppContext>().UseInMemoryDatabase(databaseName: dbName).Options;

            using var context = new MyBankAppContext(options);
            context.Populate();
            var items = context.Transaction.ToList();

            Assert.Single(items);
            Assert.Equal(100, items.Sum(x=>x.Quantity));
        }

    }
}
