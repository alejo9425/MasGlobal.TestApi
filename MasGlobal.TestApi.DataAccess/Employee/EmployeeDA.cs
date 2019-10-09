
namespace MasGlobal.TestApi.DataAccess.Employee
{
    using MasGlobal.TestApi.DataAccess.Api;
    using MasGlobal.TestApi.DTO.Employee;
    using System.Collections.Generic;

    public class EmployeeDA
    {
        public List<DTOEmployee> GetEmployees()
        {
            return new ClientApi().GetEmployees();
        }
    }
}
