using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateTests
{
    [TestClass]
    public class UnitTest1
    {
        private Operations _operation;
        [TestInitialize]
        public void Init()
        {
            _operation = new Operations();
        }



        [TestMethod]
        public void ToplamaKontrol()
        {
            Assert.AreEqual(10, _operation.Sum(5, 5));
        }
        [TestMethod]
        public void BolmeBirElemanSifirAlsinKontrol()
        {
            Assert.AreEqual(0, _operation.Divide(12, 0));
        }
        
        //negatif sayının çarpımı ile oluşacak çıktının negatiflik kontrolü
        [TestMethod]
        public void NegatifSonucAlma()
        {
            Assert.AreEqual(true, _operation.IsMultiplicationLessThanZero(-34, 23));
        }

        [TestCleanup]
        public void Dispose()
        {
            _operation = null;
        }
    }

    public class Operations
    {
        public int Sum(int x, int y)
        {
            return x+y;
        }
        public int Divide(int x, int y)
        {
            if (x == 0 || y == 0)
                return 0;
            else
                return x / y;
        }
        public bool IsMultiplicationLessThanZero(int x, int y)
        {
            if (x < 0 || y < 0)
                return true;
            else
                return false;
        }
    }
}
