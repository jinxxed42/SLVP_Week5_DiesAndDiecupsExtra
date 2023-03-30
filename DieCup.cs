namespace SLVP_Week5_DiesAndDiecupsExtra
{
    internal class DieCup
    {
        private Die d1;
        private Die d2;
        private static Random _rand;

        public DieCup()
        {
            _rand = new Random();
            d1 = new Die(_rand.Next(1, 21));
            d2 = new Die(_rand.Next(1, 21));
        }

        public void Roll()
        {
            d1.Roll();
            d2.Roll();
        }

        public int GetValue()
        {
            return d1.GetValue() + d2.GetValue();
        }

        public string ToString()
        {
            return d1.GetValue() + "(" + d1.sides + " sides)" + " + " + d2.GetValue() + "(" + d2.sides + " sides)" + " = " + GetValue();
        }

    }
}
