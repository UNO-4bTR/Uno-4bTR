namespace Assets.Scripts.Cards.Wildcard
{
    
    public class WildcardCard : Card
    {
        
        public WildcardType Type { get; }

        private WildcardCard() {}

        public WildcardCard(WildcardType type)
        {
            Type = type;
        }
        
    }
    
}
