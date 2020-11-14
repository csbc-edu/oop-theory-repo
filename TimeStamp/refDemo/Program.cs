using System;

namespace refDemo
{
    class CS0663_Example
    {
        // Compiler error CS0663: "Cannot define overloaded
        // methods that differ only on ref and out".
        public void SampleMethod(int i) { }
        // public void SampleMethod(out int i) { }
        public void SampleMethod(ref int i) {
            
        }

        public static ref int Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }
    }


    class Program
    {
        static void Display(double[] s)
        {
            Console.WriteLine(string.Join(" ", s));
        }

        static void Method(ref int refArgument)
        {
            refArgument = refArgument + 44;
        }

        static void Main(string[] args)
        {
            int number = 1;
            Method(ref number);
            Console.WriteLine(number);

            double[] arr = { 0.0, 0.0, 0.0 };
            Display(arr);

            ref double arrayElement = ref arr[0];
            arrayElement = 3.0;
            Display(arr);

            arrayElement = ref arr[arr.Length - 1];
            arrayElement = 5.0;
            Display(arr);

            var bc = new BookCollection();
            bc.ListBooks();

            ref var book = ref bc.GetBookByTitle("Call of the Wild, The");
            if (book != null)
                book = new Book { Title = "Republic, The", Author = "Plato" };
            bc.ListBooks();
        }
    }

    public class Book
    {
        public string Author;
        public string Title;
    }

    public class BookCollection
    {
        private Book[] books = { new Book { Title = "Call of the Wild, The", Author = "Jack London" },
                        new Book { Title = "Tale of Two Cities, A", Author = "Charles Dickens" }
                       };
        private Book nobook = null;

        public ref Book GetBookByTitle(string title)
        {
            for (int ctr = 0; ctr < books.Length; ctr++)
            {
                if (title == books[ctr].Title)
                    return ref books[ctr];
            }
            return ref nobook;
        }

        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}, by {book.Author}");
            }
            Console.WriteLine();
        }
    }
}
