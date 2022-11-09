namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[]args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Console.WriteLine(moodAnalyzer.CheckMood(""));
        }
    }
}
