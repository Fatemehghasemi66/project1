using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(600, 600);
            Console.Title = ".netfundamental";
            Console.SetCursorPosition(50,3);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("wellcome to site");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
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
            string mobilenumber = Console.ReadLine();
            string phone = mobilenumber.Substring(0,7);
            string showphone = $"{phone}****";


            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            mobilenumber = mobilenumber.Trim();

            string description = $"name: {name} lastname:{lastname} born at {born} contact:{showphone}";
            Console.WriteLine(description);









        }
    }
}