using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public  class Exam
    {
        public int NofQuestions { get; set; }
        public int ExamTime { get; set; }
        public int Marks { get; set; }
        public Question[]? Questions { get; set; }

        public void ShowExam()
        {
            Console.WriteLine($"The Number Of Questions is: {NofQuestions} \nThe Exam Time is: {ExamTime}");
            for(int i = 0; i < Questions!.Length; i++)
            {
                string? StAns;
                if (Questions[i].Type == 1)
                {
                    Console.WriteLine($"\n{Questions[i].Header} \t\t\t ({Questions[i].Mark} Marks) ");
                    do
                    {
                        Console.WriteLine($"Q{i + 1}) {Questions[i].Body}{Questions[i].Answers.Ans}");
                        StAns = Console.ReadLine();
                    } while (StAns != "A" && StAns != "B" && StAns != "a" && StAns != "b");

                    if (StAns.ToLower() == Questions[i].ModAns)     Marks += Questions[i].Mark;
                    
                } else if(Questions[i].Type == 2) 
                {
                    Console.WriteLine($"\n{Questions[i].Header} \t\t\t ({Questions[i].Mark} Marks)");

                    do
                    {
                        Console.WriteLine($"Q{i + 1}) {Questions[i].Body}{Questions[i].Answers.Ans}");
                        StAns = Console.ReadLine();
                    } while (!Enum.IsDefined(typeof(MC), StAns));
                    if (StAns?.ToLower() == Questions[i].ModAns)     Marks += Questions[i].Mark;

                } else if (Questions[i].Type == 3) 
                {
                    Console.WriteLine($"\n{Questions[i].Header} \t\t\t ({Questions[i].Mark} Marks)");

                    do
                    {
                        Console.WriteLine($"Q{i + 1}) {Questions[i].Body}{Questions[i].Answers.Ans}");
                        StAns = Console.ReadLine();
                    } while (Checker.MC(StAns));

                    //To Validate that a-d-b == a-b-d
                    if (Checker.TwoStrings(StAns, Questions[i].ModAns)) Marks += Questions[i].Mark;
      
                }
            }
        }
    }
}
