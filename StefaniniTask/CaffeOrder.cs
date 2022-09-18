using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StefaniniTask
{
    public class CaffeOrder
    {

        private readonly Dish _menu;
        private readonly List<Dish> menu;
        private readonly Cook _cooks;
        private readonly List<Cook> cooks;





        public CaffeOrder()
        {
            _menu = new Dish();
            menu = _menu.MenuList();


            _cooks = new Cook();
            cooks = _cooks.CookList();
            
        }


        public void Start()
        {
            DisplayMenu();

            while (true)
            {
                Console.WriteLine("Do you want to make an order? Y/N");
                var input = Console.ReadLine();
                Console.WriteLine();
                if (input.ToLower() == "y")
                {
                   
                    var order = MakeOrder();

                    string orderStatus = SendOrder(order);
                    if (orderStatus == "error")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Have a nice day");
                    break;
                }

            }
        }





        private void DisplayMenu()
        {

            foreach (var dish in menu)

            {
                Console.WriteLine("Name: {0}\nDescription: {1}", dish.Name, dish.Description);

                float sum = 0;
                string name = "";
                int count = 0;

                foreach (var ingredient in dish.Ingredients)
                {

                    sum += ingredient.Price;
                    if (count < dish.Ingredients.Count - 1)
                    {
                        count++;
                        name += ingredient.Name + ",";
                    }
                    else
                    {
                        name += ingredient.Name + ".";
                    }

                }
                Console.WriteLine("Price: {0:0.00}$\nContents: {1}", sum * 1.2, name);
                Console.WriteLine();


            }
        }


        private Dish MakeOrder()
        {
            Console.WriteLine("Enter the name of dish ");


            while (true)
            {


                var input = Console.ReadLine();
                Console.WriteLine();

                foreach (var dish in menu)
                {
                    if (input.ToLower() == dish.Name.ToLower())
                    {
                        return dish;
                    }

                }

                Console.WriteLine("Name not found try again");
            }

        }

        private string SendOrder(Dish order)
        {
            var lessBusyCook = cooks.OrderBy(cook => cook.Order.Count).First();

            if (lessBusyCook.Order.Count == 5)
            {
                Console.WriteLine("No cooks available");
                return "error";
            }

            lessBusyCook.Order.Add(order);


            var coockingTime = lessBusyCook.Order.Sum(time => order.CoockingTime);
            Console.WriteLine($"Estimated cooking finish time of {lessBusyCook.Name} is {coockingTime} minutes with {lessBusyCook.Order.Count} orders");
            Console.WriteLine();
            return "success";

        }
    }
}
