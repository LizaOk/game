namespace Game
{
    public class Weapon
    {
        private string name;
        private int damage;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetDamage()
        {
            return damage;
        }

        public void SetDamage(int damage)
        {
            this.damage = damage;
        }
    }
}