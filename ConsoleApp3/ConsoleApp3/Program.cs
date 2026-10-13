using ConsoleApp3;
using System.Threading.Tasks.Sources;
using System.Xml;
static void draw(int n, Stack<K> deck, List<K> hand)
{
    for (int i = 0; i < n; i++)
    {
        hand.Add(deck.Pop());
    }
}
static void shuffle(Stack<K> deck)
{
    List<K> bucket = new List<K>();
    Random rnd = new Random();
    while (deck.Count!=0)
    {
        bucket.Add(deck.Pop());
    }
    while (bucket.Count!=0)
    {
        deck.Push(bucket[rnd.Next(0, bucket.Count)]);
        bucket.Remove(deck.Peek());
    }
}
static void show(List<K> hand,List<K> dealer)
{
    string text = "";
    text += "\nyou:\t\t\tdealer:\n";
    for (int i = 0; i < hand.Count; i++)
    {
        switch (i)
        {
            default:
                text += $"{hand[i].suit} {hand[i].number}\n";
                break;
            case 0:
                text += $"{hand[i].suit} {hand[i].number}\t\t";
                text += $"{dealer[i].suit} {dealer[i].number}\n";
                break;
            case 1:
                text += $"{hand[i].suit} {hand[i].number}\t\t";
                text += $"???\n";
                break;
        }
    }
    Console.WriteLine(text);
}
static int score(List<K> hand)
{
    int score = hand.Where(i => int.TryParse(i.number,out _)).Sum(i=>int.Parse(i.number));
    score += hand.Where(i => !int.TryParse(i.number, out _) && i.number != "A").Count() * 10;
    hand.Where(i => i.number == "A").ToList().ForEach(i => score += score + 11 > 21 ? 1 : 11);
    return score;
}
static bool conclude(Stack<K> deck, List<K> hand, List<K> dealer)
{
    string text = "";
    if (score(hand) == 21) return true;
    if (score(hand) > 21) return false;
    if (score(dealer) < 17)
    {
        draw(1, deck, dealer);
    }
    for (int i = 0; i < Math.Max(hand.Count,dealer.Count); i++)
    {
        if (hand.Count>i && dealer.Count>i)
        {
            text += hand[i].suit + " " + hand[i].number + "\t\t" + dealer[i].suit + " " + dealer[i].number + "\n";
        }
        else if (hand.Count>i && !(dealer.Count>i))
        {
            text += hand[i].suit + " " + hand[i].number + "\n";
        }
        else
        {
            text += "\t\t\t" + dealer[i].suit + " " + dealer[i].number + "\n";
        }
    }
    Console.WriteLine($"\nyou:\t\t\tdealer:");
    Console.Write(text);
    Console.WriteLine($"score:\t\t\tscore:\n{score(hand)}\t\t\t{score(dealer)}");
    if (score(dealer)>21)
    {
        return true;
    }
    return score(hand)>score(dealer);
}
Stack<K> d = new Stack<K>();
List<K> hand = new List<K>();
List<K> dealer = new List<K>();
for (int i = 0; i < 4; i++)
{
    for (int j = 1; j < 14; j++)
    {
        d.Push(new K(i, j));
    }
}
while (true)
{
    Console.Clear();
    Console.WriteLine("Blackjack");
    bool game = true;
    bool win = false;
    string act = "";
    hand.ForEach(x => d.Push(x));
    hand.Clear();
    dealer.ForEach(x => d.Push(x));
    dealer.Clear();
    shuffle(d);
    draw(2, d, hand);
    draw(2, d, dealer);
    while (game)
    {
        show(hand, dealer);
        Console.WriteLine("hit/stay?");
        act = Console.ReadLine().ToLower();
        switch (act)
        {
            default:
                break;
            case "hit":
                draw(1, d, hand);
                act = "";
                break;
            case "stay":
                if (conclude(d,hand,dealer))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("nyertél");
                    win = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if(score(hand)==score(dealer))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("döntetlen");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("vesztettél");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                game = false;
                break;
        }
    }
    Console.WriteLine("az újrakezdéshez nyomd meg az entert");
    Console.ReadLine();
    Console.Write("újrakezdés ");
    for (int i = 3; i > 0; i--)
    {
        Console.Write($"{i}.");
        Thread.Sleep(1000);
    }
}
