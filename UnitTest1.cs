using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MSTestForMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        //Arrangement
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

        [TestMethod]
        public void CheckMoodHappy()
        {
            //Action
            string res = moodAnalyzer.CheckMood("Hrishi is Happy for his new laptop");
            //Assert
            Assert.AreEqual("happy", res);
        }
        [TestMethod]
        public void CheckMoodSad()
        {
            //Action
            string res = moodAnalyzer.CheckMood("Hrishi is Sad after getting bad marks");
            //Assert
            Assert.AreEqual("sad", res);
        }
        [TestMethod]
        public void CheckNullException()
        {
            try
            {
                //Action
                string res = moodAnalyzer.CheckMood(null);
            }
            catch (CustomMoodAnalyzerException mEx)
            {
                //Assert
                Assert.AreEqual(ExceptionType.NULL_VALUE, mEx.extype);
                Assert.AreEqual("message is null", mEx.Message);

            }

        }
        [TestMethod]
        public void CheckEmptyException()
        {
            try
            {
                //Action
                string res = moodAnalyzer.CheckMood("");
            }
            catch (CustomMoodAnalyzerException mEx)
            {
                //Assert
                Assert.AreEqual(ExceptionType.EMPTY_TYPE, mEx.extype);
                Assert.AreEqual("provided message is empty", mEx.Message);

            }

        }

    }
}