using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class GPA_calculator
    {
        float totalScale = 0;
        byte totalCreditHours = 0;

        float lastScale = 0;
        byte lastCreditHours = 0;

        public string tGPAString = "Enter you total GPA";
        public string tCHString = "Enter your total credit hours";

        public string GradeFromMark(string Mark)
        {
            try
            {
                byte myMark = byte.Parse((Mark == "") ? "0" : Mark);
                return (myMark >= 97) ? "A+" : (myMark >= 93) ? "A" : (myMark >= 89) ? "A-" : (myMark >= 84) ? "B+" :
                       (myMark >= 80) ? "B" : (myMark >= 76) ? "B-" : (myMark >= 73) ? "C+" : (myMark >= 70) ? "C" :
                       (myMark >= 67) ? "C-" : (myMark >= 64) ? "D+" : (myMark >= 60) ? "D" : "F";
            }
            catch (Exception)
            {
                GPADesign.display = false;
                return "";
            }
        }

        public float ScaleFromGrade(string grade)
        {
            try
            {
                switch (grade)
                {
                    case "A+": return 4;
                    case "A": return 4;
                    case "A-": return 3.7f;
                    case "B+": return 3.3f;
                    case "B": return 3;
                    case "B-": return 2.7f;
                    case "C+": return 2.3f;
                    case "C": return 2;
                    case "C-": return 1.7f;
                    case "D+": return 1.3f;
                    case "D": return 1;
                    case "F": return 0;
                }
            }
            catch (Exception)
            {
                GPADesign.display = false;
            }
            return 0;
        }

        public void AddToScale(string scale, string creditHours)
        {
            try
            {
                float myScale = ScaleFromGrade((scale == "") ? "0" : scale);
                byte myCreditHours = byte.Parse((creditHours == "") ? "0" : creditHours);
                if (myScale < 0 || myScale > 4)
                    GPADesign.display = false;
                else
                {
                    totalCreditHours += myCreditHours;
                    totalScale += (myScale * myCreditHours);
                }
            }
            catch (Exception)
            {
                GPADesign.display = false;
            }
        }

        public void AddLastgpa(string gpa, string creditHours)
        {
            try
            {
                float mygpa = float.Parse(((gpa == tGPAString) ? "0" : gpa), System.Globalization.CultureInfo.InvariantCulture);
                float myCreditHours = float.Parse(((creditHours == tCHString) ? "0" : creditHours), System.Globalization.CultureInfo.InvariantCulture);
                if (mygpa < 0 || mygpa > 4)
                    GPADesign.display = false;
                else
                {
                    lastScale += (mygpa * myCreditHours);
                    lastCreditHours += (byte)myCreditHours;
                }
            }
            catch (Exception)
            {
                GPADesign.display = false;    
            }
        }

        public float GetCumulativeGPA()
        {
            try
            {
                float GPA = (totalScale + lastScale) / (totalCreditHours + lastCreditHours);
                GPA *= 100;
                GPA = (float)Math.Round(GPA);
                GPA /= 100;
                return GPA;
            }
            catch (Exception)
            {
                GPADesign.display = false;
                return 0;                
            }
        }

        public float GetSemesterGPA()
        {
            try
            {
                if (totalCreditHours == 0)
                    return 0;
                float GPA = totalScale / totalCreditHours;
                GPA *= 100;
                GPA = (float)Math.Round(GPA);
                GPA /= 100;
                return GPA;
            }
            catch (Exception)
            {
                GPADesign.display = false;
                return 0;
            }
        }

    }
}
