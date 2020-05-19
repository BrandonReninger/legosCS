using System.Data;

namespace legos.Repositories
{
    public class BlocksRepository
    {
        private readonly IDbConnection _db;

        public BlocksRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}