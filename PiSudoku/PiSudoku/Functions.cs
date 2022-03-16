namespace PiSudoku
{
    public static class Functions
    {
        static Functions()
        {
            ShapeNumberByIndex = new Dictionary<int, int>();

            // build a dictionary that holds the shape number for each square on the board.
            for (int i = 1; i <= Constants.ShapeColors.Count; i++)
            {
                var array = GetShapeIndexes(i);

                for (int j = 0; j < array.Length; j++)
                {
                    ShapeNumberByIndex.Add(array[j], i);
                }
            }
        }

        public static readonly Dictionary<int, int> ShapeNumberByIndex;

        public static int FindShapeNumberByIndex(int index)
        {
            return ShapeNumberByIndex[index];
        }

        public static int[] GetShapeIndexes(int shapeNumber)
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
