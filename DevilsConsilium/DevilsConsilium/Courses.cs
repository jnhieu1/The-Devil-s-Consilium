using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilsConsilium
{
    class Courses
    {

        string courseNumber;
        string courseName;
        string courseDescription;
        int numOfCredits;
        bool L, MA, CS, HU, SB, SQ, SG, C, G, H;

        public Courses()
        {
        }

        public Courses(string courseNumber, string courseName, string courseDescription, int numOfCredits, bool l, bool mA, bool cS, bool hU, bool sB, bool sQ, bool sG, bool c, bool g, bool h)
        {
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.courseDescription = courseDescription;
            this.numOfCredits = numOfCredits;
            L = l;
            MA = mA;
            CS = cS;
            HU = hU;
            SB = sB;
            SQ = sQ;
            SG = sG;
            C = c;
            G = g;
            H = h;
        }

        public string CourseNumber { get => courseNumber; set => courseNumber = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseDescription { get => courseDescription; set => courseDescription = value; }
        public int NumOfCredits { get => numOfCredits; set => numOfCredits = value; }
        public bool L1 { get => L; set => L = value; }
        public bool MA1 { get => MA; set => MA = value; }
        public bool CS1 { get => CS; set => CS = value; }
        public bool HU1 { get => HU; set => HU = value; }
        public bool SB1 { get => SB; set => SB = value; }
        public bool SQ1 { get => SQ; set => SQ = value; }
        public bool SG1 { get => SG; set => SG = value; }
        public bool C1 { get => C; set => C = value; }
        public bool G1 { get => G; set => G = value; }
        public bool H1 { get => H; set => H = value; }
    }
}
