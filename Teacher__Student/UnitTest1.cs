using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teacher_Student;

namespace Teacher__Student
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Teacher t1 = new Teacher();
            bool result = t1.teach();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Teacher t1 = new Teacher();
            bool result = t1.teach();
            Assert.AreEqual(false, result);
        }
    }
}
