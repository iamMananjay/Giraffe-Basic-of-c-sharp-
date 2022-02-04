using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
    class Student
    {
        //class attribute
        public string name;
        public string grade;
        public int gpa;
        //private string rating;
        //constructor
        public Student(string aName , string aGrade, int aGpa)
        {
            name = aName;
            grade = aGrade;
            gpa = aGpa;
            //Rating = aRating;
        }
        //object method

        public bool hasHonor()
        {
            if (gpa >=3) {
                return true;
            }
            return false;
        }

       //------------------------------- getter and setter----------------------------

        /*public string Rating()
        {

            
            get { 
                return rating;
            }
            Set {
                if (value == "A" || value == "B"  || value == "C" || value == "D" || value == "NR") { 
                    rating = value;
                }
                else
                {
                    rating= "NR";
                }
            }
        }*/
    }
}
