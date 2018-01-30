using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.IO;

namespace Net_Project_Game
{
    //2_of_clubs.png
   public enum Suits
    {
        hearts,
        clubs,
        diamonds,
        spades,
    }

    public enum Names
    {
        ace,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,

    }
    public class Cards
    {
        public Suits Suit { get; set; }
        public Names Name { get; set; }
        public int CardValue { get; set; }
        public string SpriteName { get; set; }
    }
}
