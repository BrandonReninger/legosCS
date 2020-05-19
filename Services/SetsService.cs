using System;
using System.Collections;
using legos.Models;
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

        internal Set GetById(int id)
        {
            Set foundSet = _repo.GetById(id);
            if (foundSet == null)
            {
                throw new Exception("Bad Id mang!");
            }
            return foundSet;
        }

        internal Set Create(Set newSet)
        {
            Set createdSet = _repo.Create(newSet);
            return createdSet;
        }

        internal Set Delete(int id)
        {
            Set foundSet = _repo.GetById(id);
            if (_repo.Delete(id))
            {
                return foundSet;
            }
            throw new Exception("Uh oh :(");
        }

        internal Set Edit(int id, Set updatedSet)
        {
            Set foundSet = GetById(id);
            foundSet.Name = updatedSet.Name;
            foundSet.Pieces = updatedSet.Pieces;
            return _repo.Edit(foundSet);
        }
    }
}