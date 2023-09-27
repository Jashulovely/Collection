using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ListDemo
    {
        public void Lists()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            List<string> listString = new List<string>();
            listString.Add("Manoj");
            listString.Add("Amit");
            listString.Add("Sudheer");
            listString.Add("Uday");
            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
            List<bool> listBool = new List<bool>();
            listBool.Add(true);
            listBool.Add(false);
            listBool.Add(true);
            listBool.Add(false);
            foreach (var item in listBool)
            {
                Console.WriteLine(item);
            }
            List<double> listDouble = new List<double>();
            listDouble.Add(11.11);
            listDouble.Add(22.22);
            listDouble.Add(33.33);
            listDouble.Add(44.44);
            foreach (var item in listDouble)
            {
                Console.WriteLine(item);
            }
        }
    }
}
