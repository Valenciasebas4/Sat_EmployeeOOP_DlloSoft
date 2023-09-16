using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Sat_EmployeeOOP_DlloSoft.Classes;

namespace Sat_EmployeeOOP_DlloSoft
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods
        public abstract decimal GetValueToPay();

        public override string ToString()
        {

            return $"------INFORMACIÒN DEL EMPLEADO------\n\t" +
                $"ID: {Id} \n\t " +
                $"First Name: {FirstName} \n\t " +
                $"Last Name: {LastName} \n\t " +
                $"Birth date: {BirthDate} \n\t " +
                $"Hiring Date: {HiringDate} \n\t " +
                $"Is Active? {IsActive}";
        }

        #endregion
    }
}
