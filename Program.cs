using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(600, 600);
            Console.Title = ".netfundamental";
            Console.SetCursorPosition(50, 3);
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
            string bornstr = Console.ReadLine();
            int born = int.Parse(bornstr);
            if (born <= 1360) //  age limited
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you cant contnue");
                return;
            }

            bool Isenteredvalidmobilenumber = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("please enter your mobilnumber:");
                string mobilenumber = Console.ReadLine();
                mobilenumber = mobilenumber.Trim();
                if (!string.IsNullOrEmpty(mobilenumber) && mobilenumber.Length == 11)

                {
                    string submobilenumber = mobilenumber.Substring(0, 1);
                    if (submobilenumber == "09")
                    {
                        Isenteredvalidmobilenumber = true;
                        break;

                    }
                        
                }

            }
            if (Isenteredvalidmobilenumber)
            {
                Console.WriteLine("you finished your Registration");
                string description = $"name: {name} lastname:{lastname} born at {born} mobilenumber:09*****"; //how use dynamic mobilenumber hear?????
                Console.WriteLine(description);
            }
            else
            {
                Console.WriteLine("Invalide number");
            }


        }

    }
}