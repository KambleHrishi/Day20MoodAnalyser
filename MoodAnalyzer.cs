using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public enum Mood
    {
        Happy,
        sad,
    }

    public class MoodAnalyzer
    {
        public string message;

        public MoodAnalyzer()
        {
            this.message = "";
        }

        public MoodAnalyzer(string msg)
        {
            this.message = msg;
        }
        public string CheckMood(string msg)
        {
            //msg : Hrishi is Happy for his new laptop
            //msg : Hrishi is Sad after getting bad marks
            if (msg == null)
            {
                throw new CustomMoodAnalyzerException("message is null", ExceptionType.NULL_VALUE);
            }
            else if (msg.Length < 1)
            {
                throw new CustomMoodAnalyzerException("provided message is empty", ExceptionType.EMPTY_TYPE);
            }

            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            if (msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            return null;
        }
    }
}
