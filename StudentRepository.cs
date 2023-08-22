

using College.Data;
using College.Models;
using College.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace College.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDb _db;
       

        public StudentRepository(AppDb db)
        {
            _db = db;

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public StudentModel Create(StudentModel student)
        {
            _db.Add(student);
            _db.SaveChanges();
            return student;
        }
        [HttpDelete]
        public int Delete(int id)
        {
            var studentFind = _db.Student.FirstOrDefault(u => u.Id == id);
            if (studentFind != null)
            {
                _db.Student.Remove(studentFind);
                return _db.SaveChanges();
            }
            return 0;
        }
        [HttpGet]
        public IEnumerable<StudentModel>GetAll()
        {
            List<StudentModel> student = _db.Student.ToList();
            return student;
          
        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public int Update(StudentModel student)
        {
            var studentFind = _db.Student.FirstOrDefault(u => u.Id== student.Id );
            if (studentFind != null)
            {
                studentFind.StudentID = student.StudentID;
                studentFind.StudentName = student.StudentName;
                studentFind.Department = student.Department;
                studentFind.Cgpa = student.Cgpa;
                _db.Student.Update(studentFind);
                _db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}