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

        [TestMethod]
        public void RejectionMaxMass1()
        {
            TaskMethods task = new TaskMethods();
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 4, 3, 2, 1, 0 };
            int max;
            int[] reject;
            task.RejectionMaxMass(numbers, out max, out reject);
            Assert.AreEqual(5, max);
            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], reject[i]);
            }
            
        }

        [TestMethod]
        public void RejectionMaxMass2()
        {
            TaskMethods task = new TaskMethods();
            int[] numbers = new int[] { 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 0, 1, 2, 3, 4 };
            int max;
            int[] reject;
            task.RejectionMaxMass(numbers, out max, out reject);
            Assert.AreEqual(5, max);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], reject[i]);
            }
        }

        [TestMethod]
        public void ExchangeMaxMinRows1()
        {
            TaskMethods task = new TaskMethods();

            double[,] table = new double[,] { {0, 1, 2, 3 }, { -1, 3, 6, 3 }, {10, 7, 5, 6 } };
            double[,] changedTable;
            double[,] expected = new double[,] { { 0, 1, 2, 3 }, { 10, 7, 5, 6 }, { -1, 3, 6, 3 } };
            
            task.ExchangeMaxMinRows(table, out changedTable);
            for(int i = 0; i < table.GetLength(0); i++)
            {
                for(int j = 0; j < table.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], changedTable[i, j]);
                }
            }
            
        }

    }
}
