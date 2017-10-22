using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Коровы;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string expected = "1 корова";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 11;
            string expected = "11 коров";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod111()
        {
            int n = 111;
            string expected = "111 коров";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 2;
            string expected = "2 коровы";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestMethod5()
        {
            int n = 5;
            string expected = "5 коров";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TestMethod4()
        {
            int n = 4;
            string expected = "4 коровы";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod3()
        {
            int n = 3;
            string expected = "3 коровы";


            string actual = Program.CowConter(n);



            Assert.AreEqual(expected, actual);
        }
    }
}
