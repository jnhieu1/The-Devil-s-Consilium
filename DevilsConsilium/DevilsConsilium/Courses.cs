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
        double numOfCredits;
        bool l, mA, cS, hU, sB, sQ, sG, c, g, h;

        public Courses()
        {
        }

        public Courses(string courseNumber, string courseName, string courseDescription, double numOfCredits, bool l, bool mA, bool cS, bool hU, bool sB, bool sQ, bool sG, bool c, bool g, bool h)
        {
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.courseDescription = courseDescription;
            this.numOfCredits = numOfCredits;
            this.l = l;
            this.mA = mA;
            this.cS = cS;
            this.hU = hU;
            this.sB = sB;
            this.sQ = sQ;
            this.sG = sG;
            this.c = c;
            this.g = g;
            this.h = h;
        }

        public string CourseNumber { get => courseNumber; set => courseNumber = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseDescription { get => courseDescription; set => courseDescription = value; }
        public double NumOfCredits { get => numOfCredits; set => numOfCredits = value; }
        public bool L { get => l; set => l = value; }
        public bool MA { get => mA; set => mA = value; }
        public bool CS { get => cS; set => cS = value; }
        public bool HU { get => hU; set => hU = value; }
        public bool SB { get => sB; set => sB = value; }
        public bool SQ { get => sQ; set => sQ = value; }
        public bool SG { get => sG; set => sG = value; }
        public bool C { get => c; set => c = value; }
        public bool G { get => g; set => g = value; }
        public bool H { get => h; set => h = value; }
    }
}
