namespace ExamOfOOP
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }
        public override void CreateQuestion()
        {
            Questions = new Question[NumberOfQuestions];
            int typeOfQuestion;
            for (int i = 0; i < Questions.Length; i++)
            {

                do
                {
                    Console.WriteLine("Enter Type Of Question (1 for MCQ 2 For TF)");

                } while (!(int.TryParse(Console.ReadLine(), out typeOfQuestion) && (typeOfQuestion is 1 or 2)));

                if (typeOfQuestion is 1)
                {
                    Questions[i] = new MCQQuestion();
                    Questions[i].AddQuestion();
                }
                else
                {
                    Questions[i] = new TrueFalseQuestion();
                    Questions[i].AddQuestion();
                }
            }
            Console.Clear();
        }
        

        public override void ShowExam()
        {
            //Question 
            foreach (var question in Questions)
            {
                Console.WriteLine(question);

                for (int i = 0; i < question.Answers.Length; i++)
                {
                    Console.WriteLine(question.Answers[i]);
                }
                int userAnswerId;

                // Take Value From User 
                if (question.GetType() == typeof(MCQQuestion))
                {

                    do
                    {
                        Console.WriteLine("Enter The Answer (1 or 2 or 3)");


                    } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));

                    question.UserAnswer.Id = userAnswerId;
                    question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;

                }

                else
                {

                    do
                    {
                        Console.WriteLine("Enter The Answer (1 or 2 )");


                    } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2)));

                    question.UserAnswer.Id = userAnswerId;
                    question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;
                }


            }
            Console.Clear();

            //Grade

            int grade = 0, totalMarks = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                totalMarks += Questions[i].Mark;
                if (Questions[i].UserAnswer.Id == Questions[i].RightAnswer.Id)
                {
                    grade += Questions[i].Mark;
                }
                Console.WriteLine($"Question {i + 1} : {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {Questions[i].UserAnswer.Text}");
                Console.WriteLine($"Right Answer => {Questions[i].RightAnswer.Text}");


            }


            Console.WriteLine($"Your Grade is {grade} / {totalMarks}");
        
    }
    }
}
