using System.Linq;

namespace PiSudoku
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTextBoxes();
            ColorTextBoxes();
        }

        private void CreateTextBoxes()
        {
            var lastTexbox = textBox1;
            textBox1.Name = "Square1";
            textBox1.Tag = 0;

            for (int i = 1; i < Constants.BoardSize; i++)
            {
                var tb = new TextBox
                {
                    Name = $"Square{i}",
                    Parent = grpBoard,
                    Font = lastTexbox.Font,
                    Width = lastTexbox.Width,
                    Height = lastTexbox.Height,
                    Left = lastTexbox.Left + lastTexbox.Width + textBox1.Left,
                    Top = lastTexbox.Top,
                    Tag = i,
                };

                if (i % Math.Sqrt(Constants.BoardSize) == 0)
                {
                    tb.Top += tb.Height + 5;
                    tb.Left = textBox1.Left;
                }

                lastTexbox = tb;
            }

            grpBoard.Width = lastTexbox.Left + lastTexbox.Width + textBox1.Left;
            grpBoard.Height = lastTexbox.Top + lastTexbox.Height + textBox1.Top;
        }

        private void ColorTextBoxes()
        {
            for (int i = 0; i < Constants.BoardSize; i++)
            {
                TextBox tb = grpBoard.Controls.OfType<TextBox>().FirstOrDefault(e => (int)e.Tag == i);
                var shapeNumber = Functions.FindShapeNumberByIndex(i);
                var color = Constants.ShapeColors.First(e => e.Item1 == shapeNumber).Item2;
                tb.BackColor = color;
            }
        }
    }
}