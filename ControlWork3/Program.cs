using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork3
{
    class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Book>()
            {
                new Book() {Name = "Guards! LINQ Guards!", Year= 1960,Author = "Stephen King"},
                new Book() {Name = "Skills", Year= 1985,Author = "Matt Damon"},
                new Book() {Name = "Persons", Year= 1835,Author = "Robin Williams"},
                new Book() {Name = "SharkLINQ", Year= 2006,Author = "Stephen King"},
                new Book() {Name = "Apocalypsis", Year= 2128,Author = "Matt Damon"},
                new Book() {Name = "Armagedon", Year= 2006,Author = "Matt Damon"},
                new Book() {Name = "LINQCrazyFrog", Year= 2008,Author = "Stephen King"}
            };
            //1

            //var books = data.Where(f => f.Name.Contains("LINQ")).Where(g => g.Year % 4 == 0);
            //foreach (var book in books)
            //    Console.WriteLine("{0} --- {1}", book.Name,book.Year );

            Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Book>().Where(f => f.Name.Contains("LINQ")).Where(g => g.Year % 4 == 0).Select(f => f.Name + " - " + f.Year)));

            //2

            var data1 = "asdAdadf sfgsf kl..tgjh wsfw,ef";
            Console.WriteLine(data1.ToLower().Replace(" ", "").Where(Char.IsLetter).Distinct().Count());
            //Console.WriteLine(res);

            //3

            var data2 = new[] { 14, 12, 23, 20, 33, 32, 43, 47, 40, 56, 52, 58, 66, 63 };
            Console.WriteLine(string.Join(",", data2.OrderBy(g => g / 10).ThenByDescending(f => f % 10)));
            

            // 4 
            Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Book>().GroupBy(f => f.Author).Select(f => f.Key + " - " + f.Count())));
        }
    }
}
