using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhateverIWant.Interfaces;

namespace WhateverIWant.Interfaces
{
    public interface ITreasure
    {
        bool PickUp(IActor actor);
    }
}
