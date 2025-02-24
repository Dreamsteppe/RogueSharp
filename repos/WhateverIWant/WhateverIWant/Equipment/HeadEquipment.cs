﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhateverIWant.Equipment
{
    public class HeadEquipment : Core.Equipment
    {
        public static HeadEquipment None()
        {
            return new HeadEquipment { Name = "None" };
        }

        public static HeadEquipment Leather()
        {
            return new HeadEquipment()
            {
                Defense = 1,
                DefenseChance = 5,
                Name = "Leather"
            };
        }

        public static HeadEquipment Chain()
        {
            return new HeadEquipment()
            {
                Defense = 1,
                DefenseChance = 10,
                Name = "Chain"
            };
        }

        public static HeadEquipment Plate()
        {
            return new HeadEquipment()
            {
                Defense = 1,
                DefenseChance = 15,
                Name = "Plate"
            };
        }
    }
}
