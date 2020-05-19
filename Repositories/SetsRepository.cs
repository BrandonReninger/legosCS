using System.Data;

namespace legos.Repositories
{
    public class SetsRepository
    {
        private readonly IDbConnection _db;

        public SetsRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}