using Blackjack.GUI;
using System.ComponentModel.Design.Serialization;
namespace Blackjack.GUI
{
    public partial class Form1 : Form
    {
        static readonly List<K> hand = [];
        static readonly Stack<K> d = new();
        static readonly List<K> dealer = [];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    d.Push(new(i, j));
                }
            }
            Logic.Shuffle(d);
            Logic.Draw(2, d, hand);
            Logic.Draw(2, d, dealer);
            P_hand.Text = "";
            D_score.Text = "???";
            hand.ForEach(i => P_hand.Text += $"{i.suit}{i.number}\r\n");
            D_hand.Text = $"{dealer[0].suit}\t{dealer[0].number}\r\n???";
            P_score.Text = Logic.Score(hand).ToString();
            Result.Text = "";
        }
        private void Hit_button_Click(object sender, EventArgs e)
        {
            Logic.Draw(1, d, hand);
            P_score.Text = Logic.Score(hand).ToString();
            P_hand.Text = "";
            hand.ForEach(i => P_hand.Text += $"{i.suit}{i.number}\r\n");
            if (Logic.Score(hand) > 21)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "vesztettél";
                Stay_button.Visible = false;
                Hit_button.Visible = false;
                NG_button.Visible = true;
            }
        }
        private void Stay_button_Click(object sender, EventArgs e)
        {
            while (Logic.Score(dealer) < 17 && Logic.Score(dealer) < Logic.Score(hand))
            {
                Logic.Draw(1, d, dealer);
            }
            if (Logic.Score(dealer) > Logic.Score(hand) && Logic.Score(dealer) < 22)
            {
                Result.ForeColor = Color.Red;
                Result.Text = "vesztettél";
            }
            else if (Logic.Score(dealer) == Logic.Score(hand))
            {
                Result.ForeColor = Color.Yellow;
                Result.Text = "döntetlen";
            }
            else
            {
                Result.ForeColor = Color.Green;
                Result.Text = "nyertél";
            }
            Result.Location = new((1280 / 2) - (Result.Size.Width / 2), Result.Location.Y);
            D_hand.Text = "";
            dealer.ForEach(i => D_hand.Text += $"{i.suit}{i.number}\r\n");
            D_score.Text = Logic.Score(dealer).ToString();
            Stay_button.Visible = false;
            Hit_button.Visible = false;
            NG_button.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var item in hand)
            {
                d.Push(item);
            }
            foreach (var item in dealer)
            {
                d.Push(item);
            }
            hand.Clear();
            dealer.Clear();
            Logic.Shuffle(d);
            Logic.Draw(2, d, hand);
            Logic.Draw(2, d, dealer);
            P_hand.Text = "";
            D_score.Text = "???";
            hand.ForEach(i => P_hand.Text += $"{i.suit}{i.number}\r\n");
            D_hand.Text = $"{dealer[0].suit}\t{dealer[0].number}\r\n???";
            P_score.Text = Logic.Score(hand).ToString();
            Result.Text = "";
            Stay_button.Visible = true;
            Hit_button.Visible = true;
            NG_button.Visible = false;
        }
    }
}
