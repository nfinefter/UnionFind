namespace UnitTest
{
    public class UnitTest1
    {
        //Make Quickfind in here

        [Theory]
        [InlineData(5, 1)]
        public void AreConnected(int p, int q)
        {
            bool isConnect = AreConnected(p, q);


            Assert.True(isConnect == true);
        }
    }
}