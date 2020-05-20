using System;
using System.Collections;
using System.Collections.Generic;
using legos.Controllers;
using legos.Models;
using legos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace legos.Services
{
    public class BlocksService
    {
        private readonly BlocksRepository _repo;

        public BlocksService(BlocksRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable GetAll()
        {
            return _repo.GetAll();
        }

        internal Block GetById(int id)
        {
            Block foundBlock = _repo.GetById(id);
            if (foundBlock == null)
            {
                throw new Exception("Bad Id bruh.");
            }
            return foundBlock;
        }

        internal object Create(Block newBlock)
        {
            Block createdBlock = _repo.Create(newBlock);
            return createdBlock;
        }

        // internal Block Delete(int id)
        // {
        //     Block foundBlock = _repo.GetById(id);
        //     if (_repo.Delete(id))
        //     {
        //         return foundBlock;
        //     }
        //     throw new Exception("Wrong Id");
        // }
    }
}