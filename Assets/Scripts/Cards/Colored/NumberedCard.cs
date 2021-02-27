using System;

namespace Assets.Scripts.Cards.Colored
{

    public class NumberedCard : ColoredCard
    {

        public static readonly int NumberMin = 0;
        public static readonly int NumberMax = 9;

        public int Number { get; }

        public NumberedCard(Color color, int number) : base(color)
        {
            if (number < NumberMin) throw new IndexOutOfRangeException("Must be above " + NumberMin);
            if (number > NumberMax) throw new IndexOutOfRangeException("Must be below " + NumberMax);
            
            Number = number;
        }
        
    }

}
