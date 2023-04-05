namespace InMP2.Extensions
{
    public static class DoubleExtensions
    {
        public static int Normalize(this double value, double min, double max, double coefficient)
        {
            return (int)Math.Round(coefficient * (value - min) / (max - min));
        }
    }
}
