using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhateverIWant.Core;

namespace WhateverIWant.Abilities
{
    public class DoNothing : Ability
    {
        public DoNothing()
        {
            Name = "None";
            TurnsToRefresh = 0;
            TurnsUntilRefreshed = 0;
        }

        protected override bool PerformAbility()
        {
            Game.MessageLog.Add("There is no ability in that slot!");
            return false;
        }
    }
}
