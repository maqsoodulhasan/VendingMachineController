using System;
using Xunit;
using VendingMachineController.Model;

namespace TestVendingMachineController
{
    public class TestDrink
    {

        [Fact]
        public void TestDrinkProductName()
        {
            Drink DR = new Drink("Cola", 50);
            Assert.Equal("Cola", DR.ProductName);


        }
        [Fact]
        public void TestDrinkProductCost()
        {
            Drink DR = new Drink("Cola", 50);

            Assert.Equal(50, DR.ProductCost);

        }

        [Fact]
        public void TestDrinkProductCategory()
        {
            Drink DR = new Drink("Cola", 50);

            Assert.Equal("drink", DR.Category.ToString());

        }

        [Fact]
        public void TestDrinkProductUseMessage()
        {
            Drink DR = new Drink("Cola", 50);

            Assert.Equal("Have a nice drink", DR.UseMessage);

        }





    }
}
