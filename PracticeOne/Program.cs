using System.Reflection.Metadata;
using System.Runtime.InteropServices;

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

            while (AddLoop) //while-loop to keep the user in the loop until they chooses to quit.
            {
                if (qLoop) //this only changes the first question after the first time it is asked.
                {
                    Console.WriteLine("Vill du lägga till något? (Använd små bokstäver).");
                    qLoop = false;
                }
                else
                {
                    Console.WriteLine("Vill du lägga till något mer? (Anbänd dig av små bokstäver)"); //the altered question. 
                }
            
                Console.WriteLine("Y / N"); //a statement to make the user know what to answer.
                string answer = Console.ReadLine()!.ToLower();


                if (answer == "y")
                {
                    Console.WriteLine("Vad vill du lägga till?"); // if the user answers "y" on the Q before, this questions appear.
                    ShopList.Add(Console.ReadLine()!);
                }
                else if (answer == "n") 
                {
                    AddLoop = false; // if the user answers "no" on the Q the while-loop.
                }
                else
                {
                    Console.WriteLine("Error, du kan enbart svara Ja(y) eller nej(n)på frågan."); //error message for when the user chooses anything other the "y" or "n".
                }

            }

            if (ShopList.Count == 0)
            {
                Console.WriteLine("Din Handlingslisa är tom."); // this shows if the user dont add anything to the list.
            }
            else
            {
                Console.WriteLine("Din Handlingslista:");
                foreach (string item in ShopList)
                    Console.WriteLine($"- {item}"); // and this writes out everything the user added to the list.
            }

            Console.ReadKey();
        }
    }
}
