namespace _5.Hands_of_cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ////You are given a sequence of people and for every person what cards he draws from the deck.The input will be separate lines in the format:
            ////{ personName}: { PT, PT, PT,… PT} Pesho: 2C, 4H, 9H, AS, QS
            //// Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type.The input ends when a "JOKER" is drawn.The name can contain any ASCII symbol except ':'.The input will always be valid and in the format described, there is no need to check it.
            //// A single person cannot have more than one card with the same power and type, if he draws such a card he discards it.The people are playing with multiple decks.Each card has a value that is calculated by the power multiplied by the type.Powers 2 to 10 have the same value and J to A are 11 to 14.Types are mapped to multipliers the following way(S-> 4, H-> 3, D-> 2, C-> 1).
            //// Finally print out the total value each player has in his hand in the format:
            ////{ personName}: { value}
            List<string> peopleHandStart = Console.ReadLine()
                                             .Split(':')
                                             .ToList();
            Dictionary<string, int> peopleHandsValue = new Dictionary<string, int>();
            Dictionary<string, List<string>> peopleHands = new Dictionary<string, List<string>>();
            char[] separators = { ' ', ',' };

            while (!peopleHandStart[0].Equals("JOKER"))
            {
                string peopleName = peopleHandStart[0];
                List<string> peopleCards = peopleHandStart[1]
                                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                                            .Distinct()
                                            .ToList();
                if (peopleHands.ContainsKey(peopleName))
                {
                    peopleCards.InsertRange(0, peopleHands[peopleName]);
                    peopleCards = peopleCards.Distinct().ToList();
                }

                peopleHands[peopleName] = peopleCards;
                peopleHandStart = Console.ReadLine()
                                             .Split(':')
                                             .ToList();
            }

            foreach (var pair in peopleHands)
            {
                int value = CalculateHandValue(pair.Key, pair.Value);
                Console.WriteLine($"{pair.Key}: {value}");
            }
        }

        private static int CalculateHandValue(string peopleName, List<string> peopleCards)
        {
            Dictionary<string, int> cardType = new Dictionary<string, int>()
            {
                {"S", 4}, {"H", 3}, {"D", 2}, {"C", 1}
            };
            Dictionary<string, int> cardPower = new Dictionary<string, int>()
            {
                {"1",1}, {"2",2}, {"3",3}, {"4",4}, {"5",5}, {"6",6}, {"7",7},
                {"8",8}, {"9",9}, {"10",10}, {"J",11}, {"Q",12}, {"K",13}, {"A",14}
            };
            int handValue = 0;
            foreach (var card in peopleCards)
            {
                //card to type and power  PT
                string type = card.Substring(card.Length - 1, 1);
                string power = card.Substring(0, card.Length - 1);
                //cardType[type]*cardPower[power]= value card
                int currentValue = cardType[type] * cardPower[power];
                //add to handValue
                handValue += currentValue;
            }

            return handValue;
        }
    }
}
