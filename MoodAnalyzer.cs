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
            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
