using System;

namespace Game
{
    public class Person
    {
        int health = 0;
        int energy = 0;
        int level = 0;
        string name = "";

        static int autoId = 1;
        private int Id = 0;

        private void generateId()
        {
            this.Id = autoId++;
        }

        public int getId() { return this.Id; }

        protected Person(string name)
        { 
            this.name = name;

            this.generateId();
        }
        public void setHealth(int health)
        {
            this.health = health;
        }

        public int getHealth()
        {
            return this.health;
        }
        //---------------------------------------
        public void setEnergy(int energy)
        {
            this.energy = energy;
        }

        public int getEnergy()
        {
            return this.energy;
        }
        //---------------------------------------
        public void setLevel(int level)
        {
            this.level = level;
        }

        public int getLevel()
        {
            return this.level;
        }
        //---------------------------------------
        protected void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void showInfo()
        {
            Console.WriteLine($"Class:{this.GetType()} Name: {name} ID: {this.Id}");
            Console.WriteLine($"Health:{this.getHealth()} Enerhy: {this.getEnergy()}");
        }
    }
}