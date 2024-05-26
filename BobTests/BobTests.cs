using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BobTests
{
    [TestClass]
    public class BobTests
    {
        [TestMethod]
        public void Should_Answer_Question()
        {

            Assert.AreEqual("Sure.", Conversation.Reply("How are you?"));
        }
        [TestMethod]
        public void Should_Reply_To_Nothing()
        {

            Assert.AreEqual("Whatever.", Conversation.Reply(" "));
        }
        [TestMethod]
        public void Should_Reply_Yelling()
        {

            Assert.AreEqual("Stop yelling!", Conversation.Reply("HEY!"));
        }
    }
}
