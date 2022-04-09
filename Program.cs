using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumbers();
            PrintNames();
            PrintTrueorFalse();
            IceCream();
        }

        // Three Basic Arrays
        //This will print integers 0-9
        public static void PrintNumbers()
        {
            int[] arryOfInts = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
                Console.WriteLine(0);
                Console.WriteLine(1);
                Console.WriteLine(2);
                Console.WriteLine(3);
                Console.WriteLine(4);
                Console.WriteLine(5);
                Console.WriteLine(6);
                Console.WriteLine(7);
                Console.WriteLine(8);
                Console.WriteLine(9);
        }

        //This will print the following names
        public static void PrintNames()
        {
            string[] arrayOfNames = new string[] { "Tim", "Martin", "Nikki", "Sara"};
            foreach (string names in arrayOfNames)

                Console.WriteLine($"These are the names {names}");
        }

                //This will print an array of length 10 that alternates between true and false values, starting with true
        public static void PrintTrueorFalse()
        {
            bool[] arr = new bool[10];
            arr[0] = true;
            arr[1] = false;
            arr[2] = true;
            arr[3] = false;
            arr[4] = true;
            arr[5] = false;
            arr[6] = true;
            arr[7] = false;
            arr[8] = true;
            arr[9] = false;

            foreach (bool result in arr) 
                Console.WriteLine(result);
        }
            //List of Flavors
            //This will print a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            //Output the length of this list after building it
            //Output the third flavor in the list, then remove this value
            //Output the new length of the list (It should just be one fewer!)
        public static void IceCream()
        {
        List<string> ice_cream = new List<string>();
        ice_cream.Add("vanilla");
        ice_cream.Add("chocolate");
        ice_cream.Add("rocky road");
        ice_cream.Add("strawberry");
        ice_cream.Add("cookies and cream");
        ice_cream.Add("dole whip");

                Console.WriteLine("We currently have these flavors avaiable:");
                foreach (string flavors in ice_cream)
                {
                    Console.WriteLine(flavors);
                    Console.WriteLine(ice_cream.Count);
                }
                {
                ice_cream.Remove("strawberry");
                foreach (string flavors in ice_cream)
                    Console.WriteLine(flavors);
                    Console.WriteLine(ice_cream.Count);
                }

        }
            //User Info Dictionary
            //Create a dictionary that will store both string keys as well as string values
        public static void Favorites()
        {
        Dictionary<string, string> favorites = new Dictionary<string, string>();

        favorites.Add("Tim","rocky road");
        favorites.Add("Martin","chocolate");
        favorites.Add("Nikki","dole whip");
        favorites.Add("Sara","cookies and cream");

        foreach (KeyValuePair<string, string> entry in favorites)
            Console.WriteLine(entry.Key +"-" + entry.Value);
        }
    }
}


