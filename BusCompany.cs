using System.Collections.Generic;

namespace BusCompanyManagement
{
    internal class BusCompany
    {
        public string CompanyName { get; set; }

        public List<Bus> Buses { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Route> Routes { get; set; }

        public BusCompany(string companyName)
        {
            CompanyName = companyName;
            Buses = new List<Bus>();
            Drivers = new List<Driver>();
            Routes = new List<Route>();
        }

        public void AddBus(Bus bus)
        {
            Buses.Add(bus);
        }

        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }

        public void AddRoute(Route route)
        {
            Routes.Add(route);
        }

        public void ShowAllData()
        {
            Console.WriteLine("\n--- BUSES ---");
            foreach (var bus in Buses)
                Console.WriteLine(bus);

            Console.WriteLine("\n--- DRIVERS ---");
            foreach (var driver in Drivers)
                Console.WriteLine(driver);

            Console.WriteLine("\n--- ROUTES ---");
            foreach (var route in Routes)
                Console.WriteLine(route);
        }
    }
}
