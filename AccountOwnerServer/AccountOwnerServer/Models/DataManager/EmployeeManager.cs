using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountOwnerServer.Models.Repository;
using AccountOwnerServer.Models;

namespace AccountOwnerServer.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {


        readonly EmployeeContext _employeeContext;
        public EmployeeManager (EmployeeContext context)
        {
            _employeeContext = context;         }
        public void Add(Employee entity)
        {
             _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            _employeeContext.Employees.Remove(entity);
            _employeeContext.SaveChanges();
        }

        public Employee Get(long ID)
        {
            return _employeeContext.Employees.FirstOrDefault(e => e.EmployeeID == ID);
         }

        public IEnumerable<Employee> GetAll()
        {

            return _employeeContext.Employees.ToList();
        }

        public void update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;
            _employeeContext.SaveChanges();
        }
    }
}
