using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Roma", "Vlad", "Igor" };
            //int[] ages = { 16, 14 };

            //for (int i = 0; i < ages.Length; i++)
            //    Console.WriteLine($"{names[i]} - {ages[i]}");

            //for (int i = 0; i < names.Length; i++)
            //    Console.WriteLine($"{names[i]} - {ages[i]}");

            //
            User[] users = {
                new User("Roma", 16),
                new User("Vlad", 16)
            };

            foreach (var user in users)
                Console.WriteLine($"{user.Name} - {user.Age}");
        }
    }

    class User
    {
        public string Name;
        public int Age;

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public User(int age)
        {
            Name = "Temp";
            Age = age;
        }

        public string GetName()
        {
            return "Name";
        }
    }
}
