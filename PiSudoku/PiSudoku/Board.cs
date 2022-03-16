namespace PiSudoku
{
    public class Board
    {
        private int[] _data;

        public Board()
        {
            _data = new int[Constants.BoardSize];
        }

        /// <summary>
        /// Get the value from the board at a specific index.
        /// </summary>
        public int Data(int index) => _data[index];

        /// <summary>
        /// Get the array of values from the board of a specific row.
        /// </summary>
        public int[] Row(int rowNumber)
        {
            return null;
        }

        /// <summary>
        /// Get the array of values from the board of a specific column.
        /// </summary>
        public int[] Column(int columnNumber)
        {
            return null;
        }

        /// <summary>
        /// Get the array of values from the board of a specific shape.
        /// </summary>
        public int[] Shape(int shapeNumber)
        {
            return null;
        }
    }
}
