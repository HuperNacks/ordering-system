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

        public  int Price { get; set; }

        public int CoockingTime { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        //public static string SetName()
        //{


            
        //}







        //public List<Dish> menu = new List<Dish>();








        //public  List<Ingredient> ingredients = new List<Ingredient>();
        //public int Count => ingredients.Count;
        //private const int MAX_INGREDIENTS = 100;

        //public int Add(Ingredient ingredient)
        //{
        //    if (ingredient == null)
        //    {
        //        throw new ArgumentNullException(nameof(ingredient), "ingredient is null");
        //    }

        //    if (ingredients.Count < MAX_INGREDIENTS)
        //    {
        //        ingredients.Add(ingredient);
        //        return ingredients.Count - 1;
        //    }
        //    return -1;


        //}


        //public override string ToString()
        //{
        //    return Name + " " + Description + " " + Price + " " + CoockingTime;
        //}

        // public List<Dish> DishList;


        // public Dish()
        // {

        // }


        //Мы сделали парковку  на которой могут содержаться определенное количество машин



        // public Dish (string name , string description, int price, int coockingtime)
        // {
        //     Name = name;
        //     Description = description;
        //     Price = price;
        //     CoockingTime = coockingtime;

        // }


        //public Dish (Ingredient ingredient)


        // {

        // }







    }


}
