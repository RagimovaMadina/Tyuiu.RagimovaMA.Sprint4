using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RagimovaMA.Sprint4.Task1.V10.Lib;

namespace Tyuiu.RagimovaMA.Sprint4.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService resp = new DataService();
            int[] arr = new int[] { 1, 3, 5 };
            Assert.AreEqual(15, resp.Calculate(arr));
        }
    }
}
