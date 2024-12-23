using System.Windows;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Window window = new Window();
            window.Show();
            window.Close();
            Assert.IsFalse(window.IsVisible);
        }
    }
}