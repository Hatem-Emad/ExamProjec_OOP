namespace ExamProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ExamType;
            do
            {
                Console.WriteLine("Choose 1 for Practical Exam and 2 for Final Exam");
                int.TryParse(Console.ReadLine(), out ExamType);
            } while (ExamType != 1 && ExamType != 2);

            Exam exam = new Exam();
            exam.NofQuestions = 6;
            exam.ExamTime = 60;
            exam.Questions = new Question[] {
                new QTorF("Flowers are plants \n", "a"),
                new QTorF("Cats are animale \n", "a"),
                new QCO("Humans live on \n", "A) Moon  B) Earth  C) Sky  D) Mars)", "b"),
                new QCO("pens are for \n", "A) reading  B) singing  C) writing D) dancing", "c"),
                new QMC("We can Eat \n", "A) apples B) bananas C) ourselves D) meat", "a-b-d"),
                new QMC("Where do the lions live \n", "A) zoo - B) cage - C) Sky - D) forest", "a-b-d"),
            };
            exam.ShowExam();

            Console.WriteLine($"=====================================\n" +
                $"===||Your Result is {exam.Marks} out of {exam.Questions.Length * 5}||===" +
                $"\n=====================================");
            if(ExamType== 1)
            {
                Console.WriteLine("\nThe Model Answer is: \n\n" +
                    "Q1) True \nQ2) True \nQ3) B \nQ4) C \nQ5) A-B-D \nQ6) A-B-D ");
            }

        }
    }
}