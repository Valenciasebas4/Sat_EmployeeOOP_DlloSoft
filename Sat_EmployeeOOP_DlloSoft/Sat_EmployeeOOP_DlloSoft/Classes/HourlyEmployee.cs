using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat_EmployeeOOP_DlloSoft.Classes
{

    public class HourlyEmployee : Employee
    {
        #region Properties
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        #endregion

        public override decimal GetValueToPay()
        {
            return ((decimal)Hours * HourValue);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Nùmero de horas....{Hours}" +
                $"\n\t Valor de la hora.....{HourValue:C2}" +
                $"\n\t Salario..........{GetValueToPay():C2}\n\t" +
                $"------------------------------------";
        }
    }
}
