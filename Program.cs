using System;

namespace BusCompanyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusCompany company = new BusCompany("Ege Bus Company");

            company.AddBus(new Bus(1, "34 ABC 123", 50));
            company.AddBus(new Bus(2, "06 XYZ 789", 45));

            company.AddDriver(new Driver(1, "Ahmet Yılmaz", "DL12345"));
            company.AddDriver(new Driver(2, "Mehmet Kaya", "DL67890"));

            company.AddRoute(new Route(1, "Istanbul", "Ankara"));
            company.AddRoute(new Route(2, "Izmir", "Antalya"));

            company.ShowAllData();

            Console.ReadLine();
        }
    }
}
