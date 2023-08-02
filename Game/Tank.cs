namespace Game
{
    public class Tank : Player 
    {
        public Tank( string name) : base(name)
        {
            this.power = 15;
            this.agility = 15;
            this.endurance = 30;

        }
    }
}