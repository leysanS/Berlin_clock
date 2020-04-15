using BerlinClock.Interfaces;
using System;

namespace BerlinClock.Services
{
    public class Parser : IParser
    {
        public int [] Parse(string input)
        {
            var time = input.Split(':');
            if (time.Length != 3)
            {
                throw new ArgumentException("Provided data is invalid");
            }
            var hours = int.Parse(time[0]);
            var minutes = int.Parse(time[1]);
            var seconds = int.Parse(time[2]);

            return new int[] { seconds, minutes, hours };
        }
       
}
}
