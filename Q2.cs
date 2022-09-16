using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            List<string> arr = new List<string>();
            Console.WriteLine("Enter 10 names");
            for (int i = 0; i < 10; i++) arr.Add(Console.ReadLine());
            arr.Sort();
            arr.Reverse();
            Console.WriteLine("After sorting :");
            foreach (string i in arr) Console.WriteLine(i);
        }
    }
}
