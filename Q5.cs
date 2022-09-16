using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    class Student
    {
        public int rollNo,currentClass;
        public string name;
        public char sec;

    }
    internal class Q5
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Student's Roll No, Name, Class and Section");
                int rollNo = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int currentClass = int.Parse(Console.ReadLine());
                char sec = Convert.ToChar(Console.ReadLine());
                students.Add(new Student() { rollNo=rollNo,name=name,currentClass=currentClass,sec=sec});
            }
            Console.WriteLine("Student Details");
            foreach(Student s in students)
            {
                Console.WriteLine($"{s.name} {s.rollNo} {s.currentClass} {s.sec}");
            }
        }
    }
}
