namespace HeroesVsMonster_Labo.Characters
{
    internal abstract class Character
    {
        public int Endurance { get; private init; }
        public int Strength { get; private init; }
        private int Life { get; set; }

        protected Character(Dice dice)
        {
            Endurance = InitiateStatistics(dice);
            Strength = InitiateStatistics(dice);
            Life = CalculateStatistic(Endurance);
        }
        public event Action? OnStrikeEvent;

        public abstract int Strike(Dice dice);


        private int InitiateStatistics(Dice dice) 
        {
            int sum = 0;
            int smallerIndex = 0;
            int smaller = 0;
            int lastThrow = 0;

            int[] draw = new int[3];

            for (int i = 0; i < 3; i++)
            {
                draw[i] = dice.Throw();

                if (i == 0 || draw[i] < smaller)
                {
                    smallerIndex = i;
                    smaller = draw[i]; 
                }
            }

            lastThrow = dice.Throw();

            if (lastThrow < draw[smallerIndex])
            {
                draw[smallerIndex] = lastThrow;
            }

            sum = draw.Sum();

            return sum;
        }

        protected int CalculateStatistic(int caracteristic)
        {
            if (caracteristic < 5)
            {
                caracteristic--;
            }
            else if (caracteristic < 10)
            {
                return caracteristic;
            }
            else if (caracteristic < 15)
            {
                caracteristic++;
            }
            else
            {
                caracteristic += 2;
            }

            return caracteristic;
        }

        protected void InvokeOnStrikeEvent()
        {
            OnStrikeEvent?.Invoke();
        }
    }
}
