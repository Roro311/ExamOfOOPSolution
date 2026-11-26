namespace ExamOfOOP
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public void CreateExam()
        {
            int examType, time, numberOfQuestions;

            do
            {
                Console.WriteLine("Enter the Exam Type (1 For Practical 2 For Final)");


            } while (!(int.TryParse(Console.ReadLine(), out examType) && (examType is 1 or 2)));

            do
            {
                Console.WriteLine("Enter the Time From 30 To 180 Minutes ");


            } while (!(int.TryParse(Console.ReadLine(), out time) && (time >= 30 && time <= 180)));

            do
            {
                Console.WriteLine("Enter the number of Questions ");


            } while (!(int.TryParse(Console.ReadLine(), out numberOfQuestions) && numberOfQuestions > 0));

            if (examType == 1)
            {
                Exam = new PracticalExam(time, numberOfQuestions);
                Exam.CreateQuestion();
            }
            else
            {
                Exam = new FinalExam(time, numberOfQuestions);
                Exam.CreateQuestion();
            }
            Console.Clear();
        }
    }
}
