using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.GUI
{
    public class Logic
    {
        public static void Draw(int n, Stack<K> deck, List<K> hand)
        {
            for (int i = 0; i < n; i++)
            {
                hand.Add(deck.Pop());
            }
        }
        public static void Shuffle(Stack<K> deck)
        {
            List<K> bucket = [];
            Random rnd = new();
            while (deck.Count != 0)
            {
                bucket.Add(deck.Pop());
            }
            while (bucket.Count != 0)
            {
                deck.Push(bucket[rnd.Next(0, bucket.Count)]);
                bucket.Remove(deck.Peek());
            }
        }
        public static int Score(List<K> hand)
        {
            int score = hand.Where(i => int.TryParse(i.number, out _)).Sum(i => int.Parse(i.number));
            score += hand.Where(i => !int.TryParse(i.number, out _) && i.number != "A").Count() * 10;
            hand.Where(i => i.number == "A").ToList().ForEach(i => score += score + 11 > 21 ? 1 : 11);
            return score;
        }
    }
}
