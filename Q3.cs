using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            SortedDictionary<int,string> arr = new SortedDictionary<int, string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter employee ID and name");
                int empId = int.Parse(Console.ReadLine());
                string empName = Console.ReadLine();
                arr.Add(empId, empName);
            }
            
            Console.WriteLine("Employee List :");
            foreach (int i in arr.Keys) { 
                Console.WriteLine(i+" "+arr[i]);
            }
        }
    }
}
