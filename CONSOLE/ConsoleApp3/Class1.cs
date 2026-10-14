using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class K(int s, int n)
    {
        public string suit = s switch
        {
            0 => "spade  ",
            1 => "club   ",
            2 => "diamond",
            3 => "heart  ",
            _ => "n/a    "
        };
        public string number = n switch
        {
            1 => "A",
            11 => "J",
            12 => "Q",
            13 => "K",
            _ => n.ToString(),
        };
    }
}
