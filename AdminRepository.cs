using College.Data;
using College.Models;
using College.Pages.Components;
using College.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace College.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDb _db;


        public AdminRepository(AppDb db)
        {
            _db = db;

        }
        [HttpGet]
        [IgnoreAntiforgeryToken]
        public int login(Administator ad)
        {
            var Admin = _db.admin.FirstOrDefault(u => u.UserName == ad.UserName && u.Password == ad.Password );
            if (Admin != null)
            {
               

                return 1;
            }
            return 0;
       
    }
    }
}
