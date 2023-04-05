using static System.Math;

namespace InMP2
{
    public static class Transformations
    {
        public static int Scalar(Color[,] second, int[,] source, Func<Color, int> selector)
        {
            var sum = 0;
            for (var i = 0; i < source.GetLength(0); ++i)
            {
                for (var j = 0; j < source.GetLength(1); ++j)
                {
                    sum += source[i, j] * selector(second[i, j]);
                }
            }
            return sum;
        }

        public static double ScalarDistance(Color[,] source, int[,] horizontalOperator,
            int[,] verticalOperator, Func<Color, int> selector)
        {
            return Sqrt(Pow(Scalar(source, horizontalOperator, selector), 2) 
                + Pow(Scalar(source, verticalOperator, selector), 2));
        }

        public static (double, double, double) ScalarDistance(Color[,] source, int[,] horizontalOperator,
            int[,] verticalOperator, bool grayscale = true)
        {
            var _r = ScalarDistance(source, horizontalOperator, verticalOperator, color => color.R);
            var _g = ScalarDistance(source, horizontalOperator, verticalOperator, color => color.G);
            var _b = ScalarDistance(source, horizontalOperator, verticalOperator, color => color.B);
            if (grayscale)
            {
                var _gray = _r + _b + _g;
                return (_gray, _gray, _gray);
            }
            return (_r, _g, _b);
        }


    }
}
