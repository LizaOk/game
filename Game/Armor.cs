namespace Game
{
    public class Armor
    {
        private string name;
        private int defence;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetDefence()
        {
            return defence;
        }

        public void SetDefence(int defence)
        {
            this.defence = defence;
        }
    }
}