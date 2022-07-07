using System.Collections.Generic;

namespace NetCoreFakeRepository.Models.BaseRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
