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
    public class ByteHelperTests
    {
        [TestMethod()]
        public void SliceTest()
        {
            byte[] buff = { 0, 1, 2, 3, 4 };
            byte[] slice = ByteHelper.Slice(buff, 0, 2);
            byte[] shouldBe = { 0, 1 };
            Assert.AreEqual(2, slice.Length);
            Assert.AreEqual(shouldBe[0], slice[0]);
            Assert.AreEqual(shouldBe[1], slice[1]);
        }

        [TestMethod()]
        public void GetWordTest()
        {
            byte[] buff = { 100, 16, 0 };
            Assert.AreEqual(16, ByteHelper.GetWord(buff, 1));
        }

        [TestMethod()]
        public void GetTripleTest()
        {
            byte[] buff = { 0x10, 0x10, 0x10, 255 };
            uint shouldBe = 1052688;
            Assert.AreEqual(shouldBe, ByteHelper.GetTriple(buff, 0));
        }
    }
}