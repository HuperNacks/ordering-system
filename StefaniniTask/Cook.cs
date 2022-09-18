using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefaniniTask
{
    public class Cook
    {
        public string Name { get; set; }

        public List<Dish> Order { get; set; }

        public List<Cook> CookList()
        {
            Cook firstCook = new Cook() { Name = "Gordon", Order = new List<Dish>() };
            Cook secondCook = new Cook() { Name = "Michael", Order = new List<Dish>() };
            Cook thirdCook = new Cook() { Name = "Jamie", Order = new List<Dish>() };
            Cook fourthCook = new Cook() { Name = "Bobby", Order = new List<Dish>() };
            Cook fifthCook = new Cook() { Name = "Giada", Order = new List<Dish>() };
            var cooks = new List<Cook>() { firstCook, secondCook, thirdCook, fourthCook, fifthCook };

            return cooks;
        }
    }
   
}
