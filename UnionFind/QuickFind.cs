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

        public QuickFind(List<T> items)
        {
            sets = new int[items.Count];
            map = new Dictionary<T, int>(items.Count);

            for (int i = 0; i < sets.Length; i++)
            {
                map.Add(items[i], i);
                sets[i] = i;
            }
        }

        public int Find(T p) => sets[map[p]];

        public bool Union(T p, T q)
        {
            if (AreConnected(p, q)) return false;

            int pSet = Find(p);
            int qSet = Find(q);

            for (int i = 0; i < sets.Length; i++)
            {
                if (sets[i] == pSet)
                {
                    sets[i] = qSet;
                }
            }

            return true;
        }
        public bool AreConnected(T p, T q)
        {
            if (Find(p).Equals(Find(q))) return true;

            return false;
        }

    }
}
