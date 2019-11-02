namespace _03BarracksFactory.Models.Units
{
    public class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDemage = 10;

        public Horseman() : base(DefaultHealth, DefaultDemage)
        {
        }
    }
}
