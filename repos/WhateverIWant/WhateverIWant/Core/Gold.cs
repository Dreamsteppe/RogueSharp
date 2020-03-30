using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLNET;
using RogueSharp;
using WhateverIWant.Interfaces;

//Gold drops are not yet implemented, just building the gold class atm
namespace WhateverIWant.Core
{
    public class Gold : ITreasure, IDrawable
    {
        public int Amount { get; set; }

        public Gold(int amount)
        {
            Amount = amount;
            Symbol = '$';
            Color = RLColor.Yellow; 
        }

        //boolean to decide whether a pile has been picked up or not. set the value of PickUp to true upon picking up gold, so that the gold can be deleted when PickUp = true;
        public bool PickUp(IActor actor)
        {
            actor.Gold += Amount;
            Game.MessageLog.Add($"{actor.Name} picked up {Amount} gold");
            return true;
        }

        public RLColor Color { get; set; }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void Draw(RLConsole console, IMap map)
        {
            if (!map.IsExplored(X, Y))
            {
                return; 
            }
            if (map.IsInFov(X, Y))
            {
                console.Set(X, Y, Color, Colors.FloorBackgroundFov, Symbol);
            }
            else
            {
                console.Set(X, Y, RLColor.Blend(Color, RLColor.Gray, 0.5f), Colors.FloorBackground, Symbol);
            }
        }
    }
}
