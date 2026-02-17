using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for their first name 
            System.Console.WriteLine("Hello User! Input your first name so I may address you formally please!");
            string Firstname = System.Console.ReadLine();
            //Asks the user for their surname
            System.Console.WriteLine("Hello " + Firstname + "! And your last name?");
            string Lastname = System.Console.ReadLine();
            //This let's the user confirm whether or not this is their name or not, and if not, it allows them to try again.
            System.Console.WriteLine("So your name is " + Firstname + " " + Lastname + "? Is that correct? (Y/N)");
            string Answer = System.Console.ReadLine();
                if (Answer == "Y" || Answer == "y")
            {
                System.Console.WriteLine("Perfect! You have a wonderful name " + Firstname + " " + Lastname + "!");
            }
            else if (Answer == "N" || Answer == "n")
            {
                System.Console.WriteLine("Well, that's okay! You can always try again User!");
                Main(args);
            }


        }
    }
}