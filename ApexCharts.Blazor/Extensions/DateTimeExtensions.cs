using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class DateTimeExtensions
    {
        const int microDivisor = 10000;
        const decimal epochTicks = 2208988800000;

        public static decimal ToUnixTicks(this DateTime d)
        {
            var ticks = d.Ticks;
            var microTicks = ticks / microDivisor;
            return microTicks - epochTicks;
        }
    }
}
