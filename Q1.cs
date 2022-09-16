using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Q1
    {
        public static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.WriteLine("Enter 10 numbers");
            for (int i = 0; i < 10; i++) arr.Add(int.Parse(Console.ReadLine()));
            arr.Sort();
            Console.WriteLine("After sorting :");
            foreach(int i in arr) Console.WriteLine(i);
        }
    }
}
