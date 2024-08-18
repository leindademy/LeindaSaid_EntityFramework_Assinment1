using LeindaSaid_EntityFramework_Assinment1.context;
using LeindaSaid_EntityFramework_Assinment1.Entity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LeindaSaid_EntityFramework_Assinment1
{
    internal class Program
    {

        static void Main(string[] args)
        {


            #region Course
            using (var db = new Student_Database_Context())
            {
                Course course1 = new Course();
                course1.Name = "Programming";
                course1.Duration = 5;
                course1.TopId = 1;
                course1.Description = "learning a programming language";
                db.Courses.Add(course1);
                db.SaveChanges();
            }

            using (var db = new Student_Database_Context())
            {
                Course course2 = new Course();
                course2.Name = "PHP";
                course2.TopId = 1;
                course2.Duration = 15;
                course2.Description = "Learning a PHP language";
                db.Courses.Add(course2);
                db.SaveChanges();
            }
            #endregion

            #region Department
            using (var db = new Student_Database_Context())
            {
                Department dept = new Department();
                dept.Name = "Html";
                dept.HiringDate = DateTime.Now;
                dept.Instructors = new List<Instructor>();
                dept.Students = new List<Student>();
                db.Departments.Add(dept);
                db.SaveChanges();
            }

            using (var db = new Student_Database_Context())
            {
                Department dept2 = new Department();
                dept2.Name = "Instructor";
                dept2.HiringDate = DateTime.Now;
                dept2.Students = new List<Student>();
                dept2.Instructors = new List<Instructor>();
                db.Departments.Add(dept2);
                db.SaveChanges();
            }
            #endregion

            #region Instructor
            using (var db = new Student_Database_Context())
            {
                Instructor instructor1 = new Instructor();
                instructor1.deptId = 1;
                instructor1.Name = "leinda";
                instructor1.Bouns = 2000;
                instructor1.salary = 10000;
                instructor1.Address = "Cairo";
                instructor1.Hourrate = 200;
                db.Instructors.Add(instructor1);
                db.SaveChanges();
            }

            using (var db = new Student_Database_Context())
            {
                Instructor instructor2 = new Instructor();
                instructor2.deptId = 2;
                instructor2.Name = "Mona";
                instructor2.Bouns = 1000;
                instructor2.salary = 12000;
                instructor2.Address = "Ras-sudr";
                instructor2.Hourrate = 220;
                db.Instructors.Add(instructor2);
                db.SaveChanges();
            }

            #endregion

            #region Instructor-Course

            using (var db = new Student_Database_Context())
            {
                Instructor_Course ins_crs = new Instructor_Course();
                ins_crs.InstructorId = 1;
                ins_crs.CourseId = 2;
                ins_crs.Evaluation = 90;
                db.Instructor_Courses.Add(ins_crs);
                db.SaveChanges();
            }

            #endregion

            #region Stud-Course

            using (var db = new Student_Database_Context())
            {
                Stud_Course Std_crs = new Stud_Course();
                Std_crs.Stud_ID = 1;
                Std_crs.Course_ID = 2;
                Std_crs.grade = 90;
                db.Stud_Courses.Add(Std_crs);
                db.SaveChanges();
            }

            #endregion

            #region Student

            using (var db = new Student_Database_Context())
            {
                Student Student1 = new Student();
                Student1.FirstName = "sara";
                Student1.LastName = "ahmed";
                Student1.deptId = 1;
                Student1.Age = 20;
                db.Students.Add(Student1);
                db.SaveChanges();
            }

            using (var db = new Student_Database_Context())
            {
                Student student2 = new Student();
                student2.FirstName = "ALI";
                student2.LastName = "Ahmed";
                student2.deptId = 2;
                student2.Age = 20;
                student2.Address = "Alex";
                db.Students.Add(student2);
                db.SaveChanges();
            }
            #endregion

            #region Topic
            using (var db = new Student_Database_Context())
            {
                Topic X = new Topic();
                X.Name = "C++";
                db.Topics.Add(X);
                db.SaveChanges();
            }

            using (var db = new Student_Database_Context())
            {
                Topic x = new Topic();
                x.Name = "CSS";
                db.Topics.Add(x);
                db.SaveChanges();
            }
            #endregion




            //Delete --> Course
            using (var db = new Student_Database_Context())
            {
                Course Crs = db.Courses.Find(1);
                db.Courses.Remove(Crs);
                db.SaveChanges();
            }

            //Delete --> Stud-Courses
            using (var db = new Student_Database_Context())
            {
                Stud_Course Stud_Crs = db.Stud_Courses.Find(1);
                db.Stud_Courses.Remove(Stud_Crs);
                db.SaveChanges();
            }

            //Delete --> Instructor-Courses
            using (var db = new Student_Database_Context())
            {
                Instructor_Course Ins_Crs = db.Instructor_Courses.Find(1);
                db.Instructor_Courses.Remove(Ins_Crs);
                db.SaveChanges();
            }
            // Update --> Student
            using (var db = new Student_Database_Context())
            {
                Instructor Ins = db.Instructors.Find(1);
                Ins.Name = "said";
                db.SaveChanges();
            }

            // Delete --> Student
            using (var db = new Student_Database_Context())
            {
                Student Stu = db.Students.Find(1);
                db.Students.Remove(Stu);
                db.SaveChanges();
            }


        }
    }

}
