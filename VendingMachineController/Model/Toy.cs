using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineController.Model
{
   public class Toy:Product
    {
        public override string ProductName { get; }
        public override int ProductCost { get; }
        public override PCategory Category { get; }
        public override string UseMessage { get; }

        public Toy(string PName, int PCost)
        {
            this.ProductName = PName;
            this.ProductCost = PCost;
            this.Category = PCategory.toy;
            this.UseMessage = "Have a nice play time";

        }


        public override void Examine()
        {
            Console.WriteLine("examine from toy class");
        }

        public override void UseProduct()
        {
            Console.WriteLine("examine from toy class");
        }
    }
}
