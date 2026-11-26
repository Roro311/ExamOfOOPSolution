using System.Diagnostics;

namespace ExamOfOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Math");
            subject.CreateExam();
            Console.Clear();

            char character;
            do
            {
                Console.WriteLine("Do you want to retake the exam? (Y/N)");
            } while (!(char.TryParse(Console.ReadLine().ToLower(), out character) && (character== 'y' || character == 'n')));

            if (character == 'y')
            {
                Console.Clear();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.Exam.ShowExam();
                stopwatch.Stop();
                Console.WriteLine($"Time of Exam: {stopwatch.Elapsed}");

            }

        }
    }
}
