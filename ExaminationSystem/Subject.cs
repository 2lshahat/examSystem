using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject:Exam
    {
        public Subject(int subId, string subName)
        {
            SubId = subId;
            SubName = subName;
        }

        public  int  SubId { get; set; }
        public string SubName { get; set; }
        public Exam Exam { get; set; }


       
 
           


            
            
            
           



        
    }
}
