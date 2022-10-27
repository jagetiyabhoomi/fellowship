using MoodAnalyzer;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mood mood = new Mood();
            String expectedOutput1 = "SAD";
            string expectedOutput2 = "HAPPY";

            string actualoutput = mood.Analyser();
            
            Assert.AreEqual(expectedOutput1, actualoutput);
            Assert.AreEqual(expectedOutput2, actualoutput);
        }
    }
}