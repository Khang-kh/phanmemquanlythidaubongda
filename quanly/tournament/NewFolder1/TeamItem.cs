﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly.tournament.NewFolder1
{
    internal class TeamItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString() => Text;
    }
}
