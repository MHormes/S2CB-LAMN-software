﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.DataClasses
{
    class Holiday
    {
        public string WeekNmr { get; set; }
        public string EmpBSN { get; set; }
        public Day FreeDay { get; set; }
        public bool Approved { get; set;}

        public Holiday(string weekNmr, string empBSN, Day freeDay, bool approved)
        {
            WeekNmr = weekNmr;
            EmpBSN = empBSN;
            FreeDay = freeDay;
            Approved = approved;
        }
    }
}
