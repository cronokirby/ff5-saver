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
    public class ByteReaderTests
    {

        [TestMethod()]
        public void ByteReaderTest()
        {
            byte[] buff = { 0, 16, 0, 16, 0, 0 };
            var reader = new ByteReader(buff, 0);
            byte b = reader.Byte();
            byte bShouldBe = 0;
            ushort w = reader.Word();
            ushort wShouldBe = 16;
            Assert.AreEqual(b, bShouldBe);
            Assert.AreEqual(w, wShouldBe);
            Assert.AreEqual(wShouldBe, reader.Triple());
        }


        [TestMethod()]
        public void SkipTest()
        {
            byte[] buff = { 0, 16, 0 };
            var r1 = new ByteReader(buff, 0);
            r1.Skip(1);
            var r2 = new ByteReader(buff, 1);
            Assert.AreEqual(r1.Word(), r2.Word());
        }
    }
}