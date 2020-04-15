using BerlinClock.Builders;
using BerlinClock.Entities;
using BerlinClock.Interfaces;
using System.Collections.Generic;

namespace BerlinClock.Services
{
    public class TimeToBerlinClockConverter : ITimeToBerlinClockConverter
    {
        private const int _secondsDivider = 2;
        private const int _hoursDivider = 5;
        private const int _minutesDivider = 5;

        public Clock ConvertDataTimeToBerlinClock(int seconds, int minutes, int hours)
        {
            TimeEntity secondsEntity = (seconds % _secondsDivider == 0)
                ? new SecondsBuilder().WithSwitchedOnLamp().Build()
                : new SecondsBuilder().Build();

            var hoursByFiveCount = hours / _hoursDivider;
            var hoursByOneCount = hours - hoursByFiveCount * _hoursDivider;
            var hourEntity = new HourBuilder().With5EntityLampsOn(hoursByFiveCount).With1EntityLampsOn(hoursByOneCount).Build();

            var minutesByFiveCount = minutes / _minutesDivider;
            var minutesByOneCount = minutes - minutesByFiveCount * _minutesDivider;
            var minuteEntity = new MinuteBuilder().With5EntityLampsOn(minutesByFiveCount).With1EntityLampsOn(minutesByOneCount).Build();

            return new ClockBuilder().WithTimeEntities(new List<TimeEntity> { secondsEntity, hourEntity, minuteEntity }).Build();
        }
    }
}
