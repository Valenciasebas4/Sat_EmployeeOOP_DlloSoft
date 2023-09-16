using Sat_EmployeeOOP_DlloSoft.Classes;
using System;

namespace Sat_EmployeeOOP_DlloSoft
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                
                Console.WriteLine("---------------");

                //Declarar algunas variables
                int day, month, year, id;
                string firstName, lastName;
                decimal salary, sales, salaryBase;
                bool isActive;
                float commissionPercentage;

                Console.Write("Ingresar el día del cumpleaños: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes del cumpleaños: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año del cumpleaños: ");
                year = Convert.ToInt32(Console.ReadLine());

                //Instanciar la clase Date.cs
                Date birthDate = new Date(year, month, day);
                Console.Write("\n"); //Salto de línea
                //Console.WriteLine(dateObject.ToString()); //23/50/23232

                Console.WriteLine("");

                Console.WriteLine("       *******************");
                Console.WriteLine("       * SALARIO EMPLEADO *");
                Console.WriteLine("       *******************");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                /*
                Console.Write("Ingresar el día del Contrato: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes del Contrato: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año del Contrato: ");
                year = Convert.ToInt32(Console.ReadLine());

                //Instanciar la clase Date.cs
                Date hiringDate = new Date(year, month, day);
                */
                Console.Write("Are you active? True or False: ");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Ingrese salario devengado: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\n"); //Salto de línea

                //Esta es la forma de crear objetos a partir de una clase concreta
                SalaryEmployee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = true,
                    Salary = salary
                };

                Console.Clear();
                Console.WriteLine(salaryEmployee);

                Console.WriteLine("");

                Console.WriteLine("       ***********************");
                Console.WriteLine("       * COMISIÒN EMPLEADO *");
                Console.WriteLine("       ***********************");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Are you active? True or False: ");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Enter your commission percentage: ");
                commissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.Write("Enter your sales: ");
                sales = Convert.ToDecimal(Console.ReadLine());

                CommissionEmployee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                };

                Console.Clear();
                Console.WriteLine(commissionEmployee);

                Console.WriteLine("");

                Console.WriteLine("       ******************************");
                Console.WriteLine("       *  BASE Y COMISIÒN EMPLEADO  *");
                Console.WriteLine("       ******************************");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Are you active? True or False: ");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Enter your commission percentage: ");
                commissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.Write("Enter your sales: ");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter your salary base: ");
                salaryBase = Convert.ToDecimal(Console.ReadLine());

                Employee baseComissionEmployee = new BaseCommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales,
                    Base = salaryBase
                };
                Console.Clear();
                Console.WriteLine(baseComissionEmployee);

                Console.WriteLine("");

                Console.WriteLine("       ***********************");
                Console.WriteLine("       * CONTRACTOR EMPLOYEE *");
                Console.WriteLine("       ***********************");

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Are you active? True or False: ");
                isActive = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Ingrese el numero de horas: ");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.Write("Ingrese el valor de la hora: ");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                HourlyEmployee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isActive,
                    Hours = hours,
                    HourValue = hourValue,
                };
                Console.Clear();
                Console.WriteLine(hourlyEmployee);
            }
            catch (Exception ex)
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);
            }
        }
    }
}