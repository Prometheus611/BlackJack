using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class K
    {
        public string suit, number;
        public K(int s,int n)
        {
            switch (s)
            {
                case 0:
                    this.suit = "spade  ";
                    break;
                case 1:
                    this.suit = "club   ";
                    break;
                case 2:
                    this.suit = "diamond";
                    break;
                case 3:
                    this.suit = "heart  ";
                    break;
                default:
                    this.suit = "n/a    ";
                    break;
            }
            switch (n)
            {
                default:
                    this.number = n.ToString();
                    break;
                case 1:
                    this.number = "A";
                    break;
                case 11:
                    this.number = "J";
                    break;
                case 12:
                    this.number = "Q";
                    break;
                case 13:
                    this.number = "K";
                    break;
            }

        }
    }
}
