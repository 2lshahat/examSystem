using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Exam
    {
      
       
        public DateTime Stopwatch { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject AssociatedSubject { get; set; }
        public void CreateExam()
        {
            // Implementation for creating the exam of the subject
            Console.WriteLine("Please Enter the Type of Exam you want to create(1 for practical and 2 for final) ");
            int typeOfExam = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter the time of exam in minutes");
            int time =int.Parse(Console.ReadLine());
           
            Console.Clear();
            Console.WriteLine("Please enter the numbers of Questions You Wanted To create:");
            int NumOfExam = int.Parse(Console.ReadLine());


            Console.Clear();

            if (typeOfExam == 1)
            {



            }
            else if (typeOfExam == 2)
            {

            }

        }

    }
}
