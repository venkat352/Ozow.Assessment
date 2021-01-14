using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ozow.UnitTest
{
    [TestClass]
    public class given_context_when_executing_ozow_assessment
    {
        [TestMethod]
        public void AlphabaticOrderTestMethod()
        {
            var expectedOutput = "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy";
            var inputString = "Contrary to popular belief, the pink unicorn flies east.";

            var outPut = Ozow.Assessment.Program.AlphabaticOrder(inputString);

            Assert.AreEqual(expectedOutput, outPut);
        }
    }
}
