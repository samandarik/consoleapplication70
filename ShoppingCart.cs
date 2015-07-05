using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace ConsoleApplication70
{
    class ShoppingCart
    {
        public string commandHelp;
        Item items = new Item();


        public void Command()
        {
            Console.Clear();
            Console.WriteLine("-------Menu ShoppingCart---------");
            Console.WriteLine("1 : Add item in shopping cart");
            Console.WriteLine("2 : View shopping cart");
            Console.WriteLine("3 : Save your shopping cart");
            Console.WriteLine("4 : Load your shopping cart");
            Console.WriteLine("5 : Exit program");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    addItem();
                break;
                
                case "2":
                CartView();
                break;

                case "3":
                SaveResult();
                break;

                case "4":
                LoadProduct();
                break;

                case "5":
                Exit();
                break;

                default:
                Console.WriteLine("Invalid");
                break;
            }

        }




        public void SaveResult()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            items.products.Add(new Product(1, "Iphone 4s", 1000.0, "Good phone"));
            items.products.Add(new Product(2, "Gloop Galloop Soup", 25.0, "Tasty"));
            items.products.Add(new Product(3, "Hot Coffee", 12.0, "Exspresso"));
            Console.WriteLine("Products to save:");
            foreach (Product product in items.products)
            {
                Console.WriteLine(product);
            }

            IFormatter serializer = new BinaryFormatter();
            FileStream saveFile = new FileStream("Products.bin", FileMode.Create, FileAccess.Write);
            serializer.Serialize(saveFile, items.products);
            saveFile.Close();

            Console.WriteLine("------------------------");
            Console.WriteLine("1 : Exit program");
            Console.WriteLine("2 : Open menu");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Environment.Exit(0);
            }
            if (input == 2)
            {
                Command();
            }
            else
            {
                Console.WriteLine();
            }
  
        }



        public void LoadProduct()
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            IFormatter serializer = new BinaryFormatter();

            FileStream loadFile = new FileStream("Products.bin", FileMode.Open, FileAccess.Read);
            List<Product> savedProducts = serializer.Deserialize(loadFile) as List<Product>;
            loadFile.Close();

            Console.WriteLine("Products loaded:");
            foreach (Product product in savedProducts)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("1 : Exit program");
            Console.WriteLine("2 : Open menu");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Environment.Exit(0);
            }
            if (input == 2)
            {
                Command();
            }
            else
            {
                Console.WriteLine();
            }
        }






        public void CartView()
        {
           
            //items.Cart();
            addItem();
            IFormatter serializer = new BinaryFormatter();
            FileStream saveFile = new FileStream("Item.bin", FileMode.Create, FileAccess.Write);
            serializer.Serialize(saveFile, items.item);
            saveFile.Close();

            Console.WriteLine("Products loaded:");
            items.item.Insert(0, "lol");
           // int index0 = items.item.IndexOf("lol", 0);
            items.item.Add("test");
            for (int i = 0; i < items.item.Count; i++ )
            {
                Console.WriteLine(items.item[i]);
            }

           

            //Console.WriteLine(items.item.IndexOf("lol", 0));
            
            //int index0 = items.item.IndexOf(0);
            //items.Calculator();
              
        }




        public void addItem()
        {
            
           
            //items.Price = Convert.ToInt32(Console.ReadLine());
            items.Name = "Coffee";
            items.Price = 50.05m;
            items.Quantity = 2;
            items.Total = items.Price * items.Quantity;
            items.item.Add(items.Name);
            items.item.Add(items.Price);
            items.item.Add(items.Quantity);
            items.item.Add(items.Total);
           // int index0 = items.item.IndexOf();
            /*
            Console.WriteLine(items.item[0]);
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                CartView();
            }
            */

        }


       public void Exit()
        {
            Environment.Exit(0);
        }




    }
}
