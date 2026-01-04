namespace BusCompanyManagement
{
    internal class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string LicenseNumber { get; set; }

        public Driver(int driverId, string fullName, string licenseNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            LicenseNumber = licenseNumber;
        }

        public override string ToString()
        {
            return $"Driver ID: {DriverId}, Name: {FullName}, License: {LicenseNumber}";
        }
    }
}
