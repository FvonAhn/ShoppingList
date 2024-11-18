namespace PracticeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ShopList = new List<string>();
            bool loopList = false;
            string toBuy;

            Console.WriteLine("Välkommen till din Handlingslista");
            Console.WriteLine("Ville du lägga till något?");
            toBuy = Console.ReadLine();
            Console.WriteLine("Du la till " + toBuy + "!");
            Console.ReadKey();
        }
    }
}
