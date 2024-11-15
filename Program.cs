using System.Security.Cryptography.X509Certificates;

namespace SuperheroAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> alist = new List<string> { "Hello", "World" };
            //alist.Add(1);

            //var newDict = new Dictionary<int, string>
            //    {
            //      { 1, "a"},
            //      { 2, "b" },
            //      { "hello", 1 } // error!
            //    };

            T GetLast<T>(T[] anArray)
            {
                T output = anArray[anArray.Length -1];
                return output;
            }

            //int[] intArray = { 1, 5, 2, 8, 6 };
            //Console.WriteLine(GetLast<int>(intArray)); // 6

            //double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            //Console.WriteLine(GetLast(doubleArray)); // 6.1111

            //string[] stringArray = { "hello", "world", "it's", "northcoders!" };
            //Console.WriteLine(GetLast(stringArray)); // "northcoders"

            //Stack<string> books = new Stack<string>();

            //books.Push("Narnia");
            //books.Push("Harry Potter");
            //books.Push("Hunger Games");
            ////books.Push(1);
            //books.Pop();

            //Console.WriteLine(books.Count);
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            var myBooks = new CustomStack<string>();

            myBooks.Push("Book 1");
            myBooks.Push("Book 2");
            myBooks.Push("Book 3");
           
           for(int i = 0; i < myBooks.Length; i++)
            {
                Console.WriteLine(myBooks.GetItem(i));
            }
            

            Console.WriteLine(myBooks.Pop()); // Book 3

        }

    }
}
