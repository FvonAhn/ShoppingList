using System.Reflection.Metadata;

namespace PracticeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ShopList = [];
            bool AddLoop = true;

            Console.WriteLine("Detta är din Handlingslista.");


            Console.WriteLine("Vill du lägga till något?");
            Console.WriteLine("Y / N");
            string answer = Console.ReadLine()!;


            if (answer == "y")
            {
                Console.WriteLine("Vad vill du lägga till?");
                ShopList.Add(Console.ReadLine()!);
            }
            else
            {
                Console.WriteLine("OK, ingenting alltså..");
            }


            foreach (string item in ShopList)
                Console.WriteLine($"Din lista innehåller: {item}");

            Console.ReadKey();
        }
            
    }
}
