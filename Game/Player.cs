namespace Game
{
    public class Player : Person
    {
       
        protected int power = 0;
        protected int agility = 0;
        protected int endurance = 0;
        protected int experiencePoints = 0;

        public Player(string name) : base(name)
        { 
            this.setName(name);
        }

        public void setPower(int power)
        {
            this.power = power;
        }

        public int getPower()
        {
            return this.power;
        }
        //---------------------------------------
        public void setAgility(int agility)
        {
            this.agility = agility;
        }

        public int getAgility()
        {
            return this.agility;
        }
        //---------------------------------------
        public void setEndurance(int endurance)
        {
            this.endurance = endurance;
        }

        public int getEndurance()
        {
            return this.endurance;
        }
        //---------------------------------------

        public void setExperiencePoints(int experiencePoints)
        {
            this.experiencePoints = experiencePoints;
        }

        public int getExperiencePoints()
        {
            return this.experiencePoints;
        }
        //---------------------------------------
        private Armor armor;
        private Weapon weapon;

        public Player(string name) : base(name)
        {
            this.setName(name);
        }

        public void SetArmor(Armor armor)
        {
            this.armor = armor;
        }

        public Armor GetArmor()
        {
            return armor;
        }

        public void SetWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }
        public int CalculateDamage()
        {
            int baseDamage = weapon != null ? weapon.GetDamage() : 0;
            int totalDamage = baseDamage + power;

            int agility = getAgility(); // Отримуємо значення Agility.

            Random rnd = new Random();
            int criticalChance = rnd.Next(1, 101); // Генеруємо випадкове число від 1 до 100.

            if (criticalChance <= agility)
            {
                // Критичний удар! Подвоюємо урон.
                totalDamage = (int)(totalDamage * 1.5);
                Console.WriteLine("Critical Hit!");
            }
            return totalDamage;
        }

        public void TakeDamage(int damage)
        {
            if (armor != null)
            {
                int remainingArmor = armor.GetDefence() - damage;
                if (remainingArmor < 0)
                {
                    // Урон перевищив броню, віднімаємо залишок урону від здоров'я.
                    int remainingDamage = Math.Abs(remainingArmor);
                    int remainingHealth = getHealth() - remainingDamage;
                    setHealth(remainingHealth);
                    armor = null; // Зброя зруйнована.
                }
                else
                {
                    armor.SetDefence(remainingArmor);
                }
            }
            else
            {
                // Броня вже вичерпана, віднімаємо урон від здоров'я.
                int remainingHealth = getHealth() - damage;
                setHealth(remainingHealth);
            }
        }
    }
}