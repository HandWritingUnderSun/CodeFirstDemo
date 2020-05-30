using System.Data.Entity;

namespace CodeFirstDemo
{
    public class SchoolContext:DbContext
    {
        //构造函数
        public SchoolContext() : base("name=NewContext")
        {
        }
        //每个类设置一个的DbSet属性
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Grade> Grades { get; set; }
    }
}
