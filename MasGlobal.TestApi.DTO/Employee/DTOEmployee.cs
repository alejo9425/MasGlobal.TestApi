
namespace MasGlobal.TestApi.DTO.Employee
{
    public class DTOEmployee : DTORole
    {

        public int id { set; get; }
        public string name { set; get; }
        public contractType contractTypeName { set; get; }
        public decimal hourlySalary { set; get; }
        public decimal monthlySalary { set; get; }
        public decimal anualSalary { get { return calculeAnnualSalary(); } }


        public DTOEmployee()
        {
        }

        private decimal calculeAnnualSalary()
        {
            if (this.contractTypeName.Equals(contractType.HourlySalaryEmployee))
                return (120 * this.hourlySalary * 12);
            else
                return (this.monthlySalary * 12);
        }

        public enum contractType
        {
            HourlySalaryEmployee = 1,
            MonthlySalaryEmployee = 2
        }
    }


}
