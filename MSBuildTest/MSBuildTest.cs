using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSBuild;

namespace MSBuildTest
{
    [TestClass]
    public class MSBuildTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("MSBuild Message", Program.CreateMessage());
        }
    }
}
