using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_StringBuilder__Class
{
    internal class Student
    {
        public string Name;
        public string SurName;
        public byte Group;
        public int Point;
        public bool IsGraduated;


        public Student(string name, string surname)
        {
            Name = name;
            SurName = surname;
            //Console.WriteLine("Name and Surname: " +Name + SurName);

        }

        public Student(string name, string surname, byte group, byte point, bool isgraduated)
        {
            Name = name;
            SurName = surname;
            Group = group;
            Point = point;
            IsGraduated = isgraduated;

            Console.WriteLine("Name: " + Name + " Surname: " + SurName + " Group: " + Group + " Point: " + Point + " Is Graduated:");

        }

        public void Graduated()
        {
            if (IsGraduated)
            {
                Console.WriteLine("This student has graduated");
            }
            else
            {
                Console.WriteLine("This student hasn't graduated");

            }
        }
        public void Points()
        {
            if (Point > 80)
            {
                Console.WriteLine("Congratulations:) See you next exam");
            }
            else
            {
                Console.WriteLine("Unlucky:( You will come next year.");

            }
        }
        //public void NameAndSurname()
        //{ 
        
        //}

    }
 }

