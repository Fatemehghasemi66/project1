using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("wellcome to site");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("when you born:");
            int born = Convert.ToInt32(Console.ReadLine());
            if (born <= 1360)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you cant contnue");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("sucsese");
            }

            //nead break

            Console.WriteLine("please enter your mobilphon:");
            string mobilenumber= Console.ReadLine();
          
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            mobilenumber = mobilenumber.Trim();
            string phone = mobilenumber.Substring(0,3);
            string description = $"name: {name} lastname:{lastname} born at {born} contact:{phone}";
            Console.WriteLine(description);

             
           






        }
    }
}