
namespace SW.PayRool
{
    public class ZoneService : IZoneService
    {
        public static Random random = new();
        public bool IsDangerZone(string dutyStation)
        {
            return random.Next(1, 10) == 3;
        }
    }
}
