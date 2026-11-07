using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint2.Task3.V24.Lib;
namespace Tyuiu.KimAV.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = -0.909;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            DataService ds =new DataService();
            double x = -6;
            double res = ds.Calculate(x);
            double wait = -2.333;
            Assert.AreEqual(wait, res);
        }
    }
}
