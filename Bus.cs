namespace BusCompanyManagement
{
    internal class Bus
    {
        public int BusId { get; set; }
        public string PlateNumber { get; set; }
        public int SeatCount { get; set; }

        public Bus(int busId, string plateNumber, int seatCount)
        {
            BusId = busId;
            PlateNumber = plateNumber;
            SeatCount = seatCount;
        }

        public override string ToString()
        {
            return $"Bus ID: {BusId}, Plate: {PlateNumber}, Seats: {SeatCount}";
        }
    }
}
