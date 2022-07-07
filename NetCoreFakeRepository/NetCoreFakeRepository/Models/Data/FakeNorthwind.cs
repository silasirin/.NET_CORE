using NetCoreFakeRepository.Models.BaseRepository;
using System.Collections.Generic;

namespace NetCoreFakeRepository.Models.Data
{
    public class FakeNorthwind : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>
        {
            new Employee{ID=1,FirstName="Mahmure",LastName="Okan",Title="Developer"},
            new Employee{ID=1,FirstName="Sila",LastName="Sirin",Title="Developer"}
        };
        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }
    }
}
