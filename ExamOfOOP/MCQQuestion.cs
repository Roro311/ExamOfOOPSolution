namespace ExamOfOOP
{
    public class MCQQuestion : Question
    {
        public override string Header => "MCQ Question";
        public MCQQuestion()
        {
            Answers = new Answer[3];
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

            //Asnwers 
            for (int i = 0; i < Answers.Length; i++)
            {
                //Id -  Text 
                Answers[i] = new Answer() { Id = i + 1 };

                do
                {
                    Console.WriteLine($"Enter The Choice Number  {i + 1}");
                    Answers[i].Text = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(Answers[i].Text));
            }


            int userAnswerId;
            do
            {
                Console.WriteLine("Enter The Right Answer (1 or 2 or 3)");


            } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));


            RightAnswer.Id = userAnswerId;
            RightAnswer.Text = Answers[userAnswerId - 1].Text;

            Console.Clear();
        }
    }
}
