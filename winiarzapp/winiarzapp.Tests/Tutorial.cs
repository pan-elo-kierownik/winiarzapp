using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


/*         
    Test > Run > All tests
*/

namespace winiarzapp.Tests
{
    //TODO: Usunąć w końcowej wersji kodu.
    [TestClass]
    public class Tutorial
    {
        /// <summary>
        /// Przykładowy test. Sprawdza czy 1 + 2 równa się 3. W ten sposób będą wyglądały wszystkie automatyczne testy.
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            // Przygotuj
            int a = 1;
            int b = 2;

            // Wykonaj
            int result = a + b;

            // Sprawdź
            Assert.IsTrue(result == 3);
        }

        /// <summary>
        /// Test sprawdzający, czy metoda rzuca wyjątek.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void Test2()
        {
            throw new NotImplementedException();
        }

        //TODO: Testerzy, w tym projekcie (Winiarzapp.Tests) powinny pojawić się testy automatyczne. 

    }
}
