﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownMonitor
{
    public sealed class Sample
    {
        private DateTime dateTime = DateTime.Now;

        public long Downstream { get; private set; }

        public long Upstream { get; private set; }

        public DateTime DateTime { get { return dateTime; } }

        public Sample(long downstream, long upstream)
        {
            Downstream = downstream;
            Upstream = upstream;
        }

        public static Sample operator -(Sample a, Sample b)
        {
            return new Sample(a.Downstream - b.Downstream, a.Upstream - b.Upstream);
        }

        public long Max
        {
            get { return Math.Max(Downstream, Upstream); }
        }
    }

}
