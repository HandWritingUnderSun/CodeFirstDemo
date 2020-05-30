using System;
using System.Text;

namespace CodeFirstDemo
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }


        public override string ToString()
        {
            return new StringBuilder("学号："+ this.StudentID+"，姓名："+ this.StudentName + "!").ToString();
        }
    }

    
}
