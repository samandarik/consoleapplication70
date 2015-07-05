using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication70
{
    class Program
    {
       static ShoppingCart cart = new ShoppingCart();

        static void Main(string[] args)
        {
            Start();

            Console.ReadLine();
        }

        static void Start()
        {
            try
            {
                cart.Command();
            }

            catch (Exception e)
            {
                Console.WriteLine("ERROR:" + e.Message, e.Source);
            }


        }
    }
}
