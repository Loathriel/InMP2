namespace InMP2.Operators
{
    internal class RobertsOperator : Operator
    {
        public int[,] GetHorizontalMatrix() => 
            new int[,]
            {
                {0, -1 },
                {1, 0 }
            };

        public int[,] GetVerticalMatrix() =>
            new int[,]
            {
                {-1, 0 },
                {0, 1 }
            };
    }
}
