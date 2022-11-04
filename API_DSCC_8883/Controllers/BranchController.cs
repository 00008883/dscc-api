using API_DSCC_8883.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_DSCC_8883.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepository _branchRepository;
        public BranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }
        // GET: api/<BranchController>
        [HttpGet]
        public IActionResult Get()
        {
            var branches = _branchRepository.GetBranches();
            return new OkObjectResult(branches);
            //return new string[] { "value1", "value2" };
        }
    }
}
