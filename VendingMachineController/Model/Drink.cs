using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineController.Model
{
   public class Drink:Product
    {
        public override string ProductName { get; }
        public override int ProductCost { get; }
        public override PCategory Category { get; }

        public override string UseMessage { get; }

        public Drink(string PName, int PCost)
        {
            this.ProductName = PName;
            this.ProductCost = PCost;
            this.Category = PCategory.drink;
            this.UseMessage = "Have a nice drink";
        }


        public override void Examine()
        {
            Console.WriteLine("examine from drink class");
        }

        public override void UseProduct()
        {
            Console.WriteLine("examine from drink class");
        }
    }
}
