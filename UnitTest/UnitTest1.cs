using UnionFind;

using Xunit.Abstractions;

namespace UnitTest
{
    public class UnitTest1
    {
        //not sure how to unit test here properly

        QuickFind<int> quickFind = new QuickFind<int>(new List<int> { 5, 1, 3, 4});
        QuickUnion<int> quickUnion = new QuickUnion<int>(new List<int> { 5, 1, 3, 4 });

        [Theory]
        [InlineData(5, 1)]
        public void AreConnected(int p, int q)
        {
            bool isConnect = quickFind.AreConnected(p, q);

            Assert.True(isConnect == true);
        }

        [Theory]
        [InlineData(5, 1)]
        public void Union(int p, int q)
        {
            bool isUnion = quickFind.Union(p, q);

            Assert.True(isUnion == true);
        }

        [Theory]
        [InlineData(5, 1)]
        public void AreConnected1(int p, int q)
        {
            bool isConnect = quickUnion.AreConnected(p, q);

            Assert.True(isConnect == true);
        }

        [Theory]
        [InlineData(5, 1)]
        public void Union1(int p, int q)
        {
            bool isUnion = quickUnion.Union(p, q);

            Assert.True(isUnion == true);
        }
    }
}