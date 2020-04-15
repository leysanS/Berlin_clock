using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Entities
{
    public class Lamp
    {
        public Color Color { get; set; }

        public bool IsOn { get; set; }

        public override string ToString()
        {
            return IsOn ? Color.ToString() : "O";
        }
    }
}
