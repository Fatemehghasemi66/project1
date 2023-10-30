using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace project1
{
    internal class Program
    {
        static void StarDivider()
        {
            Console.WriteLine("*******************************************************************************************************************************************************************");
        }
        public static int Age()
        {
            var year = 1400; // chetor bayad dynamic bashad!!!!!!
            Console.WriteLine("when is you born?");
            int born = int.Parse(Console.ReadLine());
            if (born < 1200)
            {
                return 0;

            }
            return year - born;

        }
        public static int MobileNumber()
        {
            Console.WriteLine("pleas enter yor MobileNumber");
            string mobileNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(mobileNumber))
            {
                return 0;
            }
            return Convert.ToInt32(mobileNumber);
        }
        public static int Username()
        {
            Console.WriteLine("your password is:");
            int userName = MobileNumber();
            string userSTR = Convert.ToString(userName);
            string username = userSTR.Substring(0, 5);
        

            return Convert.ToInt32(username);
        }

        static void Main(string[] args)
        {

            Console.SetBufferSize(600, 600);
            Console.Title = ".netfundamental";
            Console.SetCursorPosition(50, 3);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("wellcome to CsharpClass");
            StarDivider();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter lastname:");
            string lastname = Console.ReadLine();
            int age = Age();
            Console.WriteLine(age);
            int mobile = MobileNumber();
            Console.WriteLine(mobile);
            int username = Username();
            Console.WriteLine(username);












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


        }//main

    }//program
}//project1