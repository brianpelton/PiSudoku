namespace PiSudoku
{
    public class Board
    {
        private int[] _data;

        public Board()
        {
            _data = new int[Constants.BoardSize];

            //test data
            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = 0;
            }

            var knownValues = new List<(int, int)>()
            {
                (0,3),
                (3,1),
                (4,5),
                (5,4),
                (8,1),
                (10,9),
                (11,5),
                (13,1),
                (16,3),
                (21,1),
                (22,3),
                (23,6),
                (26,4),
                (29,3),
                (31,8),
                (34,2),
                (36,5),
                (39,1),
                (42,9),
                (43,2),
                (44,5),
                (47,1),
                (49,9),
                (52,5),
                (55,5),
                (60,5),
                (61,8),
                (62,1),
                (65,9),
                (68,3),
                (70,6),
                (73,5),
                (75,8),
                (78,2),
                (81,5),
                (82,5),
                (83,3),
                (88,5),
                (91,6),
                (94,1),
                (96,2),
                (99,5),
                (100,1),
                (101,5),
                (104,5),
                (107,9),
                (109,6),
                (112,4),
                (114,1),
                (117,3),
                (120,1),
                (121,5),
                (122,1),
                (127,5),
                (130,5),
                (132,5),
                (133,5),
                (135,4),
                (138,3),
                (139,1),
                (140,6),
                (143,8),
            };

            foreach(var knownValue in knownValues)
            {
                _data[knownValue.Item1] = knownValue.Item2;

            }
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
            return _data[(rowNumber * 12)..((rowNumber * 12) + 12)];

        }

        /// <summary>
        /// Get the array of values from the board of a specific column.
        /// </summary>
        public int[] Column(int columnNumber)
        {
            var values = new int[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (i * 12) + columnNumber;
            }
            return GetValuesFromIndexes(values);
        }

        /// <summary>
        /// Get the array of values from the board of a specific shape.
        /// </summary>
        public int[] Shape(int shapeNumber)
        {
            var values = Functions.GetShapeIndexes(shapeNumber);
            return GetValuesFromIndexes(values);
        }

        public int[] GetValuesFromIndexes(int[] indexes)
        {
            var returnData = new int[12];
            for (int i = 0; i < indexes.Length; i++)
            {
                returnData[i] = _data[indexes[i]];
            }
            return returnData;
        }
    }
}
