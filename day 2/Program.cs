using System;
namespace day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz enter your name ");
           string name=Console.ReadLine();
            Console.WriteLine("plz enter your id: ");
            int id=int.Parse(Console.ReadLine());
            int age;
            do
            {
                Console.WriteLine("plz enter your age:");
                age = int.Parse(Console.ReadLine());
            }while( age <1 );
            Console.WriteLine($"""
              your name is: {name} 

              your id is: {id}

              your age is:{age}
              """);
        }
    }
}
