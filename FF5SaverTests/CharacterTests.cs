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
    public class CharacterTests
    {
        [TestMethod()]
        public void CharacterTest()
        {
            byte[] characterData = { 0x00, 0x15, 0x01, 0x00, 0x00, 0x00, 0x24, 0x00, 0x24, 0x00, 0x05, 0x00, 0x05, 0x00, 0x80 };
            Character guy = new Character(characterData);
            Assert.AreEqual(36, guy.MaxHP);
            Assert.AreEqual(36, guy.CurrentHP);
            Assert.AreEqual(5, guy.MaxMP);
            Assert.AreEqual(1, guy.Level);
        }
    }
}