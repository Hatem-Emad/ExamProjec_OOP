using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public abstract class Question
    {
        public int Mark { get { return 5; } }
        public abstract string Header { get; }
        public abstract string Body { get; set; }
        public abstract string ModAns { get; set; }
        public abstract Answer Answers { get; set; }
        public abstract int Type { get; set; }
    }
    public class QTorF : Question
    {
        public override string Header { get { return "Write A for True or B for False\n"; } }
        public override Answer Answers { get { return new ATorF(); } set {; } }
        public override string Body { get; set; }
        public override string ModAns { get; set; }
        public override int Type { get { return 1; }  set {; } }
        public QTorF(string body, string mdAns)
        {
            Body = body;
            ModAns = mdAns;
        }
    }
    public class QCO : Question
    {
        public override string Header { get { return "Choose A B C or D\n"; } }
        public override Answer Answers { get; set; }
        public override string ModAns { get; set; }
        public override string Body { get; set; }
        public override int Type { get { return 2; } set {; } }
        public QCO(string body, string ans, string mdAns)
        {
            Body = body;
            Answers = new ACO(ans);
            ModAns = mdAns;
        }
    }
    public class QMC : Question
    {
        public override string Header { get { return "Choose A-B or A-B-C or A-B-D or B-C-D ..etc \n"; } }
        public override Answer Answers { get; set; }
        public override string ModAns { get; set; }
        public override string Body { get; set; }
        public override int Type { get { return 3; }  set {; } }
        public QMC(string body, string ans, string mdAns)
        {
            Body = body;
            Answers = new AMC(ans);
            ModAns = mdAns;
        }
    }
}
