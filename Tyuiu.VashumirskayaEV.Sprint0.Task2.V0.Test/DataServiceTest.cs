using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VashumirskayaEV.Sprint0.Task2.V0.Lib;


namespace Tyuiu.VashumirskayaEV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheakGetMessageValid()
        {
            var name = "Елизавета";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Елизавета", res);
        }
    }
}
