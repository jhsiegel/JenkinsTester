using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JenkinsTester.Adders;

namespace JenkinsTester.Tests
{
    [TestFixture]
    public class BasicTests
    {

        public Adder adder;

        [TestFixtureSetUp]
        public void Setup()
        {
            adder = new Adder();
        }

        [Test]
        public void TestAdder()
        {
            int a = 1;
            int b = 2;
            int c = adder.AddNumbers(a,b);
            Assert.AreEqual(3, c);
        }

        [Test]
        public void TestBadAdder()
        {
            int a = 1;
            int b = 2;
            int c = adder.AddNumbersPoorly(a, b);
            Assert.AreEqual(3, c);
        }
    }
}
