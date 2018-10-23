using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace RESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RESTService.svc or RESTService.svc.cs at the Solution Explorer and start debugging.
    /// <summary>
    /// Basically this code is developed for HTTP GET, PUT, POST & DELETE operation.
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class RESTSerivce : IRESTSerivce
    {

        List<Employee> objEmployee = new List<Employee>();
        int EmployeeCount = 0;

        public Employee CreateEmployee(Employee createEmployee)
        {
            createEmployee.Id = ++EmployeeCount;
            objEmployee.Add(createEmployee);
            return createEmployee;
        }

        public List<Employee> GetAllEmployee()
        {
            return objEmployee.ToList();
        }

        public Employee GetAEmployee(string id)
        {
            return objEmployee.FirstOrDefault(e => e.Id.Equals(id));
        }

        public Employee UpdateEmployee(string id, Employee updateEmployee)
        {
            Employee p = objEmployee.FirstOrDefault(e => e.Id.Equals(id));
            p.FirstName = updateEmployee.FirstName;
            p.LastName = updateEmployee.LastName;
            p.Department = updateEmployee.Department;
            p.Salary = updateEmployee.Salary;
            return p;
        }

        public void DeleteEmployee(string id)
        {
            objEmployee.RemoveAll(e => e.Id.Equals(id));
        }
    }
}
