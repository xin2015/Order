using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Insertion : OrderBase
    {
        public override void Sort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0 && Less(a[j], a[j - 1]); j--)
                {
                    Exch(a, j, j - 1);
                }
            }
        }
    }
}
