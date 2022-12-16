using AspNetMvc.Crm.Domain.Entities;
using AspNetMvc.Crm.Domain.Repositories;
using AspNetMvc.Framework.Repository;

namespace AspNetMvc.Crm.EntityFramework.Repositories
{
    public class RequestRepository : BaseRepository<Request, AppDbContext>, IRequestRepository
    {
        private readonly AppDbContext _db;

        public RequestRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

    

    }
}
