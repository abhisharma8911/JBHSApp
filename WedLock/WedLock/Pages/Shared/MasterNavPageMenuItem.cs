﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WedLock.Pages.Shared
{

    public class MasterNavPageMenuItem
    {
        public MasterNavPageMenuItem()
        {
            TargetType = typeof(MasterNavPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}