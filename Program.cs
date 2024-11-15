using SuperheroAgency.Interfaces;
using SuperheroAgency.Missions;
using SuperheroAgency.Superheros;
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

            Stack<string> books = new Stack<string>();

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

            foreach (string book in myBooks)
            {
                Console.WriteLine(book);
            }

            //for(int i = 0; i < myBooks.Length; i++)
            // {
            //     Console.WriteLine(myBooks.GetItem(i));
            // }


            // Console.WriteLine(myBooks.Pop()); // Book 3


            var strandedCat = new RescueMission<IFly>("tree", 50);
            var bugInMyCode = new RescueMission<ITech>("zoom", 1000);
            var armWrestlingCompetition = new CombatMission<IStrength>("beach", 20);

            var reyzhen = new Mystic("Michael", "Reyzhen", 7000, Alignment.GOOD);
            strandedCat.HeroesDeployed.Add(reyzhen); // All good

            //var rich = new Gadgeteer("Rich", "The Developer", 33, Alignment.EVIL);
            //strandedCat.HeroesDeployed.Add(rich); // Should provide a compile time error
            //var survey1 = new ReconMission<Gadgeteer>("Leeds", 300); // Should provide an error

            var survey2 = new ReconMission<Mystic>("Manchester", 300);

            survey2.HeroesDeployed.Add(reyzhen); // All good
            // survey2.HeroesDeployed.Add(rich); // Should provide an error

        }

    }
}
