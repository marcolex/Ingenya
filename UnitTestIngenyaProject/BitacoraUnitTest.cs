using Ingenya.ApiCore;
using Ingenya.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace UnitTestIngenyaProject
{
    [TestClass]
    public class BitacoraUnitTest
    {

        [TestMethod]
        public void TodasLasBitacoras()
        {
            BitacoraManagement bitacoraManagement = new BitacoraManagement();
            var path = bitacoraManagement.RetrieveAllBitacora();
            int x = path.Count;
            Assert.IsTrue(x < 0);
        }
    }
}
