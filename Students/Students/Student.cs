using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /*
    Author: Damjan Miloshevski
    E-mail: contact@damjanmiloshevski.mk, d.miloshevski@gmail.com
    Web: http://damjanmiloshevski.mk
    Skype: damjan.milosevski
    LinkedIn: https://mk.linkedin.com/in/damjanmiloshevski
    GitHub: https://github.com/damsii
  */
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Index { get; set; }
        public List<Subject> Subjects { get; set; }
        public double Average { get; set; }
        public int numSubjects = 0;

        public Student()
        {
            //default ctor
            Subjects = new List<Subject>(numSubjects);
        }
        public Student(string name, string lastName, string index)
        {
            Name = name;
            LastName = lastName;
            Index = index;
            Average = 0;
            Subjects = new List<Subject>(numSubjects);
        }
       public void addSubjects(int numSubjects) {
            Random rGrade = new Random();

            for (int i = 1; i <= numSubjects; ++i) {
                int index = i;
                int grade = rGrade.Next(6, 11);
                Subjects.Add(new Subject(string.Format("Предмет {0}",index),grade));
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}",LastName,Name,Index);
        }
    }
}
