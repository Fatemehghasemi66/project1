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
         static int Add(int x, int y, int z)
        {
            return (x * y)+z;

        }
         static void ShowDevider()
        {
            Console.WriteLine("************************************************************************************************");
        }
        static int Addnumber(int x, int y, int z)
        {
            return (x+z)-y;
        }
        public static int GetnumberFromUser()
        {
            Console.WriteLine("pleas enter number:");
            string numSTR = Console.ReadLine();
            return Convert.ToInt32(numSTR);
        }
        static void Main(string[] args)
        {
            
            int result = Add(5, 2, 3);
            Console.WriteLine(result);
            
            int num1 = GetnumberFromUser();
            int num2 = GetnumberFromUser();
            int num3 = GetnumberFromUser();
            int result2 = Add(num1, num2, num3);
            Console.WriteLine(result2);




           
            




            //Console.SetBufferSize(600, 600);
            //Console.Title = ".netfundamental";
            //Console.SetCursorPosition(40, 3);
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Black;

            //Console.WriteLine("wellcome to CsharpClass");
            //ShowDevider();ShowDevider();
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.WriteLine("enter name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter lastname:");
            //string lastname = Console.ReadLine();
            //Console.WriteLine("when you born:");
            //string bornstr = Console.ReadLine();
            //int born = int.Parse(bornstr);
            //if (born <= 1360) //  age limited
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("you cant contnue");
            //    return;
            //}

            //bool isenteredvalidmobilenumber = false;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("please enter your mobilnumber:");
            //    string mobilenumber = Console.ReadLine();
            //    mobilenumber = mobilenumber.Trim();
            //    if (!string.IsNullOrEmpty(mobilenumber) && mobilenumber.Length == 11)

            //    {
            //        string submobilenumber = mobilenumber.Substring(0, 2);
            //        if (submobilenumber == "09")
            //        {
            //            isenteredvalidmobilenumber = true;
            //            break;

            //        }

            //    }

            //}
            
            //if (isenteredvalidmobilenumber)
            //{
            //    Console.WriteLine("you finished your Registration");
            //    string description = $"name: {name} lastname:{lastname} born at {born} mobilenumber:09****"; //how use dynamic mobilenumber hear?????
            //    Console.WriteLine(description);
            //}
            //else
            //{
            //    Console.WriteLine("Invalide number");
            //}


        }

    }
}