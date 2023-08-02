using System;

namespace Game
{
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the player's name: ");
            string namePl = Console.ReadLine();
            Console.WriteLine("Enter the player's type: "); 
            Console.WriteLine("Barbarian - 1, Tank - 2, Rogue - 3"); 
            string heroType = Console.ReadLine();
            HeroType hero = HeroType.Barbarian;
            switch (heroType)
            {
                case "1":
                    hero = HeroType.Barbarian;
                    break;
                case "2":
                    hero = HeroType.Tank;
                    break;
                case "3":
                    hero = HeroType.Rogue;
                    break;
                default:
                    Console.WriteLine("Class is wrong");
                    return;
            }

            Player player = Engine.CreatePlayer(namePl,hero);
            player.showInfo();

            Monster firstMonster = Engine.GenerateMonster(player);

        }
    }
}