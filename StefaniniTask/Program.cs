using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StefaniniTask
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Ingredient chocolate = new Ingredient() { Name = "Dark Chocolate", Price = 5 };
            Ingredient milk = new Ingredient() { Name = "Milk", Price = 2 };
            Ingredient eggs = new Ingredient() { Name = "Eggs", Price = 3 };
            Ingredient oil = new Ingredient() { Name = "Vegetable oil ", Price = 1 };
            Ingredient vanilla = new Ingredient() { Name = "Vanilla", Price = 1 };
            Ingredient creamCheese = new Ingredient() { Name = "Cream cheese", Price = 2 };
            Ingredient butter = new Ingredient() { Name = "Butter", Price = 1 };
            Ingredient espresso = new Ingredient() { Name = "Espresso", Price = 2 };
            Ingredient mushrooms = new Ingredient() { Name = "Mushrooms", Price = 3 };
            Ingredient sourCream = new Ingredient() { Name = "Sour Cream", Price = 1.5f };
            Ingredient scallions = new Ingredient() { Name = "Scallions", Price = 2.5f };
            Ingredient sugar = new Ingredient() { Name = "Sugar", Price = 0.3f };




            Dish cheeseCake = new Dish() { Name = "Chocolic's Cheesecake", Description = "Creamy chocolate cheesecake nested in a dark, moist brownie, sprinkled with chocolate flakes.", CoockingTime = 40, Ingredients = new List<Ingredient>() { chocolate, milk, eggs, butter, creamCheese } };
            Dish pancakes = new Dish { Name = "Princess pancakes", Description = "Pancakes fit for a princess! These pancakes are perfectly pink and stuffed with sprinkles and topped with cream cheese icing.", CoockingTime = 25, Ingredients = new List<Ingredient>() { butter, creamCheese, vanilla, milk, oil, sugar } };
            Dish latte = new Dish { Name = "Latte", Description = "A double shot of espresso with steamed milk and a small layer of foam.", CoockingTime = 5, Ingredients = new List<Ingredient>() { espresso, espresso, milk } };
            Dish creamSoup = new Dish { Name = "Wild Mushroom Cream Soup", Description = "A variety of hand-picked mushrooms, coocked to perfection, mixed in with velvety cream and served with freshly chopped scallions.", CoockingTime = 30, Ingredients = new List<Ingredient>() { mushrooms, sourCream, scallions } };
            Dish hotChocolate = new Dish { Name = "Hot Chocolate", Description = "Rich chocolate with steamed milk and a small layer of foam.", CoockingTime = 7, Ingredients = new List<Ingredient>() { chocolate, sugar, milk, vanilla } };


            var menu = new List<Dish>() { cheeseCake, pancakes, latte, creamSoup, hotChocolate };


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
                Console.WriteLine("Price: {0:0.00}\nContents: {1}", sum * 1.2, name);
                Console.WriteLine();

              
            }



            Cook firstCook = new Cook() { Name = "Gordon", Order = new List<Dish>() };
            Cook secondCook = new Cook() { Name = "Michael", Order = new List<Dish>() };
            Cook thirdCock = new Cook() { Name = "Jamie", Order = new List<Dish>() };
            Cook forthCock = new Cook() { Name = "Bobby", Order = new List<Dish>() };
            Cook fifthCock = new Cook() { Name = "Giada", Order = new List<Dish>() };
            var cooks = new List<Cook>() { firstCook, secondCook, thirdCock, forthCock, fifthCock };


            Console.WriteLine("Enter how many order do you want to have");

            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                if (cooks[0].Order.Count == cooks[1].Order.Count && cooks[2].Order.Count == cooks[3].Order.Count && cooks[0].Order.Count == cooks[4].Order.Count && cooks[4].Order.Count == 5)
                {
                    Console.WriteLine("No cooks available");
                    break;
                }
                AddOrder(menu, cooks);

            }
                foreach (var cook in cooks)
                {
                    

                    int coockingTime = 0;
                    foreach (var order in cook.Order)
                    {
                        coockingTime += order.CoockingTime;
                      
                    }
                   Console.WriteLine($"Estimated cooking finish time of {cook.Name} is {coockingTime} minutes with {cook.Order.Count} orders");
                }
            

            Console.WriteLine("End of ordering");

          



            







        }

        public static void AddOrder(List<Dish> menu, List<Cook> cooks)
        {

            Console.WriteLine("Enter the name of dish ( At this moment we are assuming that name is correct)");

            string input = Console.ReadLine();
            

            foreach (var dish in menu)
            {
                if (input == dish.Name)
                {
                    
                    for (int i = 0; i < cooks.Count; i++)
                    {
                        if (cooks[0].Order.Count == 0)
                        {
                            cooks[i].Order.Add(dish);
                            Console.WriteLine($"Order assigned to {cooks[i].Name}");
                            Console.WriteLine();
                          
                            return;
                        }
                        if (cooks[i].Order.Count == 5 )
                        {
                            Console.WriteLine($"Can't  be assigned more than 5 dishes to: {cooks[i].Name} ");
                            Console.WriteLine();
                            continue;
                        }
                        for (int j = 0; j < cooks.Count; j++)
                        {
                            if (cooks[i].Order.Count < cooks[j].Order.Count )
                            {
                                cooks[i].Order.Add(dish);
                                Console.WriteLine($"Order assigned to {cooks[i].Name}");
                                Console.WriteLine();
                              
                                return;
                            }
                            else if (cooks[0].Order.Count == cooks[1].Order.Count & cooks[2].Order.Count==cooks[3].Order.Count & cooks[0].Order.Count == cooks[4].Order.Count)
                            {
                                cooks[i].Order.Add(dish);
                                Console.WriteLine($"Order assigned to {cooks[i].Name}");
                                Console.WriteLine();
                                return;
                            }
                            
                        }

                    }

                   

                }
            }


        }
    }
}
