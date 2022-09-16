using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class BookStore
    {
        public int bookId;
        public string bookName;
    }

    public class Q4
    {
        public static void Main(string[] args)
        {
            try
            {
                Hashtable ht = new Hashtable();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter Book ID and name");
                    int bookId = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    ht.Add(bookId, new BookStore() { bookId = bookId, bookName = name });
                }

                Console.WriteLine("Book List :");
                foreach (DictionaryEntry i in ht)
                {
                    BookStore obj = (BookStore)i.Value;
                    Console.WriteLine(i.Key + " " + obj.bookName);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
