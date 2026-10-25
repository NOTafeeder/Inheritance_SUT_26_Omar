using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_SUT_26_Omar.Models
{
    internal class Monkey : Animal
    {
        private string _favoriteFood = "Bananas";
        public string FavoriteFood { get; set; } = "Bananas";
        public Monkey(string name, string species, int age, bool isPredator, string habitat, string favoriteFood) : base(name, species, age, isPredator, habitat)
        {
            FavoriteFood = favoriteFood;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ooh ooh aah aah!");
        }
        public override void Move()
        {
            Console.WriteLine("Swings through trees");
        }
        public override void Eat()
        {
            Console.WriteLine("Eats fruits and insects");
        }
        public void EatFavoriteFood()
        {
            Console.WriteLine($"The monkey is eating its favorite food: {FavoriteFood}");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, IsPredator: {IsPredator}, Habitat: {Habitat}, FavoriteFood: {FavoriteFood}");
        }
    }
}
