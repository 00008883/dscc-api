using API_DSCC_8883.DbContexts;
using API_DSCC_8883.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;
        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteEmployee(int employeeId)
        {
            var employee = _dbContext.Employees.Find(employeeId);
            _dbContext.Employees.Remove(employee);
            Save();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            var emp = _dbContext.Employees.Find(employeeId);
            _dbContext.Entry(emp).Reference(e => e.BranchInfo).Load();
            return emp;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _dbContext.Employees.Include(e => e.BranchInfo).ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            Save();
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
