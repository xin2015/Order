using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Selection : OrderBase
    {
        public override void Sort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Less(a[j], a[min]))
                    {
                        min = j;
                    }
                }
                Exch(a, i, min);
            }
        }
    }
}
