using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    public class QuickUnion<T>
    {
        private int[] sets;
        private Dictionary<T, int> map;

        public QuickUnion(List<T> items)
        {
            sets = new int[items.Count];
            map = new Dictionary<T, int>(items.Count);

            for (int i = 0; i < sets.Length; i++)
            {
                map.Add(items[i], i);
                sets[i] = i;
            }
        }

        public int Find(T p)
        {
            int i = map[p];

            while (sets[i] != i)
            {
                i = sets[i];
            }

            return i;
        }
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
