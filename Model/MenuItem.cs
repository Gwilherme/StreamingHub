﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingHub.Pages
{
    internal class MenuItem
    {
        public string Title { get; set; }
        public string Icon { get; set; } 
        public Type TargetPage { get; set; } 
    }
}
