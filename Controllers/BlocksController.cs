using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using legos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace legos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlocksController : ControllerBase
    {
        private readonly BlocksService _bs;

        public BlocksController(BlocksService bs)
        {
            _bs = bs;
        }
    }
}