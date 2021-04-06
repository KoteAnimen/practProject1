using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibMethods;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodEvenLastCifra1()
        {
            TaskMethods task = new TaskMethods();            
            Assert.AreEqual(true, task.EvenLastCifra(34));
        }

        [TestMethod]
        public void TestMethodEvenLastCifra2()
        {
            TaskMethods task = new TaskMethods();
            Assert.AreEqual(false, task.EvenLastCifra(35));
        }

        [TestMethod]
        public void TestMethodSummThreeNumbers1()
        {
            TaskMethods task = new TaskMethods();
            int[] numbers = new int[] {6, 6, 6};
            Assert.AreEqual(18, task.SummThreeNumbers(numbers));
        }

        [TestMethod]
        public void TestMethodSummThreeNumbers2()
        {
            TaskMethods task = new TaskMethods();
            int[] numbers = new int[] { 1, 2, 3 };
            Assert.AreEqual(0, task.SummThreeNumbers(numbers));
        }
    }
}
