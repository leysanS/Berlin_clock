using BerlinClock.Entities;

namespace BerlinClock.Interfaces
{
    public interface ITimeToBerlinClockConverter
    {
        Clock ConvertDataTimeToBerlinClock(int seconds, int minutes, int hours);
    }
}
