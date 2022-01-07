using System;
using Xunit;
using VendingMachineController.Model;

namespace TestVendingMachineController
{
    public class TestFood
    {
        
        [Fact]
        public void TestFoodProductName()
        {
            Food FD = new Food("kex", 50);           
            Assert.Equal("kex", FD.ProductName);
            
            
        }
        [Fact]
        public void TestFoodProductCost()
        {
            Food FD = new Food("kex", 50);
            
            Assert.Equal(50, FD.ProductCost);

        }

        [Fact]
        public void TestFoodProductCategory()
        {
            Food FD = new Food("kex", 50);

            Assert.Equal("food", FD.Category.ToString());

        }

        [Fact]
        public void TestFoodProductUseMessage()
        {
            Food FD = new Food("kex", 50);

            Assert.Equal("Have a nice food", FD.UseMessage);

        }





    }
}
