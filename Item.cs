using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication70
{
    class Item 
    {
        public string Name;
        public decimal Price;
        public decimal Quantity;
        public decimal Total;
        public ArrayList item = new ArrayList();
        //public SortedList test = new SortedList();
        public List<string> box = new List<string>();
        public List<Product> products = new List<Product>();
     

        public Item()
        {
            
        }


        public void Cart()
        {
           // item.RemoveAt(0);
        

           // Console.WriteLine(item[0]);
           // Console.WriteLine(index0);
            
           
        }



        public void Run()
        {
            //item.Add("name:");
            item.Insert(0, "lol");
            Console.WriteLine(item[0]);
        }




        public void Calculator()
        {

            int index0 = item.IndexOf(0);
            int index1 = item.IndexOf(1);
            int index2 = item.IndexOf(2);
            int indexTotal = item.IndexOf(3);

            //indexTotal = index1 * index2;

            //Console.WriteLine(index0);

        }


    }
}
