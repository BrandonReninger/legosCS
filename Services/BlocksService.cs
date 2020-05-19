using legos.Repositories;

namespace legos.Services
{
    public class BlocksService
    {
        private readonly BlocksRepository _repo;

        public BlocksService(BlocksRepository repo)
        {
            _repo = repo;
        }
    }
}