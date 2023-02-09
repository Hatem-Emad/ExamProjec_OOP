using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public abstract class Answer
    {
        public abstract string Ans { get; set; }
        
    }
    public class ATorF : Answer
    {
        public override string Ans { get { return " \nA- True, B- False"; }  set {; } }

    }
    public class ACO : Answer
    {
        public override string Ans { get; set; }
        public ACO(string ans)
        {
            Ans = ans;
        }
    }
    public class AMC : Answer
    {
        public override string Ans { get; set; }
        public AMC(string ans)
        {
            Ans = ans;
        }
    }
}
