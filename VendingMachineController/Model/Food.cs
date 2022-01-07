using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineController.Model
{
    public class Food : Product
    {
        public override string ProductName { get; }
        public override int ProductCost { get ; }
        public override PCategory Category { get ; }
        public override string UseMessage { get; }


        public Food(string PName, int PCost)
        {
            this.ProductName = PName;
            this.ProductCost = PCost;
            this.Category = PCategory.food;
            this.UseMessage = "Have a nice food";
        }


        public override void Examine()
        {
            base.Examine();
            //nsole.WriteLine("examine from food class");
        }

        public override void UseProduct()
        {
            Console.WriteLine("examine from food class");
        }
    }
}
