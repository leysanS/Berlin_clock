using System.Collections.Generic;
using System.Text;

namespace BerlinClock.Entities
{
    public class Clock
    {
        public List<TimeEntity> TimeEntities { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            TimeEntities.ForEach(entity => sb.Append(entity.ToString()));
            return sb.ToString().Trim();
        }
    }
}
