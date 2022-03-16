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

        public int[] GetShapeIndexes(int shapeNumber)
        {
            switch (shapeNumber)
            {
                case 1:
                    return Constants.Shapes.Shape1Indexes;
                case 2:
                    return Constants.Shapes.Shape2Indexes;
                case 3:
                    return Constants.Shapes.Shape3Indexes;
                case 4:
                    return Constants.Shapes.Shape4Indexes;
                case 5:
                    return Constants.Shapes.Shape5Indexes;
                case 6:
                    return Constants.Shapes.Shape6Indexes;
                case 7:
                    return Constants.Shapes.Shape7Indexes;
                case 8:
                    return Constants.Shapes.Shape8Indexes;
                case 9:
                    return Constants.Shapes.Shape9Indexes;
                case 10:
                    return Constants.Shapes.Shape10Indexes;
                case 11:
                    return Constants.Shapes.Shape11Indexes;
                case 12:
                    return Constants.Shapes.Shape12Indexes;
            }

            return null;
        }
    }
}
