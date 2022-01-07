using System;
using Xunit;
using VendingMachineController.Model;

namespace TestVendingMachineController
{
    public class TestToy
    {

        [Fact]
        public void TestToyProductName()
        {
            Toy TY = new Toy("cards", 50);
            Assert.Equal("cards", TY.ProductName);


        }
        [Fact]
        public void TestToyProductCost()
        {
            Toy TY = new Toy("cards", 50);

            Assert.Equal(50, TY.ProductCost);

        }

        [Fact]
        public void TestToyProductCategory()
        {
            Toy TY = new Toy("cards", 50);

            Assert.Equal("toy", TY.Category.ToString());

        }

        [Fact]
        public void TestToyProductUseMessage()
        {
            Toy TY = new Toy("cards", 50);

            Assert.Equal("Have a nice play time", TY.UseMessage);

        }





    }
}
