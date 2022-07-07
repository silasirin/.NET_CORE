using NetCoreFakeRepository.Models.BaseRepository;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreFakeRepository.Models.Data
{
    public class EmployeeData: IEmployeeRepository
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{ID=1, FirstName= "Andrew", LastName="Fuller", Title="CEO"},
            new Employee{ID=1, FirstName= "Nancy", LastName="Davolio", Title="Sales-Representative"},
        };

        public List<Employee> GetEmployees()
        {
            return employees.ToList();
        }

        
    }
}
