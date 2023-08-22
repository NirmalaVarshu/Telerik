using College.Models;

namespace College. Repository.IRepository
{
    public interface IStudentRepository
    {
        public StudentModel Create(StudentModel student);

        public int Update(StudentModel student);

        public int Delete(int id);

        public IEnumerable<StudentModel> GetAll();
    }
}
