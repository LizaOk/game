using System;
using System.Collections.Generic;

namespace Game
{
    public class Engine
    {
        public static Armor GenerateArmor()
        {
            Random rnd = new Random();
            List<string> armorNames = new List<string>
                {"Plate Mail", "Chainmail", "Leather Armor", "Scale Mail", "Robes", "Plate Armor"};

            int index = rnd.Next(armorNames.Count);
            string randomName = armorNames[index];

            int randomDefence = rnd.Next(3, 21);

            Armor armor = new Armor();
            armor.SetName(randomName);
            armor.SetDefence(randomDefence);

            return armor;
        }

        public static Weapon GenerateWeapon()
        {
            Random rnd = new Random();
            List<string> weaponNames = new List<string>
                {"Sword", "Axe", "Bow", "Dagger", "Staff", "Mace"};

            int index = rnd.Next(weaponNames.Count);
            string randomName = weaponNames[index];

            int randomDamage = rnd.Next(3, 21);

            Weapon weapon = new Weapon();
            weapon.SetName(randomName);
            weapon.SetDamage(randomDamage);

            return weapon;
        }
        public static Monster GenerateMonster(Player player)
        {
            Random rnd = new Random();
            List<string> monsterNames = new List<string>
            {"Orc", "Goblin", "Mole Rat", "Ogre", "Kobold",
                "Zulgat", "Zombie", "Dragon", "Doppelgunter", "Basilisk", "Gargoyle", "Bagber", "Scorpion"};

            int index = rnd.Next(monsterNames.Count);
            string randomName = monsterNames[index];

            int playerLevel = player.getLevel();
            int monsterLevel;
            if (playerLevel == 1 || playerLevel == 0)
            {
                monsterLevel = rnd.Next(playerLevel, playerLevel + 1);
            }
            else
            {
                monsterLevel = rnd.Next(playerLevel - 1, playerLevel + 1);
            }; 
            Console.WriteLine(monsterLevel);
            int randomHealth = rnd.Next(10 * monsterLevel, 20 * monsterLevel);
            int randomEnergy = rnd.Next(10 * monsterLevel, 20 * monsterLevel);
            int randomDamage = rnd.Next(10 * monsterLevel, 20 + monsterLevel);
            int randomArmor = rnd.Next(10 * monsterLevel, 20 + monsterLevel);
            int randomPointsAfterWin = rnd.Next(100 * monsterLevel, 130 + monsterLevel);


            Monster monster = new Monster(randomName);
            monster.setHealth(randomHealth);
            monster.setEnergy(randomEnergy);
            monster.setDamage(randomDamage);
            monster.setArmor(randomArmor);
            monster.setPointsAfterWin(randomPointsAfterWin);

            return monster;
        }

        public static Player CreatePlayer(string playerName, HeroType type)
        {
            Player player;

            if (type == HeroType.Barbarian)
            {
                player = new Barbarian(playerName);
            }
            else if (type == HeroType.Tank)
            {
                player = new Tank(playerName);
            }
            else if (type == HeroType.Rogue)
            {
                player = new Rogue(playerName);
            }
            else
            {
                throw new ArgumentException("Invalid player class.");
            }
            player.setHealth(player.getEndurance()*10);
            player.setEnergy(player.getAgility()*10);
            
            return player;
        }
    }
}