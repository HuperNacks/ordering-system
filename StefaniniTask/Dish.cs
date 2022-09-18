using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniniTask
{
    public class Dish 
    {
        public  string  Name { get; set; }
       
        public string Description { get; set; }

        private  int Price { get; set; }

        public int CoockingTime { get; set; }

        public List<Ingredient> Ingredients { get; set; }




        public List<Dish> MenuList()
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




            Dish cheeseCake = new Dish() { Name = "Chocolics Cheesecake", Description = "Creamy chocolate cheesecake nested in a dark, moist brownie, sprinkled with chocolate flakes.", CoockingTime = 40, Ingredients = new List<Ingredient>() { chocolate, milk, eggs, butter, creamCheese } };
            Dish pancakes = new Dish { Name = "Princess pancakes", Description = "Pancakes fit for a princess! These pancakes are perfectly pink and stuffed with sprinkles and topped with cream cheese icing.", CoockingTime = 25, Ingredients = new List<Ingredient>() { butter, creamCheese, vanilla, milk, oil, sugar } };
            Dish latte = new Dish { Name = "Latte", Description = "A double shot of espresso with steamed milk and a small layer of foam.", CoockingTime = 5, Ingredients = new List<Ingredient>() { espresso, espresso, milk } };
            Dish creamSoup = new Dish { Name = "Cream Soup", Description = "A variety of hand-picked mushrooms, coocked to perfection, mixed in with velvety cream and served with freshly chopped scallions.", CoockingTime = 30, Ingredients = new List<Ingredient>() { mushrooms, sourCream, scallions } };
            Dish hotChocolate = new Dish { Name = "Hot Chocolate", Description = "Rich chocolate with steamed milk and a small layer of foam.", CoockingTime = 7, Ingredients = new List<Ingredient>() { chocolate, sugar, milk, vanilla } };

            var menu = new List<Dish>() { cheeseCake, pancakes, latte, creamSoup, hotChocolate };
            return menu;
        }

    }


}
