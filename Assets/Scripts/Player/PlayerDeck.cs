namespace Assets.Scripts.Player
{
    
    public class PlayerDeck
    {
        
        public int[] Deck;
        void Main(string[] args)
        {
            if (Deck.Length == 0) //ako deck nema nista u sebi, poziva se funkcija za povlacenje jedne karte 7 puta
            {
                for (int i = 0; i < 7; i++)
                {
                    //pullCard(deck[i]);
                }
            }
        }
        
    }
    
}
