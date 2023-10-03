using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool interested = true;
            while (interested)
            {
                Console.WriteLine("Enter Choice :\n   1   -->   List Demo.\n   2   -->   Array Demo.\n" +
                    "   3   -->   Two D array.\n   4   -->   ArrayList Demo.\n   5   -->   Dictionary demo.\n" +
                    "   0   -->   QUIT.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ListDemo listDemo = new ListDemo();
                        listDemo.Lists();
                        Console.ReadLine();
                        break;
                    case 2:
                        ArrayDemo arrayDemo = new ArrayDemo();
                        arrayDemo.AddElement();
                        Console.ReadLine();
                        break;
                    case 3:
                        TwoDArrayDemo twoDArrayDemo = new TwoDArrayDemo();
                        twoDArrayDemo.AddElement();
                        Console.ReadLine();
                        break;
                    case 4:
                        ArrayListDemo arrayListDemo = new ArrayListDemo();
                        arrayListDemo.Demo();
                        Console.ReadLine();
                        break;
                    case 5:
                        DictionaryDemo dictionaryDemo = new DictionaryDemo();
                        dictionaryDemo.DemoDictionary();
                        Console.ReadLine();
                        break;
                    case 0:
                        interested = false;
                        Console.WriteLine("Thanks for your ineterest.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
