using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //user will input their name 
            string name;
            Console.WriteLine("Please enter your name.");
            //assigning the user's input
            name = Console.ReadLine();
            //I included some page breaks for easier readibility 
            Console.WriteLine(" ");
            Console.WriteLine("__________________________________");
            Console.WriteLine(" ");
            
            //user is greeted with whatever name they inputted

            Console.WriteLine("Hello {0}!", name);
        }
    }
}
