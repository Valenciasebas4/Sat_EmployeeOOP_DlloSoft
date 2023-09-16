using System;
using System.Collections.Generic;
using System.Text;

namespace Sat_EmployeeOOP_DlloSoft
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;            
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Salario........{GetValueToPay():C2}";
        }

        #endregion
    }
}
