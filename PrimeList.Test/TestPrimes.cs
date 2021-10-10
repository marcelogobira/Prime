using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeList;

namespace PrimeList.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrimes()
        {
            //dotnet test .\PrimeList.Test.csproj
            int[] nullArray = PrimeGenerator.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);
            
            int[] minArray = PrimeGenerator.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);
            
            int[] threeArray = PrimeGenerator.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);
            
            int[] centArray = PrimeGenerator.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);

            // // Tests that we expect to return true.
            // string[] words = { "Alp", "Zea", "ABC", "Ανα", "Мос" };
            // foreach (var word in words)
            // {
            //     bool result = word.Length == 3;
            //     Assert.IsTrue(result,
            //            string.Format("Expected for '{0}': true; Actual: {1}",s
            //                          word, result));
            // }
        }
    }
}
