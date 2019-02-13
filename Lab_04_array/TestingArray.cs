using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_04_array;

namespace Lab_04_array
{
    public class TestingArray        //This will change the name of the .cs file
    {
        //Build some code here : test output
        //Summing squares
        public int CreateArray(int size)
        {
            int[] myArray = new int[size];
            //Insert squares
            for (int i = 0; i < 20; i++)
            {
                myArray[i] = i * i;
            }
            //Check values
            int total = 0;
            foreach (int i in myArray)
            {
                total += i;
            }
            return total;
        }
    }
}
