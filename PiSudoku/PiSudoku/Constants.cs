namespace PiSudoku
{
    public static class Constants
    {
        public static class Shapes
        {
            public static readonly int[] Shape1Indexes = new[] { 0, 1, 2, 12, 13, 14, 24, 25, 36, 37, 48, 49 };
            public static readonly int[] Shape2Indexes = new[] { 3, 4, 5, 6, 7, 8, 15, 16, 17, 18, 19, 20 };
            public static readonly int[] Shape3Indexes = new[] { 9, 10, 11, 21, 22, 23, 34, 35, 46, 47, 58, 59 };
            public static readonly int[] Shape4Indexes = new[] { 26, 27, 28, 29, 38, 39, 40, 41, 50, 51, 52, 53 };
            public static readonly int[] Shape5Indexes = new[] { 30, 31, 32, 33, 42, 43, 44, 45, 54, 55, 56, 57 };
            public static readonly int[] Shape6Indexes = new[] { 60, 61, 62, 72, 73, 74, 84, 85, 86, 96, 97, 98 };
            public static readonly int[] Shape7Indexes = new[] { 63, 64, 75, 76, 87, 88, 99, 100, 111, 112, 123, 124 };
            public static readonly int[] Shape8Indexes = new[] { 65, 66, 77, 78, 89, 90, 101, 102, 113, 114, 125, 126 };
            public static readonly int[] Shape9Indexes = new[] { 67, 68, 79, 80, 91, 92, 103, 104, 115, 116, 127, 128 };
            public static readonly int[] Shape10Indexes = new[] { 69, 70, 71, 81, 82, 83, 93, 94, 95, 105, 106, 107 };
            public static readonly int[] Shape11Indexes = new[] { 108, 109, 110, 120, 121, 122, 132, 133, 134, 135, 136, 137 };
            public static readonly int[] Shape12Indexes = new[] { 117, 118, 119, 129, 130, 131, 138, 139, 140, 141, 142, 143 };
        }

        public static List<(int, Color)> ShapeColors => new List<(int, Color)>
        {
            (1, Color.SandyBrown),
            (2, Color.Black),
            (3, Color.Blue),
            (4, Color.Gray),
            (5, Color.Purple),
            (6, Color.Pink),
            (7, Color.Turquoise),
            (8, Color.Yellow),
            (9, Color.Beige),
            (10, Color.DarkKhaki),
            (11, Color.SaddleBrown),
            (12, Color.Lime),
        };

        public const int RowSize = 12;
        public const int ColumnSize = 12;
        public static int BoardSize => RowSize * ColumnSize;
    }
}
