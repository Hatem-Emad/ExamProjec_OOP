using System;
using System.Collections;
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
        public static bool MC(string str) 
        {
            string[] Strarr = str.Split("-"); 
            
            if (!(Strarr.Length > 1)) return true;      //Enter at leaset 2 choices

            foreach (var i in Strarr) { if (!Enum.IsDefined(typeof(MC), i)) return true; }      //Every choice must be enum

            MC[] MCarr = new MC[Strarr.Length];         //Cant choose 2 similars i.e: A-a or A-A (not valid)
            for (int i = 0; i < Strarr.Length; i++) { MCarr[i] = (MC)Enum.Parse(typeof(MC), Strarr[i]); }
            for (int i = 0; i < MCarr.Length; i++)      //Checking if a == A in array of Enum is easier than array of string
            {
                for (int j = i + 1; j < MCarr.Length; j++) { if (MCarr[i] == MCarr[j]) return true; }
            }

            return false;
        }

        public static bool TwoStrings(string str1, string str2)
        {
            str1 = str1.ToLower();
            string[] str1Arr = str1.Split("-");
            Array.Sort(str1Arr);

            str2 = str2.ToLower();
            string[] str2Arr = str2.Split("-");
            Array.Sort(str2Arr);

            return str1Arr.SequenceEqual(str2Arr);

            //if (StAns.CompareTo(Questions[i].ModAns) == 0) Marks += 5;
            //if (String.Compare(StAns, Questions[i].ModAns) == 0) Marks += 5;
            //if (StAns.SequenceEqual(Questions[i].ModAns)) Marks += 5;
            //if (StAnsArr == ModAnsArr)  Marks += 5;

        }
    }
}
