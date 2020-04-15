using System.Collections.Generic;
using System.Text;

namespace BerlinClock.Entities
{
    public class Row
    {
        public List<Lamp> Lamps { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Lamps.ForEach(lamp => sb.Append(lamp.ToString()));
            return sb.ToString();
        }
    }
}
