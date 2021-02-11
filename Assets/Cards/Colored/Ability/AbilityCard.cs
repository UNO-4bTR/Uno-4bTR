namespace Cards.Colored.Ability
{
    
    public class AbilityCard : ColoredCard
    {

        public AbilityType Type { get; }

        public AbilityCard(Color color, AbilityType type) : base(color)
        {
            Type = type;
        }
        
    }
    
}
