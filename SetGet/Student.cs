using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGet
{
    class Stu
    {
        private string name;
        private int age;
        private float gpa;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age not be -ve or Zero");
                }
            }
            get
            {
                return age;
            }
        }

        public float GPA
        {
            set
            {
                if(value < 0 || value > 4)
                {
                    Console.WriteLine("Invalid GPA");
                }
                else
                {
                    gpa = value;
                }
            }
            get
            {
                return gpa;
            }
        }

        public string AcademicStatus
        {
            get
            {
                if(gpa == 3.0 || gpa < 3.0)
                {
                    return "Good";
                }
                else
                {
                    return "Need Improvement";
                }
            }
        }
    }
    internal class Student
    {
        static void Main(string[] args)
        {
            Stu s = new Stu();
            s.Name = "Sharad";
            s.Age = 24;
            s.GPA = -2.0f;
            string status = s.AcademicStatus;

            Console.WriteLine("Status is {0}",status);

        }
    }
}
