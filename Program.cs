using System;
using System.Linq;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext sc = new SchoolContext())
            {
                //sc.Students.Add(new Student()
                //{
                //    StudentID = 1,
                //    StudentName = "阿大",
                //    DateOfBirth =new DateTime(1900,1,1)
                //}) ;
                //sc.Students.Add(new Student()
                //{
                //    StudentID = 2,
                //    StudentName = "阿二",
                //    DateOfBirth = new DateTime(1900, 1, 2)
                //});
                //sc.Students.Add(new Student()
                //{
                //    StudentID = 3,
                //    StudentName = "阿三",
                //    DateOfBirth = new DateTime(1900, 1, 3)
                //});
                //sc.SaveChanges();



                Console.WriteLine("查询学生信息:");
                var searchName = "阿大";
                var query = from b in sc.Students where b.StudentName == searchName
                            select b;
                Console.WriteLine("查询学生信息:");
                foreach (var item in query)
                {
                    //Console.WriteLine("学号{0}，姓名{1}，出生日期{2}",item.StudentID,item.StudentName,item.DateOfBirth);
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}