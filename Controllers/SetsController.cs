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
    public class SetsController : ControllerBase
    {
        private readonly SetsService _ss;

        public SetsController(SetsService ss)
        {
            _ss = ss;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Set>> GetAll()
        {
            try
            {
                return Ok(_ss.GetAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Set> GetById(int id)
        {
            try
            {
                return Ok(_ss.GetById(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Set> Create([FromBody] Set newSet)
        {
            try
            {
                newSet.Creator = "Brandon";
                return Ok(_ss.Create(newSet));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Set> Delete(int id)
        {
            try
            {
                return Ok(_ss.Delete(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Set> Edit(int id, [FromBody] Set updatedSet)
        {
            try
            {
                return Ok(_ss.Edit(id, updatedSet));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}