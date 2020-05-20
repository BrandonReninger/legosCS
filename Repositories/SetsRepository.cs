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

        internal Set GetById(int id)
        {
            string sql = "SELECT * FROM sets WHERE id = @Id";
            return _db.QueryFirstOrDefault<Set>(sql, new { id });
        }

        internal Set Create(Set newSet)
        {
            string sql = @"
            INSERT INTO sets
            (name, pieces, creator)
            VALUES
            (@Name, @Pieces, @Creator);
            SELECT LAST_INSERT_ID()";
            newSet.Id = _db.ExecuteScalar<int>(sql, newSet);
            return newSet;
        }

        //NOTE keep bool as bool!
        internal bool Delete(int id)
        {
            string sql = "DELETE FROM sets WHERE id = @Id LIMIT 1";
            int affectedRows = _db.Execute(sql, new { id });
            return affectedRows == 1;
        }

        internal Set Edit(Set setToUpdate)
        {
            string sql = @"
            UPDATE sets 
            SET
            name = @Name,
            pieces = @Pieces
            WHERE id = @Id LIMIT 1";
            _db.Execute(sql, setToUpdate);
            return setToUpdate;
        }

        internal IEnumerable<BlockSetViewModel> GetSetsByBlockId(int blockId)
        {
            string sql = @"
            SELECT 
            s.*
            b.shape AS block,
            bs.id AS BlockSetId
            FROM blocksets bs
            INNER JOIN sets s ON s.id = bs.setId
            INNER JOIN blocks b ON b.id = bs.blockId
            WHERE blockId = @blockId";
            return _db.Query<BlockSetViewModel>(sql, new { blockId });
        }
    }
}