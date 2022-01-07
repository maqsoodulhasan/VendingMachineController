using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineController.Model
{
    public class VendingMachine : IVending
        
    {
        public static List<Product> Prod = new List<Product>();
        readonly int[] MoneyPoolArray = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public static int _MoneyPool = 0;
        public static int TotalCost = 0;

        public bool InsertMoney(int money)
        {
                      
            if(MoneyPoolArray.Contains(money))
                {
                    _MoneyPool += money;
                    return true;
                }
                else
                {
                return false;
                }
               
        }

        public void ShowAll()
        {
            Console.WriteLine("Here is your purchased items list: ");
            foreach (var item in Prod)
            {
                Console.WriteLine(item.ProductName + " " + item.ProductCost + " SEK" + " Info: "+ item.UseMessage);
                TotalCost += item.ProductCost;
            }
            
            Console.WriteLine(" your total cost is:  {0} ", TotalCost);
            
        }
        public void Purchase(int SelectedProduct)
        {
           
                if (SelectedProduct > 0 && SelectedProduct < 5)
                {
                    Prod.Add(new Food(Product.ProductCollection.ElementAt(SelectedProduct - 1).Key, Product.ProductCollection.ElementAt(SelectedProduct - 1).Value));
                }
                else if (SelectedProduct > 4 && SelectedProduct < 9)
                {
                    Prod.Add(new Drink(Product.ProductCollection.ElementAt(SelectedProduct - 1).Key, Product.ProductCollection.ElementAt(SelectedProduct - 1).Value));
                }
                else if (SelectedProduct > 8 && SelectedProduct < 12)
                {
                    Prod.Add(new Toy(Product.ProductCollection.ElementAt(SelectedProduct - 1).Key, Product.ProductCollection.ElementAt(SelectedProduct - 1).Value));
                }
                      
        }
        public void EndTransaction()
        {

            Console.WriteLine("You inserted {0} SEK and made purchase of {1} SEK Here is your remaining money {2} SEK",_MoneyPool,TotalCost,_MoneyPool-TotalCost);
            Console.WriteLine(" EndTransaction from Vending machine");

        }
        public static void DisplayMenu()
        {
            for (int i = 0; i < Product.ProductCollection.Count - 1; i++)
            {
                Console.WriteLine("{0}:----" + Product.ProductCollection.ElementAt(i).Key + " " + Product.ProductCollection.ElementAt(i).Value + " SEK   ", i + 1);

            }
        }
        public static bool AvailableBalance(List<Product> Prod, int ProductSelection)
        {
            int TotalCostNow = 0;
            foreach (var item in Prod)
            {
                Console.WriteLine(item.ProductName + " " + item.ProductCost + " SEK");
                TotalCostNow += item.ProductCost;
            }
            if(_MoneyPool < (TotalCostNow + Product.ProductCollection.ElementAt(ProductSelection - 1).Value))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static void ResetAll()
        {
            Prod = new List<Product>();
            _MoneyPool = 0;
            TotalCost = 0;
        }

    }
}
