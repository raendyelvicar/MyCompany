using MyCompany.Interfaces;
using MyCompany.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Staff
{
    internal class StaffModel : GeneralModel
    {
        public StaffModel(string name, string position, DateTime bod, decimal salary, string department) : base(name, position, bod, salary)
        {
            Department = department;
        }

        public string Department { get; set; }

        public override void Information()
        {
            Console.WriteLine("===== DETAIL INFORMATION (STAFF) =====\n");
            Console.WriteLine("{0,-15} : {1}", "Name", Name);
            Console.WriteLine("{0,-15} : {1}", "Position", Position);
            Console.WriteLine("{0,-15} : {1}", "BOD", BODString);
            Console.WriteLine("{0,-15} : {1:C}", "Salary", Salary);
            Console.WriteLine("{0,-15} : {1}", "Department", Department);
        }

    }
}
