namespace InMP2.Operators
{
    internal class PrewittOperator : Operator
    {
        public int[,] GetHorizontalMatrix() =>
            new int[,]
            {
                {1, 0, -1 },
                {1, 0, -1 },
                {1, 0, -1 }
            };

        public int[,] GetVerticalMatrix() =>
            new int[,]
            {
                {-1, -1, -1 },
                {0, 0 , 0 },
                {1, 1, 1 }
            };
    }
}
