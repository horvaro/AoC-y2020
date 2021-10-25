using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day0x05
{
    public class BSPHelper //Binary Space Partitioning
    {
        public static int Partition(string input, char lower, char upper, int max)
        {
            var min = 0;

            foreach (var ch in input.ToCharArray())
            {
                var range = max - min + 1;

                if (ch.Equals(lower))
                {
                    max -= (range / 2);
                }
                else if (ch.Equals(upper))
                {
                    min += (range / 2);
                }
            }

            int pos;
            if (min == max)
            {
                pos = min;
            }
            else
            {
                pos = max - ((max - min) / 2);
            }

            return pos;
        }
    }
}
