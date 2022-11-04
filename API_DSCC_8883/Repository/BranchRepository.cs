using API_DSCC_8883.DbContexts;
using API_DSCC_8883.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly AppDbContext _dbContext;
        public BranchRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Branch> GetBranches()
        {
            return _dbContext.Branches.ToList();
        }
    }
}
