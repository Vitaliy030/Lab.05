using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp1.Speech v1 = new ConsoleApp1.Speech();
            string s = "07/09/19";

            int count = 5;
            string[] sr = { "Chariandy", "Gunaratne", "Greengrass", "Williams", "Chingonyi" };
            string[] dt = { "10/11/17", "11/02/18", "06/05/16", "07/09/19", "13/03/20" };
            int[] nm = { 152, 489, 256, 58, 956 };

            string result = v1.Calculate_and_Print(sr, dt, nm, count);
            Assert.AreEqual(s, result);
        }
    }
}
