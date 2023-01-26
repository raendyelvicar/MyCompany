using MyCompany.Interfaces;
using MyCompany.President;
using MyCompany.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Manager
{
    internal class ManagerModel : GeneralModel
    {

        public ManagerModel(string name, string position, DateTime bod, decimal salary, string managerType) : base(name, position, bod, salary)
        {
            ManagerType = managerType;
            ListStaff = new List<StaffModel>();
        }

        public string ManagerType { get; set; }

        public List<StaffModel> ListStaff { get; set; }

        public override void Information()
        {
            Console.WriteLine("===== DETAIL INFORMATION (MANAGER) =====\n");
            Console.WriteLine("{0,-15} : {1}", "Name", Name);
            Console.WriteLine("{0,-15} : {1}", "Position", Position);
            Console.WriteLine("{0,-15} : {1}", "BOD",  BODString);
            Console.WriteLine("{0,-15} : {1:C}", "Salary", Salary);
            Console.WriteLine("{0,-15} : {1}", "Manager Type", ManagerType);
            
            if (ListStaff?.Any() != false)
            {
                Console.WriteLine("{0,-15} :", "List of Staff");
                foreach (var data in ListStaff)
                {
                    Console.WriteLine("GUID : " + data.Id);
                    Console.WriteLine("Name : " + data.Name);
                }
            } else
            {
                Console.WriteLine("\nThis manager doesn't have staff");
            }
            Console.WriteLine();
        }

        public void AddListStaff(StaffModel staffModel)
        {
            ListStaff.Add(staffModel);
        }

    }
}
