
namespace MasGlobal.TestApi.BusinessLogic.Employee
{
    using MasGlobal.TestApi.DataAccess.Employee;
    using MasGlobal.TestApi.DTO.Employee;
    using System.Collections.Generic;
    using System.Linq;
    using static MasGlobal.TestApi.DTO.Employee.DTOEmployee;

    public class BMEmployee
    {
        public List<DTOEmployee> GetEmployees(int? _id)
        {
            List<DTOEmployee> _employees = new EmployeeDA().GetEmployees();
            if (_id != null && _id != 0)
                _employees = _employees.Where(em => em.id == _id).ToList();
            return _employees;
        }

    }
}
