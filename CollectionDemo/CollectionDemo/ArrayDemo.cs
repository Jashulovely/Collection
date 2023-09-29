using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    //It is a collection of elements with the same data type.
    //stores only fixed elements.

    internal class ArrayDemo
    {
        public void AddElement()
        {
            //Dec;aration of array
            int[] arrayIntOne = new int[5];
            arrayIntOne[0] = 1;
            arrayIntOne[1] = 2;
            arrayIntOne[2] = 3;
            arrayIntOne[3] = 4;
            arrayIntOne[4] = 5;
            int[] arrayIntTwo = new int[5] { 1, 2, 3, 4, 5};
            int[] arrayIntThree = new int[] { 1, 2, 3, 4, 5};
            int[] arrayIntFour = {1, 2, 3, 4, 5};
            Console.WriteLine();
            string[] arrayStringOne = new string[3];
            arrayStringOne[0] = "Manoj";
            arrayStringOne[1] = "Amit";
            arrayStringOne[2] = "Uday";
            string[] arrayStringTwo = new string[3] { "Rakesh", "Ramu", "Raju"};
            string[] arrayStringThree = new string[] {"Ram","Lakshman"};
            string[] arrayStringFour = {"Anu","Manu","Vinu"};
            Console.WriteLine();
            double[] arrayDoubleOne = new double[3];
            arrayDoubleOne[0] = 1.11;
            arrayDoubleOne[1] = 2.22;
            arrayDoubleOne[2] = 3.33;
            double[] arrayDoubleTwo = new double[3] { 4.0, 5.0, 6.0};
            double[] arrayDoubleThree = new double[] {7.0, 8.0, 9.0};
            double[] arrayDoubleFour = {10.0, 11.0, 12.0};
            Console.WriteLine();
            bool[] arrayBoolOne = new bool[3];
            arrayBoolOne[0] = true;
            arrayBoolOne[1] = false;
            arrayBoolOne[2] = true;
            bool[] arrayBoolTwo = new bool[3] { false, false, true};
            bool[] arrayBoolThree = new bool[] {true, true, true};
            bool[] arrayBoolFour = {true, false, true};
            Console.WriteLine("--------------------------------------------");
            foreach (int num in arrayIntOne)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------------------------");
            int j = 0;
            while (j < arrayIntOne.Length)
            {
                Console.WriteLine(arrayIntOne[j]);
                j++;
            }
            Console.WriteLine("--------------------------------------------");
            foreach (string str in arrayStringOne)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----------------------------------------------");
            int i = 0;
            while (i < arrayStringOne.Length)
            {
                Console.WriteLine(arrayStringOne[i]);
                i++;
            }
            Console.WriteLine("-----------------------------------------------");
            foreach (double doub in arrayDoubleOne)
            {
                Console.WriteLine(doub);
            }
            int k = 0;
            while (k < arrayDoubleOne.Length)
            {
                Console.WriteLine(arrayDoubleOne[k]);
                k++;
            }
            Console.WriteLine("-----------------------------------------------");
            foreach (bool boo in arrayBoolOne)
            {
                Console.WriteLine(boo);
            }
            int l = 0;
            while (l < arrayBoolOne.Length)
            {
                Console.WriteLine(arrayBoolOne[l]);
                l++;
            }
        }
    }
}
