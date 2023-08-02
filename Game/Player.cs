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

    }
}