using College.Models;

namespace College.Repository.IRepository
{
    public interface IProfessorRepository
    {
        public ProfessorModel Create(ProfessorModel professor);

        public int Update(ProfessorModel professor);

        public int Delete(int id);

        public IEnumerable<ProfessorModel> GetAll();
    }
}
