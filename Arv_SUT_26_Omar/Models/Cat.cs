using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Arv_SUT_26_Omar.Models
{
    internal class Cat : Animal
    {
        public string GoingHome { get; set; } = "Unknown";
        public Cat(string name, string species, int age, bool isPredator, string habitat, string goingHome) : base(name, species, age, isPredator, habitat)
        {
            GoingHome = goingHome;
        }

        
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public override void Move()
        {
            Console.WriteLine("Runs on all fours");
        }

        public override void Eat()
        {
            Console.WriteLine("Eats fish");
        }
        public void GoHome()
        {
            Console.WriteLine($"The cat is going home to {GoingHome}");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, IsPredator: {IsPredator}, Habitat: {Habitat}, GoingHome: {GoingHome}");
        }
    }
}
