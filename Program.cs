using MyCompany.Manager;
using MyCompany.President;
using MyCompany.Staff;

namespace MyCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PresidentModel MyPresident = new PresidentModel("Raendy Andhika El Vicar", "President", new DateTime(1998, 6, 24), 75_000_000, "MyCompany");
            
            ManagerModel MyManager1 = new ManagerModel("Budi Santoso", "Manager", new DateTime(1995, 10, 4), 25_000_000, "Manager IT");
            ManagerModel MyManager2 = new ManagerModel("Tri Widiastuti", "Manager", new DateTime(1992, 5, 23), 25_000_000, "Manager HR");
            ManagerModel MyManager3 = new ManagerModel("Kemal Pahlevi", "Manager", new DateTime(1996, 4, 18), 25_000_000, "Manager Finance");

            StaffModel MyStaff1 = new StaffModel("Wahyu Budi", "Staff", new DateTime(1998, 4, 18), 8_000_000, "Finance");
            StaffModel MyStaff2 = new StaffModel("Widi Anjani", "Staff", new DateTime(1997, 7, 3), 8_000_000, "IT");
            StaffModel MyStaff3 = new StaffModel("Putri Ayu", "Staff", new DateTime(1999, 12, 7), 8_000_000, "Operations");

            MyPresident.AddListManager(MyManager1);
            MyPresident.AddListManager(MyManager2);
            MyPresident.AddListManager(MyManager3);

            MyManager2.AddListStaff(MyStaff1);
            MyManager3.AddListStaff(MyStaff2);
            MyManager3.AddListStaff(MyStaff3);

            MyPresident.Information();

            MyManager1.Information();

            MyStaff2.Information();

        }
    }
}