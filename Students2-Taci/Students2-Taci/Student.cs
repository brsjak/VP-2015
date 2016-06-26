using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2_Taci
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Index { get; set; }
        public List<Subject> Subjects { get; set; }
   

        public Student(string name, string surname, int index)
        {
            Name = name;
            Surname = surname;
            Index = index;
            Subjects = new List<Subject>();
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}",Name,Surname, Index);
        }
        public int examsPassed() {
            int count = 0;
            foreach (object obj in Subjects) {
                Subject subject = obj as Subject;
                if (subject.Grade > 5) count++;
            }
            return count;
        }
        public void generateFile(int subjects) {
            Subjects = new List<Subject>(subjects);
            Random rand = new Random();
            for (int i = 1; i <=subjects; i++) {
                Subjects.Add(new Subject("Предмет " + i, rand.Next(5, 11)));
            }
        }
        public double avg() {
            double sum = 0;
            foreach (object obj in Subjects) {
                Subject sbj = obj as Subject;
                sum += sbj.Grade;
            }
            return sum / Subjects.Count;
        }
    }
}
