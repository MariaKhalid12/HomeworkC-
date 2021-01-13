using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "Pleas fill the following information!";
            Console.WriteLine(info);

            Console.Write("User name : ");
            String username = Console.In.ReadLine();
            string num;
            int age;
            Console.Write("Age : ");
            num = Console.ReadLine();
            age = Convert.ToInt32(num);

            int date = 2021;
            int res = (date - age);
            Console.WriteLine("_______________________________________");
            Console.WriteLine("User name : " + username);
            Console.WriteLine("Date of Birth : " + res);
            Console.WriteLine("_______________________________________");
        }
    }
}
