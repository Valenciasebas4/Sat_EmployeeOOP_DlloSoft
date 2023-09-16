using System;
using System.Collections.Generic;
using System.Text;

namespace Sat_EmployeeOOP_DlloSoft
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Salario Base................{Base:C2}" +
                $"\n\t Salario Total...............{GetValueToPay():C2}";
        }
        #endregion
    }
}
