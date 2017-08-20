using Microsoft.VisualStudio.TestTools.UnitTesting;
using FF5Saver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF5Saver.Data.Tests
{
    [TestClass()]
    public class EquipmentTests
    {
        [TestMethod()]
        public void EquipmentTest()
        {
            byte[] b = { 0x0D, 0x0D, 0x0D, 0x00, 0x00, 0x0D, 0x0D };
            Equipment e = new Equipment(new ByteReader(b, 0));
            Assert.AreEqual(e.LeftHand, e.RightHand);
        }
    }
}