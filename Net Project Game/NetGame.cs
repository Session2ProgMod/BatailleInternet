using System;
using System.Collections.Generic;
using System.Linq;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using SdlDotNet.Input;
using SdlDotNet.Audio;
using SdlDotNet.Graphics.Sprites;
using System.Drawing;

using static Net_Project_Game.Screen;
using static Net_Project_Game.Game;

namespace Net_Project_Game
{
    partial class NetGame
    {
        private static readonly Random R = new Random();

       
        static void Main(string[] args)
        {
            InitGame();

        }
    }
}
