using System;
using System.Collections.Generic;
using System.Linq;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using SdlDotNet.Input;
using SdlDotNet.Audio;
using SdlDotNet.Graphics.Sprites;
using System.Drawing;
using static Net_Project_Game.NetGame;


namespace Net_Project_Game
{
   public class Screen
    {
        //Screen Surface
        private static Surface _screen;

        // Screen Edges Variables
        private const int ScreenWidth = 1024;
        private const int ScreenHeight = 768;
        private const int ScreenTop = 0;
        private const int ScreenBottom = ScreenHeight;


        internal static void ScreenInit()

        {
            _screen = Video.SetVideoMode(ScreenWidth, ScreenHeight, 32, false, false, false, true);
        }
    }
}
