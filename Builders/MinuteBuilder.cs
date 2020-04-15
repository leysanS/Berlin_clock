using BerlinClock.Entities;

namespace BerlinClock.Builders
{
    public class MinuteBuilder : BaseComplexTimeEntityBuilder
    {
        private const Color _additionalColor = Color.R;
        private const int _totalFirstRowLampsCount = 11;
        private const int _totalSecondRowLampsCount = 4;

        public MinuteBuilder()
        {
            base.DefaultLampColor = Color.Y;
        }

        public MinuteBuilder With5EntityLampsOn(int number)
        {
            FirstLampsRow.AddRange(GetLamps(number, _totalFirstRowLampsCount, GetMixedColors));
            return this;
        }

        public MinuteBuilder With1EntityLampsOn(int number)
        {
            SecondLampsRow.AddRange(GetLamps(number, _totalSecondRowLampsCount, GetMonoColor));
            return this;
        }

        private Color GetMixedColors(int index)
        {
            return (index + 1) % 3 == 0 ? _additionalColor : DefaultLampColor;
        }

    }
}
