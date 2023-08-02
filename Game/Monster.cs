namespace Game
{
    public class Monster : Person
    { 
        int damage = 0;
        int armor = 0;
        int pointsAfterWin = 0;
 
        public Monster(string name) : base(name)
        {
//            this.setName(name);
        }
 
        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public int getDamage()
        {
            return this.damage;
        }
        //---------------------------------------
        public void setArmor(int armor)
        {
            this.armor = armor;
        }

        public int getArmor()
        {
            return this.armor;
        }
        //---------------------------------------
 
        public void setPointsAfterWin(int pointsAfterWin)
        {
            this.pointsAfterWin = pointsAfterWin;
        }

        public int getPointsAfterWin()
        {
            return this.pointsAfterWin;
        }
    }
}