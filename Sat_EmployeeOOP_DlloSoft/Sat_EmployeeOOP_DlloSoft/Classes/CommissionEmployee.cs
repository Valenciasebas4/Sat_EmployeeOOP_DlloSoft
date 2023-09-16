using System;
using System.Collections.Generic;
using System.Text;

namespace Sat_EmployeeOOP_DlloSoft
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ConvertPercentage(CommissionPercentage);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Porcentaje de Comisiòn......{ConvertPercentage(CommissionPercentage):P2}" +
                $"\n\t Ventas...................{Sales:C2}" +
                $"\n\t Salario...............{GetValueToPay():C2} \n\t" +
                $"------------------------------------";
        }

        public float ConvertPercentage(float commissionPercentage) {
            return (commissionPercentage/100);
        }
        #endregion
    }
}
