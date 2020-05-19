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
    public class SetsController : ControllerBase
    {
        private readonly SetsService _ss;

        public SetsController(SetsService ss)
        {
            _ss = ss;
        }
    }
}