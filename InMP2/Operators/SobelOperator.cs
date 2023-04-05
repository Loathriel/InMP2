namespace InMP2.Operators
{
    internal class SobelOperator : Operator
    {
        public int[,] GetHorizontalMatrix() =>
            new int[,]
            {
                {1, 0, -1 },
                {2, 0, -2 },
                {1, 0, -1 }
            };

        public int[,] GetVerticalMatrix() =>
            new int[,]
            {
                {-1, -2, -1 },
                {0, 0, 0 },
                {1, 2, 1 }
            };
    }
}
