namespace GameOfLifeKata
{
    public class GameOfLife
    {
        public int[,] Execute(int[,] gamestate)
        {
            for (int row = 0; row < gamestate.GetUpperBound(0); row++)
            {
                for (int column = 0; column < gamestate.GetUpperBound(1); column++)
                {
                    var cell = gamestate[row, column];
                    if (cell == 1)
                    {
                        var sumOfNeighbours = CalculateNeighboursState(gamestate, column, row);
                        if (sumOfNeighbours < 2)
                        {
                            gamestate[row, column] = 0;
                        }
                        if (sumOfNeighbours  ==2 || sumOfNeighbours ==3)
                        {
                            gamestate[row, column] = 0;
                        }
                        if (sumOfNeighbours > 3)
                        {
                            gamestate[row, column] = 0;
                        }
                    }
                    else
                    {
                        var sumOfNeighbours = CalculateNeighboursState(gamestate, column, row);
                        if (sumOfNeighbours == 3)
                        {
                            gamestate[row, column] = 1;
                        }
                    }
                }
            }
            return gamestate;
        }

        private static int CalculateNeighboursState(int[,] gamestate, int column, int row)
        {
            var sumOfNeighbours = 0;
            if (column > 0)
            {
                sumOfNeighbours += gamestate[row, column - 1];
            }

            if (gamestate.GetUpperBound(1) > 0)
            {
                sumOfNeighbours += gamestate[row, column + 1];
            }

            if (row > 0)
            {
                sumOfNeighbours += gamestate[row - 1, column];
            }

            if (gamestate.GetUpperBound(0) > 0)
            {
                sumOfNeighbours += gamestate[row + 1, column];
            }

            if (row > 0 && gamestate.GetUpperBound(1) > 0)
            {
                sumOfNeighbours += gamestate[row - 1, column + 1];
            }

            if (gamestate.GetUpperBound(0) > 0 && gamestate.GetUpperBound(1) > 0)
            {
                sumOfNeighbours += gamestate[row + 1, column + 1];
            }

            if (gamestate.GetUpperBound(0) > 0 && column > 0)
            {
                sumOfNeighbours += gamestate[row + 1, column - 1];
            }

            if (row > 0 && column > 0)
            {
                sumOfNeighbours += gamestate[row - 1, column - 1];
            }

            return sumOfNeighbours;
        }
    }
}