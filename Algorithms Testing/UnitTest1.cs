using Microsoft.VisualStudio.TestTools.UnitTesting;
using Introduction_to_Algorithms;

namespace Algorithms_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            

            int[] testArray = { 1, 2, 3, 4, 5 };
            Assert.IsTrue( SortTools.IsSorted(Sorts.InsertionSort(new int[] { 5, 4, 3, 2, 1 }) ));
            
        }
    }
}
