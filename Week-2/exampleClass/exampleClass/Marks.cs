using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleClass
{
    internal class Marks : Student
    {
        float objectiveMarks;
        float subjectiveMarks;

        public void acceptDetails()
        {
            base.acceptDetails();
            Console.WriteLine("Enter Objective Marks: ");
            objectiveMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subjective Marks: ");
            subjectiveMarks = float.Parse(Console.ReadLine());
        }

        public void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Objective Marks:" + objectiveMarks);
            Console.WriteLine("Subjective Marks:" + subjectiveMarks);
        }
    }
}
