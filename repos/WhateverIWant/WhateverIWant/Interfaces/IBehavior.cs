using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhateverIWant.Core;
using WhateverIWant.Monsters;
using WhateverIWant.Systems;

namespace WhateverIWant.Interfaces
{
    public interface IBehavior
    {
        bool Act(Monster monster, CommandSystem commandSystem);
    }
}
