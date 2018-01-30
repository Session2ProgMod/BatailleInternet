using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static Net_Project_Game.Cards;
using static Net_Project_Game.Sprites;

namespace Net_Project_Game
{
    public class Paquet
    {
      
        public static readonly Random Random = new Random();

        public static List<Cards> CreateNewPaq()
        {
            var newPaq = new List<Cards>();

            for (var s = 0; s < 4; ++s)
            {
                for (var n = 0; n < 13; ++n)
                {
                    newPaq.Add(new Cards()
                    {
                        Name = (Names) n,
                        Suit = (Suits) s,
                        SpriteName = $"{(Names) n}_of_{(Suits) s}",
                        CardValue = n + 1
                    });

                }
            }
            foreach (var c in newPaq)
                {
                    if (c.CardValue > 10)
                    {
                        c.CardValue = 10;
                    }
                }

           ShufflePaq(newPaq);
            return newPaq;
        }


        public static void ShufflePaq(List<Cards> Paq)
        {

            int n = Paq.Count;
            while (n > 1)
            {
                n--;
                int r = Random.Next(n + 1);
                Cards carte = Paq[r];
                Paq[r] = Paq[n];
                Paq[n] = carte;
            }
        }

        public static void DividePackBattle(List<Cards> Paq,List<Cards> P1 ,List<Cards> P2)
        {
            for (int x = 0; x < Paq.Count; x += 2)
            {
                P1.Add(Paq[x]);
                P2.Add(Paq[x+1]);
            }
        }
    }
}
