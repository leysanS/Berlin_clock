using BerlinClock.Interfaces;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IInputValidator _validator;
        private readonly IParser _parser;
        private readonly ITimeToBerlinClockConverter _timeToBerlinClockConverter;
        public TimeConverter(IInputValidator validator, IParser parser, ITimeToBerlinClockConverter timeToBerlinClockConverter)
        {
            _validator = validator;
            _parser = parser;
            _timeToBerlinClockConverter = timeToBerlinClockConverter;
        }
        public string convertTime(string aTime)
        {
            var parsedTime = _parser.Parse(aTime);
            var seconds = parsedTime[0];
            var minutes = parsedTime[1];
            var hours = parsedTime[2];

            _validator.ValidateInput(seconds, minutes, hours);

            return _timeToBerlinClockConverter.ConvertDataTimeToBerlinClock(seconds, minutes, hours).ToString();
        }
        
      

    }
}
