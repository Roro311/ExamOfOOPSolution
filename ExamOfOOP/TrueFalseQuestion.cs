namespace ExamOfOOP
{
    public class TrueFalseQuestion : Question
    {
        public override string Header => "True | False Question";

        public TrueFalseQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");


        }
        public override void AddQuestion()
        {
            // Header 
            Console.WriteLine(Header);
            // Body 

            do
            {
                Console.WriteLine("Enter The Body Of Question");
                Body = Console.ReadLine();


            } while (string.IsNullOrWhiteSpace(Body));

            //Mark 
            int mark;
            do
            {
                Console.WriteLine("Enter the Mark");

            } while (!(int.TryParse(Console.ReadLine(), out mark) && (mark > 0)));

            Mark = mark;
            // Asnwers 

            // RightAnswer

            int userAnswerId;
            do
            {
                Console.WriteLine("Enter The Right Answer (1 for True 2 for false)");


            } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2)));


            RightAnswer.Id = userAnswerId;
            RightAnswer.Text = Answers[userAnswerId - 1].Text;

            Console.Clear();
        }
    }

}
