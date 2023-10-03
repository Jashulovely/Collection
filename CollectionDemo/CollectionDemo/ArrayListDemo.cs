using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ArrayListDemo
    {
        public void Demo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Manoj");
            arrayList.Add(3);
            arrayList.Add(11.11);
            arrayList.Add('c');
            foreach(var  item in arrayList)
            {
                Console.WriteLine(item);
            }
            for(var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

        }
    }
}
