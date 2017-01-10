using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }
    }

    class Pair<T> : Pair<T, T>
    {
        public Pair(T first, T second) : base(first, second)
        {
        }
    }

    class Util
    {
        public static T Max<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) > 0) return a;
            return b;
        }
    }
}
