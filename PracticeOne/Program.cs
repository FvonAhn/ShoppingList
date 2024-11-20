using System.Reflection.Metadata;

namespace PracticeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ShopList = [];
            bool AddLoop = true;
            bool qLoop = true;

            Console.WriteLine("Detta är din Handlingslista.");

            while (AddLoop)
            {
                if (qLoop)
                {
                    Console.WriteLine("Vill du lägga till något?");
                    qLoop = false;
                }
                else
                {
                    Console.WriteLine("Vill du lägga till något mer?");
                }
            
                Console.WriteLine("Y / N");
                string answer = Console.ReadLine()!;


                if (answer == "y")
                {
                    Console.WriteLine("Vad vill du lägga till?");
                    ShopList.Add(Console.ReadLine()!);
                }
            
                else
                {
                    Console.WriteLine("Din handlingslista.");
                    AddLoop = false;
                }

            }

            foreach (string item in ShopList)
                Console.WriteLine($"Din lista innehåller: {item}");

            Console.ReadKey();
        }
            
    }
}
