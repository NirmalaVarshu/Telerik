using College.Data;
using College.Models;
using College.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace College.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly AppDb _db;


        public ProfessorRepository(AppDb db)
        {
            _db = db;

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ProfessorModel Create(ProfessorModel professor)
        {
            _db.Add(professor);
            _db.SaveChanges();
            return professor;
        }
        [HttpDelete]
        public int Delete(int id)
        {
            var professor = _db.Professors.FirstOrDefault(u => u.Id == id);
            if (professor != null)
            {
                _db.Professors.Remove(professor);
                return _db.SaveChanges();
            }
            return 0;
        }
        [HttpGet]
        public IEnumerable<ProfessorModel> GetAll()
        {
            List<ProfessorModel> professors = _db.Professors.ToList();
            return professors;

        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public int Update(ProfessorModel professor)
        {
            var professorModel = _db.Professors.FirstOrDefault(u => u.Id == professor.Id);
            if (professorModel != null)
            {
                professorModel.ProfessorID = professor.ProfessorID;
                professorModel.ProfessorName = professor.ProfessorName;
                professorModel.Department = professor.Department;
                professorModel.Age = professor.Age;
                professorModel.YOE = professor.YOE;
                professorModel.ProfessorEmail = professor.ProfessorEmail;
                professorModel.ProfessorPhone = professor.ProfessorPhone;
                _db.Professors.Update(professorModel);
                _db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}
