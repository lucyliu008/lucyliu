using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoinJar;
using System.Collections.Generic;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for CoinJarTest and is intended
    ///to contain all CoinJarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CoinJarTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AddCoin
        ///</summary>
        [TestMethod()]
        public void AddCoinTest()
        {
            CoinJar.CoinJar target = new CoinJar.CoinJar(32f);
            CoinJar.USCurrency currency = new CoinJar.USCurrency();
            Coin coin = null;

            coin = currency.ManufactureCoinOfAmount("AusPenny");
            bool expected = false;
            bool actual;
            actual = target.AddCoin(coin);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void AddCoinTest2()
        {
            CoinJar.CoinJar target = new CoinJar.CoinJar(32f);
            CoinJar.USCurrency currency = new CoinJar.USCurrency();
            Coin coin = null;

            coin = currency.ManufactureCoinOfAmount("USPenny");
            bool expected = true;
            bool actual;
            actual = target.AddCoin(coin);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void AddCoinTest3()
        {
            CoinJar.CoinJar target = new CoinJar.CoinJar(32f);
            CoinJar.USCurrency currency = new CoinJar.USCurrency();
            Coin coin = null;

            coin = currency.ManufactureCoinOfAmount("USQuarter");
            target.UsedVolume = 31.99f;
            bool expected = false;
            bool actual;
            actual = target.AddCoin(coin);
            Assert.AreEqual(expected, actual);

        }
        

        [TestMethod()]
        public void EmptyTest()
        {
            CoinJar.CoinJar target = new CoinJar.CoinJar(32f); 
            
            List<Coin> expected = target.Coins; 
            List<Coin> actual;
            actual = target.Empty();
            Assert.AreEqual(expected, actual);
            
        }
    }
}
