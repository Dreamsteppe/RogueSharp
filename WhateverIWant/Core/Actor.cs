using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhateverIWant.Interfaces;
using RogueSharp;
using RLNET;

namespace WhateverIWant.Core
{
    public class Actor: IActor, IDrawable
    {
        //IActor
        public string Name { get; set; }
        public int Awareness { get; set; }

        //IDrawable
        public RLColor Color { get; set; }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        
        public void Draw(RLConsole console, IMap map)
        {
            //dont draw actors in cells that haven't been explored yet
            if (!map.GetCell(X, Y).IsExplored)
            {
                return;
            }

            //Only draw the actor with the color and symbol when they are in the field-of-view
            if(map.IsInFov(X, Y))
            {
                console.Set(X, Y, Color, Colors.FloorBackgroundFov, Symbol);
            }
            else
            {
                //when not in FOV, just draw a normal floor
                console.Set(X, Y, Colors.Floor, Colors.FloorBackground, '.');
            }
        }
    }
}
