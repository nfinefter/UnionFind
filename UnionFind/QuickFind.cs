using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    public class QuickFind<T>
    {
        private int[] sets;
        private Dictionary<T, int> map;

        public QuickFind(IEnumerable<T> items)
        {

        }

        public int Find(T p) => sets[map[p]];

        public bool Union(T p, T q)
        {
            if (AreConnected(p, q)) return false;

            sets[map[q]] = sets[map[p]];

            return true;
        }
        public bool AreConnected(T p, T q)
        {
            if (Find(p).Equals(Find(q))) return true;

            return false;
        }

    }
}
