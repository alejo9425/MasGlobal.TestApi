using MasGlobal.TestApi.BusinessLogic.Employee;
using MasGlobal.TestApi.DTO.Employee;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MasGlobal.TestApi.WebApi.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string EmployeeId)
        {
            int.TryParse(EmployeeId, out int _EmployeeId);
            List<DTOEmployee> _dto = new BMEmployee().GetEmployees(_EmployeeId);
            return View(_dto);
        }
    }
}
