namespace Tetris
{
    public class GameGrid
    {
        private int[,] Grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int row, int column]
        {
            get => Grid[row, column];
            set => Grid[row, column] = value;
        }

        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Grid = new int[rows, columns];
        }

        public bool IsInside(int row, int column)
        {
            return row >= 0 && row < Rows && column >= 0 && column < Columns;
        }

        public bool IsEmpty(int row, int column)
        {
            return IsInside(row, column) && Grid[row, column] == 0;
        }

        public bool IsRowFull(int row)
        {
            for (int column = 0; column < Columns; column++)
            {
                if (Grid[row, column] == 0)
                    return false;
            }
            return true;
        }

        public bool IsRowEmpty(int row)
        {
            for (int column = 0; column < Columns; column++)
            {
                if (Grid[row, column] != 0)
                    return false;
            }
            return true;
        }

        private void ClearRow(int row)
        {
            for (int column = 0; column < Columns; column++)
            {
                Grid[row, column] = 0;
            }
        }

        private void MoveRowDown(int row, int countRows)
        {
            for (int column = 0; column < Columns; column++)
            {
                Grid[row + countRows, column] = Grid[row, column];
                Grid[row, column] = 0;
            }
        }

        public int ClearFullRows()
        {
            int cleared = 0;

            for (int row = Rows - 1; row >= 0; row--)
            {
                if(IsRowFull(row))
                {
                    ClearRow(row);
                    ++cleared;
                }
                else if(cleared > 0)
                {
                    MoveRowDown(row, cleared);
                }
            }
            return cleared;
        }
    }
}
