using BerlinClock.Entities;
using System;
using System.Collections.Generic;

namespace BerlinClock.Builders
{
    public abstract class BaseComplexTimeEntityBuilder
    {
        protected Color DefaultLampColor;
        protected List<Lamp> FirstLampsRow = new List<Lamp>();
        protected List<Lamp> SecondLampsRow = new List<Lamp>();

        public TimeEntity Build()
        {
            return new TimeEntity { Rows = new List<Row> { new Row { Lamps = FirstLampsRow }, new Row { Lamps = SecondLampsRow } } };
        }

        protected  IEnumerable<Lamp> GetLamps(int numberOfSwitchedOn, int totalNumber, Func<int, Color> colorRule)
        {
            for (int i = 0; i < totalNumber; i++)
            {
                var color = colorRule(i);
                var isOn = (i + 1) <= numberOfSwitchedOn ? true : false;
                yield return new Lamp { Color = color, IsOn = isOn };
            }
        }

        protected Color GetMonoColor(int index)
        {
            return DefaultLampColor;
        }
    }
}
