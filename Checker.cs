using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    enum MC
    {
        A = 0, a = 0, B = 1, b = 1, C = 2, c = 2, D = 3, d = 3
    }
    static public class Checker
    {
        public static bool MC(string str) //str = a-b
        {
            string[] Strarr = str.Split("-"); 
            //strarr = [a,b] 
            if (!(Strarr.Length > 1)) return true;      //Enter at leaset 2 choices

            foreach (var i in Strarr) { if (!Enum.IsDefined(typeof(MC), i)) return true; }      //Every choice must be enum

            MC[] MCarr = new MC[Strarr.Length];         //Cant choose 2 similars i.e: A-a or A-A (not valid)
            for (int i = 0; i < Strarr.Length; i++) { MCarr[i] = (MC)Enum.Parse(typeof(MC), Strarr[i]); }
            for (int i = 0; i < MCarr.Length; i++)
            {
                for (int j = i + 1; j < MCarr.Length; j++) { if (MCarr[i] == MCarr[j]) return true; }
            }

            return false;
        }
    }
}
