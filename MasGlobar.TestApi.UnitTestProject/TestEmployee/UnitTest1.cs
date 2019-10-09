
namespace MasGlobar.TestApi.UnitTestProject
{
    using System;
    using System.Collections.Generic;
    using MasGlobal.TestApi.BusinessLogic.Employee;
    using MasGlobal.TestApi.DTO.Employee;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GetEmployees()
        {
            List<DTOEmployee> _dto = new BMEmployee().GetEmployees(null);
            Assert.IsNotNull(_dto);
        }
        [TestMethod]
        public void Test_GetEmployees_Value()
        {
            List<DTOEmployee> _dto = new BMEmployee().GetEmployees(1);
            Assert.IsNotNull(_dto);
        }
    }
}
