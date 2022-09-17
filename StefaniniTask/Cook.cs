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


        public List<Cook> Cooks { get; set; }
    }
   
}
