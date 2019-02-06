using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageAufbaukursCSharp.ServiceImplementations;

namespace SageAufbauKursCSharpTest
{
    [TestClass]
    public class SaveFileUtilsTest
    {
        [TestMethod]
        public void TestSave()
        {
            var mock = new SaveFileUtil();
            mock.Save(null);

        }
    }
}
