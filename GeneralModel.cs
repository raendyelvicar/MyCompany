using MyCompany.Interfaces;
using MyCompany.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    internal class GeneralModel : IEmployee
    {
        public GeneralModel(string name, string position, DateTime bod, decimal salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            Position = position;
            BOD = bod;
            BODString = bod.ToString("dd-MM-yyyy");
            Salary = salary;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public DateTime BOD { get; set; }

        public string BODString { get; set; }

        public decimal Salary { get; set; }

        public virtual void Information()
        {
            Console.WriteLine("{0,-15} : {1}", "Name", Name);
            Console.WriteLine("{0,-15} : {1}", "Position", Position);
            Console.WriteLine("{0,-15} : {1}", "BOD", BODString);
            Console.WriteLine("{0,-15} : {1:C}", "Salary", Salary);
        }
    }
}
