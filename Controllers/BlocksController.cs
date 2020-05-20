using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using legos.Models;
using legos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace legos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlocksController : ControllerBase
    {
        private readonly BlocksService _bs;
        private SetsService _ss;

        public BlocksController(BlocksService bs, SetsService ss)
        {
            _bs = bs;
            _ss = ss;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Block>> GetAll()
        {
            try
            {
                return Ok(_bs.GetAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}/Sets")]
        public ActionResult<IEnumerable<BlockSetViewModel>> GetSetsByBlockId(int id)
        {
            try
            {
                return Ok(_ss.GetSetsByBlockId(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Block> Create([FromBody] Block newBlock)
        {
            try
            {
                return Ok(_bs.Create(newBlock));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // [HttpDelete("{id}")]
        // public ActionResult<Block> Delete(int id)
        // {
        //     try
        //     {
        //         return Ok(_bs.Delete(id));
        //     }
        //     catch (System.Exception err)
        //     {
        //         return BadRequest(err.Message);
        //     }
        // }
    }
}