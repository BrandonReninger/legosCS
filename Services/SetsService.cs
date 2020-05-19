using System;
using System.Collections;
using legos.Repositories;

namespace legos.Services
{
    public class SetsService
    {
        private readonly SetsRepository _repo;

        public SetsService(SetsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable GetAll()
        {
            return _repo.GetAll();
        }
    }
}