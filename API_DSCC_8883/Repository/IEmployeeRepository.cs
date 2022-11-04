using API_DSCC_8883.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Repository
{
    public interface IEmployeeRepository
    {
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        Employee GetEmployeeById(int Id);
        IEnumerable<Employee> GetEmployees();
    }
}
