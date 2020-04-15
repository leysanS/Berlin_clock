using BerlinClock.Entities;
using System.Collections.Generic;

namespace BerlinClock.Builders
{
    public class SecondsBuilder
    {
        private Color _defaultColor = Color.Y;
        private bool _isOn;
        
        public SecondsBuilder WithSwitchedOnLamp()
        {
            _isOn = true;
            return this;
        }

        public TimeEntity Build()
        {
            return new TimeEntity
            {
                Rows = new List<Row>
                {
                    new Row{ Lamps = new List<Lamp> {new Lamp { Color = _defaultColor, IsOn = _isOn } }}
                }
            };
        }
    }
}
