using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using legos.Models;

namespace legos.Repositories
{
    public class SetsRepository
    {
        private readonly IDbConnection _db;

        public SetsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Set> GetAll()
        {
            string sql = "SELECT * FROM sets";
            return _db.Query<Set>(sql);
        }
    }
}