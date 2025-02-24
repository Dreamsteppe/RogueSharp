﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLNET;
using RogueSharp;
using WhateverIWant.Interfaces;
using WhateverIWant.Equipment;

namespace WhateverIWant.Core
{
    public class Treasure : IDrawable
    {
        public int Gold { get; set; }
        public Equipment Equipment { get; set; }

        public RLColor Color { get; set; }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Treasure(int x, int y, int gold, Equipment equipment)
        {
            Gold = gold;
            Equipment = equipment;
            Color = RLColor.Yellow;
            Symbol = '$';
            X = x;
            Y = y;
        }

        public void Draw(RLConsole mapConsole, IMap map)
        {
            if (map.IsInFov(X, Y))
            {
                mapConsole.Set(X, Y, Color, null, Symbol);
            }
            else
            {
                mapConsole.Set(X, Y, Colors.Floor, Colors.FloorBackground, '.');
            }
        }
    }
}
