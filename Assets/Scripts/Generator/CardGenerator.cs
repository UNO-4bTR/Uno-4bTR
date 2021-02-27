using System;
using System.Collections.Generic;

using Assets.Scripts.Cards.Colored;
using Assets.Scripts.Cards.Wildcard;
using Assets.Scripts.Cards.Colored.Ability;

namespace Assets.Scripts.Generator
{
    
    public class CardGenerator
    {
        
        public dynamic Generate() //Usage Broj = CardGen.CardGenerator.generate()
        {
            List<int> drawnCards = new List<int>();        //Vec povucene karte
            Random rnd = new Random();
            int randomNum = rnd.Next(108);
            switch (randomNum)
            {
                case int n when n >= 0 && n < 19:     //Crveni 0-9
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new NumberedCard(Color.Red, n % 10);
                    }
                    else Generate();
                    break;
                case int n when n >= 19 && n < 38:    //Zuti 0-9 
                    if (!drawnCards.Contains(n))
                    {
                        if (n != 30)
                        {
                            drawnCards.Add(n);
                            return new NumberedCard(Color.Yellow, n % 10);
                        }

                        drawnCards.Add(n);
                        return new NumberedCard(Color.Yellow, 8);
                    }
                    else Generate();
                    break;
                case int n when n >= 38 && n < 57:    //Zeleni 0-9
                    if (!drawnCards.Contains(n))
                    {
                        if (n != 50)
                        {
                            drawnCards.Add(n);
                            return new NumberedCard(Color.Green, n % 10);
                        }

                        drawnCards.Add(n);
                        return new NumberedCard(Color.Green, 7);
                    }
                    else Generate();
                    break;
                case int n when n >= 57 && n < 76:    //Plavi 0-9
                    if (!drawnCards.Contains(n))
                    {
                        if (n != 70)
                        {
                            drawnCards.Add(n);
                            return new NumberedCard(Color.Blue, n % 10);
                        }

                        drawnCards.Add(n);
                        return new NumberedCard(Color.Blue, 6);
                    }
                    else Generate();
                    break;

                case int n when n >= 76 && n < 80:    //Wild color-change
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new WildcardCard(WildcardType.Normal);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 80 && n < 84:    //Wild draw-four
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new WildcardCard(WildcardType.Draw4);
                    }
                    else
                    {
                        Generate();
                    }
                    break;

                case int n when n >= 84 && n < 86:    //Draw2 Crveni
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Red, AbilityType.Draw2);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 86 && n < 88:    //Draw2 Zuti
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Yellow, AbilityType.Draw2);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 88 && n < 90:    //Draw2 Plavi
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Blue, AbilityType.Draw2);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 90 && n < 92:    //Draw2 Zeleni
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Green, AbilityType.Draw2);
                    }
                    else
                    {
                        Generate();
                    }
                    break;

                case int n when n >= 92 && n < 94:    //Skip Crveni
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Red, AbilityType.Skip);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 94 && n < 96:    //Skip Zuti
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Yellow, AbilityType.Skip);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 96 && n < 98:    //Skip Plavi
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Blue, AbilityType.Skip);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 98 && n < 100:    //Skip Zeleni
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Green, AbilityType.Skip);
                    }
                    else
                    {
                        Generate();
                    }
                    break;

                case int n when n >= 100 && n < 102:    //Reverse Crveni
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Red, AbilityType.Reverse);
                    } 
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 102 && n < 104:    //Reverse Zuti
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Yellow, AbilityType.Reverse);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 104 && n < 106:    //Reverse Plavi
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Blue, AbilityType.Reverse);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                case int n when n >= 106 && n < 0x6C:    //Reverse Zeleni
                    if (!drawnCards.Contains(n))
                    {
                        drawnCards.Add(n);
                        return new AbilityCard(Color.Green, AbilityType.Reverse);
                    }
                    else
                    {
                        Generate();
                    }
                    break;
                default:
                    Generate();
                    break;
            }
            return new NumberedCard(Color.Blue, 0); //Cisto tu da program valja.
        }
        
    }
    
}
