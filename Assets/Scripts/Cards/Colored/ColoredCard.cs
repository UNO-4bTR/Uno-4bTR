namespace Assets.Scripts.Cards.Colored
{
    
    public class ColoredCard : Card
    {
        
        public Color Color { get; }
        
        private ColoredCard() {}

        public ColoredCard(Color color)
        {
            Color = color;
        }
        
    }
    
}
