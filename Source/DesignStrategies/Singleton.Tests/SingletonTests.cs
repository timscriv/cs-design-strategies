using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonComplex_MultipleCreateInstance_AllInstancesAreEqual()
        {
            //Laziness is enforced
            SingletonComplex.SayHi();
            Console.WriteLine("Starting test");
            SingletonComplex s1 = SingletonComplex.Instance;
            SingletonComplex s2 = SingletonComplex.Instance;

            Assert.AreSame(s1, s2);
        }
        [TestMethod]
        public void SingletonSimple_MultipleCreateInstance_AllInstancesAreEqual()
        {
            //Lazieness doesn't really matter
            SingletonSimple.SayHi();
            Console.WriteLine("Starting test");
            SingletonSimple s1 = SingletonSimple.Instance;
            SingletonSimple s2 = SingletonSimple.Instance;

            Assert.AreSame(s1, s2);
        }
    }
}
