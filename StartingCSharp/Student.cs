using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StartingCSharp
{
    public class Student
    {
        public string name, major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name= aName;
            major= aMajor;
            gpa= aGpa;
        }
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }   
        
    }
}
