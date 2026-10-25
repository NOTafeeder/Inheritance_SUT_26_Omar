using Arv_SUT_26_Omar.Models;

namespace Arv_SUT_26_Omar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Whiskers", "Felis catus", 3, true, "Domestic", "Indoor");
            cat.DisplayInfo();
            Monkey monkey = new Monkey("George", "Cercopithecidae", 5, true, "Tropical", "Bananas");
            monkey.DisplayInfo();
            Tiger tiger = new Tiger("Sher Khan", "Panthera tigris", 7, true, "Asia", 200.0);
            tiger.DisplayInfo();
            SiberianTiger siberianTiger = new SiberianTiger("Siber", "Panthera tigris altaica", 10, true, "Siberia", 200.0, "White with black stripes");
            siberianTiger.DisplayInfo();
            BengalTiger bengalTiger = new BengalTiger("Bengal", "Panthera tigris tigris", 8, true, "India", 150.0, true);
            bengalTiger.DisplayInfo();
            cat.MakeSound();
            monkey.MakeSound();
            tiger.MakeSound();
            siberianTiger.MakeSound();
            bengalTiger.MakeSound();
            cat.GoHome();
            monkey.EatFavoriteFood();
            tiger.Hunt();
            siberianTiger.SurviveWinter();
            bengalTiger.Swim();
        }
    }
}
