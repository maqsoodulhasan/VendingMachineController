using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachineController.Model;

namespace VendingMachineController
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Lexicon Food Service");
            
            Console.WriteLine("Valid Money inputs are { 1, 5, 10, 20, 50, 100, 500, 1000 }");
            Console.Write("Please select the money to enter in Machine: ");
            VendingMachine VM = new VendingMachine();
            bool AddBalance = true;
            while (AddBalance)
            {
                try
                {
                    int MoneyInput = int.Parse(Console.ReadLine());
                   
                    if(VM.InsertMoney(MoneyInput))
                    {
                        Console.WriteLine("Money inserted successfully your balance is: {0} ", VendingMachine._MoneyPool);
                        Console.WriteLine("Please select the product from menu: ");
                        AddBalance = false;
                        Console.WriteLine();
                        MoneyInput = 0;
                    }
                    else 
                    {
                        Console.Write("Invalid money value inserted. Please select the valid amount: ");
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }
            
            VendingMachine.DisplayMenu();
            Console.WriteLine("\n");
            bool RightProduct = false;
            int ProductSelection;
            bool continueShopping = true;
            while (continueShopping)
            {
                while (!RightProduct)
                {
                    try
                    {
                        Console.Write("select the product ID from given range (1-11): ");
                        ProductSelection = int.Parse(Console.ReadLine());

                        Console.Write(Product.ProductCollection.ElementAt(ProductSelection - 1).Key + " " + Product.ProductCollection.ElementAt(ProductSelection - 1).Value);
                        Console.WriteLine();
                        if (ProductSelection > 0 && ProductSelection < 12)
                        {
                            RightProduct = true;
                            if(VendingMachine.AvailableBalance(VendingMachine.Prod, ProductSelection))
                            {
                                VM.Purchase(ProductSelection);
                                ProductSelection = 0;
                            }
                            else
                            {
                                Console.WriteLine("Not enough money available for more products: ");
                                VM.ShowAll();
                                VM.EndTransaction();
                                VendingMachine.ResetAll();

                            }

                        }
                        else
                        {
                            Console.Write("select the product ID from given range (1-11):");

                        }
                        
                        Console.Write("Select 1 to add more products to Cart or 2 to make purchase:");
                        int moreProduct = int.Parse(Console.ReadLine());
                        if (moreProduct == 1)
                        {
                            RightProduct = false;
                            continueShopping = true;
                        }
                        else if (moreProduct == 2)
                        {
                            continueShopping = false;
                            VM.ShowAll();
                            VM.EndTransaction();
                            VendingMachine.ResetAll();
                        }
                        else
                        {
                            Console.WriteLine("Wrong value selected");
                        }

                    }
                    catch (Exception e)
                    {
                        RightProduct = false;
                        continueShopping = true;
                        Console.WriteLine(e.Message);
                    }
                    
                }
            }          
          
            Console.ReadLine();
        }
    }
}
