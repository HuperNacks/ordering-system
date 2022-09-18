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


            CaffeOrder cafeOrder = new CaffeOrder();
            cafeOrder.Start();

        }
    }
}

