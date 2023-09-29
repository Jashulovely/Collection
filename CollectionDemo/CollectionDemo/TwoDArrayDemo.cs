using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class TwoDArrayDemo
    {
        public void AddElement()
        {
            int[,] array = { { 1, 2, 3, 4 },{ 5, 6 ,7 ,8 } };
            Console.WriteLine(array[0,1]);
            Console.WriteLine(array[1,3]);
            Console.WriteLine("--------------------------------------");
            foreach (int i in array) Console.WriteLine(i);
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++) Console.Write(array[0,i]);
            Console.WriteLine();
            for (int i = 0;i < array.GetLength(1); i++) Console.Write(array[1,i]);
        }
    }
}
