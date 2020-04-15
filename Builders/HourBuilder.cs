using BerlinClock.Entities;
namespace BerlinClock.Builders
{
    public class HourBuilder : BaseComplexTimeEntityBuilder
    {
        private const int _totalFirstRowLampsCount = 4;
        private const int _totalSecondRowLampsCount = 4;

        public HourBuilder()
        {
            DefaultLampColor = Color.R;
        }

        public  HourBuilder With5EntityLampsOn(int number)
        {
            FirstLampsRow.AddRange(GetLamps(number, _totalFirstRowLampsCount, GetMonoColor));
            return this;
        }

        public HourBuilder With1EntityLampsOn(int number)
        {
            SecondLampsRow.AddRange(GetLamps(number, _totalSecondRowLampsCount, GetMonoColor));
            return this;
        }
    }

}
