using System;
using System.Collections.Generic;
using System.Linq;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using SdlDotNet.Input;
using SdlDotNet.Audio;
using SdlDotNet.Graphics.Sprites;
using System.Drawing;
using Net_Project_Game;


namespace Net_Project_Game
{
    public class Game
    {
        internal static void InitGame()
        {
           //Screen.ScreenInit();
            List<Cards> PackShuffled = Paquet.CreateNewPaq();

            List<Cards> P1 = new List<Cards>();
            List<Cards> P2= new List<Cards>();
            List<Cards> D1 = new List<Cards>();
            List<Cards> D2 = new List<Cards>();
            Paquet.DividePackBattle(PackShuffled,P1,P2);
            Console.WriteLine(P1.Count);
            TopCardVS(P1,P2,D1,D2);
            TopCardVS(P1, P2, D1, D2);
            Console.WriteLine(P1.Count);
            foreach (var c in D1)
            {
                Console.Write($"{c.SpriteName} ,");
            }
            foreach (var c in D2)
            {
                Console.Write($"{c.SpriteName} ,");
            }
        }

        private static void TopCardVS(List<Cards> P1, List<Cards> P2, List<Cards> D1, List<Cards> D2)
        {

           // basic game for test purposes // set project to console in meanwhile
            if (P1[0].CardValue > P2[0].CardValue) // top vs top P1 wins
            {

                D1.Add(P2[0]);   //add to discard 1 P2 1st card
                P2.Remove(P2[0]); //remove the moved one

                D1.Add(P1[0]);  // add his own to his discard
                P1.Remove(P1[0]); // remove mvode

            }
            else if (P1[0].CardValue < P2[0].CardValue) // p2 win
            {
                D2.Add(P1[0]);
                D2.Add(P2[0]);

                 P1.Remove(P1[0]);
                P2.Remove(P2[0]);
            }
            else
            {
                D1.Add(P1[0]);
                D2.Add(P2[0]);
                P1.Remove(P1[0]);
                P2.Remove(P2[0]);
            }
        }
    }
}
