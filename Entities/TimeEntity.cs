using System.Collections.Generic;
using System.Text;

namespace BerlinClock.Entities
{
    public class TimeEntity
    {
        public List<Row> Rows { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            Rows.ForEach(row => stringBuilder.AppendLine(row.ToString()));
            return stringBuilder.ToString();
        }
    }
}
