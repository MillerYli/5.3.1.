using System;

namespace mynamespase
{
    class Program
    {
        static void Main(string[] args) 
        {
            
            int myage = 24;
            Console.WriteLine("Мой возраст: " + myage);

            ChangeAge(myage);

            Console.WriteLine("Мой измененный возраст: " + myage);

        }

        static void ChangeAge(int age)
        {
            Console.Write("Введите свой возраст: ");

            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
