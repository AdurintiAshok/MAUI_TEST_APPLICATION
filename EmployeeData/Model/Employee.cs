using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeData.Model
{
    internal class Employee
    {
        public int EmployeeId
        {

        get; set; }
        public string EmployeeName
        {

        get; set; }
        public string EmployeeEmail
        {

            get; set;
        }
        public string EmployeePhone
        {

            get; set;
        }
        public bool isActive
        {

            get; set;
        }
        public Guid UUID { get; set; } = Guid.NewGuid();
    }
   


}
