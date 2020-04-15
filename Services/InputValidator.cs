using BerlinClock.Interfaces;
using System;

namespace BerlinClock.Services
{
    public class InputValidator : IInputValidator
    {
        public void ValidateInput(int seconds, int minutes, int hours)
        {
            if (seconds < 0 || seconds > 59)
            {
                throw new ArgumentException("Enteres seconds are invalid");
            }

            if (minutes < 0 || minutes > 59)
            {
                throw new ArgumentException("Entered minutes are invalid");
            }

            if (hours < 0 || hours > 24)
            {
                throw new ArgumentException("Entered hours are invalid");
            }
        }
    }
}
