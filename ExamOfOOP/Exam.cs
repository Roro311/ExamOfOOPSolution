namespace ExamOfOOP
{
    public abstract class Exam 
    {
        public int TimeOfExam { get; set; }         
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam(int timeOfExam , int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void CreateQuestion();
        public abstract void ShowExam();
        
    }
}