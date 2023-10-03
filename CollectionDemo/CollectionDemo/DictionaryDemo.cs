using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class DictionaryDemo
    {
        public void DemoDictionary()
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("key1", "value1");
            dic.Add("key2", "value2");
            dic.Add("key3", "value3");
            dic.Add("key4", "value4");
            dic.Add("key5", "value5");
            foreach(KeyValuePair<string,string> kvp in dic)
            {
                Console.Write(kvp.Key + " : ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }
            dic["key3"] = "kumar";
            foreach(var data  in dic)
            {
                Console.Write(data.Key + " : ");
                Console.Write(data.Value);
                Console.WriteLine();
            }
            for(int i = 0; i< dic.Count; i++)
            {
                var item = dic.ElementAt(i);
                Console.WriteLine(item.Key +" : "+ item.Value);
            }
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(100, "value1");
            dict.Add(101, "value2");
            dict.Add(102, "value3");
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.Write(kvp.Key + " : ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }
            Dictionary<double, string> d = new Dictionary<double, string>();
            d.Add(11.11, "value1");
            d.Add(22.22, "value2");
            d.Add(33.33, "value3");
            foreach (KeyValuePair<double, string> kvp in d)
            {
                Console.Write(kvp.Key + " : ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }
        }
    }
}
