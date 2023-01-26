using MyCompany.Interfaces;
using MyCompany.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.President
{
    internal class PresidentModel : GeneralModel
    {
        public PresidentModel(string name, string position, DateTime bod, decimal salary, string companyName) : base(name, position, bod, salary)
        {
            CompanyName = companyName;
            ListManager = new List<ManagerModel>();
        }

        public string CompanyName { get; set; }

        public List<ManagerModel> ListManager { get; set; }

        public override void Information()
        {
            Console.WriteLine("===== DETAIL INFORMATION (PRESIDENT) =====\n");
            Console.WriteLine("{0,-15} : {1}", "Name", Name);
            Console.WriteLine("{0,-15} : {1}", "Position", Position);
            Console.WriteLine("{0,-15} : {1}", "BOD", BODString);
            Console.WriteLine("{0,-15} : {1:C}", "Salary", Salary);
            Console.WriteLine("{0,-15} : {1}", "Company Name", CompanyName);
            if(ListManager != null)
            {
                Console.WriteLine("{0,-15} :", "List of Manager");
                foreach (var data in ListManager)
                {
                    Console.WriteLine("GUID : " + data.Id);
                    Console.WriteLine("Name : " + data.Name);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("President doesn't have manager");
            }
        }

        public void AddListManager(ManagerModel managerModel)
        {
            ListManager.Add(managerModel);
        }
    }
}
