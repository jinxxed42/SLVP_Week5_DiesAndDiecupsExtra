namespace SLVP_Week5_DiesAndDiecupsExtra
{
    internal class Die
    {
        // Private fields naming according to https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
        private static Random _rand;
        private int _value;
        public int sides;

        public Die(int sides)
        {
            this.sides = sides;
            _rand = new Random();
            _value = _rand.Next(1, sides);
        }

        public void Roll()
        {
            _value = _rand.Next(1, sides);
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
