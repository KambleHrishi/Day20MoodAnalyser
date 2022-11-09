using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public enum Mood
        {
            Happy,
            sad
        }
        public string CheckMood(string msg)
        {
            //msg : Hrishi is Happy for his new laptop
            //msg : Hrishi is Sad after getting bad marks
            if (msg == null)
            {
                throw new CustomMoodAnalyzerException("message is null", ExceptionType.NULL_VALUE);
            }

            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            else if (msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            else if (msg.Contains("null", StringComparison.OrdinalIgnoreCase))
            {
                return "Happy";
            }
            else
            {
                return null;
            }
        }
    }
}
