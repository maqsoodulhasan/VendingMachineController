using System;
using Xunit;
using VendingMachineController.Model;

namespace TestVendingMachineController
{
    public class TestVendingMachine
    {
        VendingMachine VM = new VendingMachine();
        [Theory]
        [InlineData(0,0 )]
        [InlineData(1,1)]
        [InlineData(5,5)]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(50, 50)]
        [InlineData(100, 100)]
        [InlineData(500,500 )]
        [InlineData(1000, 1000)]
      
        public void TesInsertMoneyt(int Expected, int money)
        {
            VendingMachine.ResetAll();
            VM.InsertMoney(money);
            Assert.Equal(Expected, VendingMachine._MoneyPool);
            VendingMachine.ResetAll();
        }
              
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(500)]
        [InlineData(1000)]
        public void TesInsertMoneytReturn_True(int money)
        {
            VendingMachine.ResetAll();
            
            Assert.True(VM.InsertMoney(money));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(55)]
        [InlineData(105)]
        [InlineData(205)]
        [InlineData(550)]
        [InlineData(52)]
        [InlineData(900)]
        [InlineData(10000)]
        public void TesInsertMoneytReturn_False(int money)
        {
            VendingMachine.ResetAll();

            Assert.False(VM.InsertMoney(money));
        }



    }
}
