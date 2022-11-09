namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[]args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Console.WriteLine(moodAnalyzer.CheckMood("Hrishi is Happy for his new laptop"));
        }
    }
}
