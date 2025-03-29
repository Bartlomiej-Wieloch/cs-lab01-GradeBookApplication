using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("At least 5 students required");
            }

            int higherGradesCount = 0;
            foreach (var student in Students)
            {
                if (student.AverageGrade > averageGrade)
                {
                    higherGradesCount++;
                }
            }
            double rangPercent = (double)higherGradesCount / Students.Count;

            if (rangPercent < 0.2)
            {
                return 'A';
            }
            else if (rangPercent < 0.4)
            {
                return 'B';
            }
            else if (rangPercent < 0.6)
            {
                return 'C';
            }
            else if (rangPercent < 0.8)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            } 
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }  
        }
    }
}
