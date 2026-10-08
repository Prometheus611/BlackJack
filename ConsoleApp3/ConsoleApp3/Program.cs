using ConsoleApp3;
using System.Threading.Tasks.Sources;
using System.Xml;
static void draw(int n,Stack<K> deck, List<K> hand)
{
    for (int i = 0; i < n; i++)
    {
        hand.Add(deck.Pop());
    }
}
static void shuffle(Stack<K> deck)
{
    List<K> bucket = new List<K>();
    int len = deck.Count;
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        bucket.Add(deck.Pop());
    }
    while (deck.Count()!=len)
    {
        int index = rnd.Next(0, len - deck.Count);
        deck.Push(bucket[index]);
        bucket.Remove(bucket[index]);
    }
}
static void show(List<K> hand,List<K> dealer)
{
    string text = "";
    text += "you:\t\t\tdealer:\n";
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
    int score = 0;
    int len = hand.Count;
    int result = new int();
    for (int i = 0; i < len-1; i++)
    {
        K bucket = new K(-1,0);
        if (hand[i].number=="A")
        {
            bucket = hand[i];
            hand[i+1]= bucket;
            hand[i] = hand[i+1];
        }
    }
    foreach (var card in hand)
    {

        if (int.TryParse(card.number, out result))
        {
            score += result;
        }
        else if (card.number=="A")
        {
            score += 11;
        }
        else if (card.number=="a")
        {
            score += 1;
        }
        else
        {
            score += 10;
        }
        Console.WriteLine(card.number + " " + score);
    }
    Console.WriteLine();
    while (score>21)
    {
        if (hand.Any(i=>i.number=="A"))
        {
            score -= 10;
        }
        else
        {
            break;
        }
    }
    Console.WriteLine(score+"\n");
    return score;
}
Stack<K> d = new Stack<K>();
List<K> hand = new List<K>();
List<K> dealer = new List<K>();
for (int i = 0; i < 30; i++)
{
    for (int j = 1; j < 3; j++)
    {
        d.Push(new K(i, j));
    }
}
while (true)
{
    Console.WriteLine("Blackjack");
    bool game = true;
    bool win = false;
    string act = "";
    shuffle(d);
    draw(2, d, hand);
    draw(2, d, dealer);
    while (game)
    {
        //show(hand, dealer);
        score(hand);
        Console.WriteLine("hit/stay?");
        act = Console.ReadLine().ToLower();
        switch (act)
        {
            default:
                break;
            case "hit":
                draw(1, d, hand);
                foreach (var item in hand)
                {
                    Console.WriteLine(item.number);
                }
                Console.WriteLine();
                act = "";
                break;
            case "stay":
                break;
        }
    }
}
