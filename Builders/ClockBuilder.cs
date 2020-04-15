using BerlinClock.Entities;
using System.Collections.Generic;

namespace BerlinClock.Builders
{
    public class ClockBuilder
    {
        List<TimeEntity> _timeEntities = new List<TimeEntity>();

        public ClockBuilder WithTimeEntities(List<TimeEntity> entities)
        {
            _timeEntities = entities;
            return this;
        }

        public Clock Build()
        {
            return new Clock { TimeEntities = _timeEntities };
        }
    }
}
