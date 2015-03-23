using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalletProject23031993;

namespace WalletProject23031993Test
{
    [TestClass]
    public class WalletTest
    {
        //za runat test->Test/Run/All Tests in Solution
    
        [TestMethod]
        public void TestEmptyWalletReturnsZero()
        {
            var wallet = new Wallet();

            Assert.AreEqual(
                0,
                wallet.GetCurrencyValue("HRK"),
                "empty wallet should return Zero"
                // što nam treba vratit; s čim se uspoređuje; poruka u slučaju rezultata različita od 0.

            );
        }

        [TestMethod]
        public void TestSingleIOtemWalletGetCurrency()
        {
            var wallet = new Wallet();

            wallet.AddCurrencyValue("HRK", 100);
            
            Assert.AreEqual(
                100,
                wallet.GetCurrencyValue("HRK"),
                "single item wallet bla bla"
                );
        }

        //svaka metoda koju zelimo testirat mora ima prije [TestMethod]
        [TestMethod]
        public void TestMultipleSameCurrencyWalletGetCurrency()
        {
            var wallet = new Wallet();

            wallet.AddCurrencyValue("HRK", 100);
            wallet.AddCurrencyValue("HRK", 50);

            Assert.AreEqual(
                150,
                wallet.GetCurrencyValue("HRK"),
                "multiple item wallet bla bla"
                );
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]  //da metoda očekiva exeption i da se dobro ponaša samo ako dođe do tog exeptiona
        public void TestAddCurrencyCrashesIfFormatLengthInvalid()
        {
            var wallet = new Wallet();

            wallet.AddCurrencyValue("hrk", 100);
        }

       
    }
}
