using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleClass
{
    internal class Student
    {
        //Data Members
        int studenId;
        string studentName;

        //Default Constructor
        public Student()
        {
            studenId = 01;
            studentName = "Hugo";
        }

        //Constructor Parametrizado
        public Student(int stId, string stName)
        {
            studenId = stId; 
            studentName = stName;
        }

        public void acceptDetails()
        {
            Console.WriteLine("Enter Student Id: ");
            studenId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            studentName = Console.ReadLine();
        }

        public void displayDetails()
        {
            Console.WriteLine("Student Id:" + studenId);
            Console.WriteLine("Student Name:" + studentName);
        }
    }
}
