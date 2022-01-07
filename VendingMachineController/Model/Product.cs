using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineController.Model
{
    public abstract class Product
    {
        public abstract string ProductName { get; }
        public abstract int ProductCost { get; }
        public abstract PCategory Category { get; }
        public abstract string UseMessage { get; }

        public static Dictionary<string, int> ProductCollection = new Dictionary<string, int>()
         {
             { "KEX", 20 }, { "marabou", 25 },{ "Mjolkchoklad", 30 },{"almondchoklad", 25}, 
             { "Sprite", 25 },{ "Pepsi", 30 },{ "Fanta", 35 },{"redbull .5L", 14}, 
             {"video Game", 150},{"cards",70},{"puzzle", 50},{"toy car", 200}
         };

        public virtual void Examine()
        {
            //show the product’s price and info
            Console.WriteLine("examine from product class");
        }

        public virtual void UseProduct()
        {
            //showing a message about how it is used (drink the drink, eat the snack, play with toy, etc.…)
            Console.WriteLine("examine from product class");
        }
    }
}
