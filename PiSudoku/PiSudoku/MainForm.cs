using System.Linq;

namespace PiSudoku
{
    public partial class MainForm : Form
    {
        private Board _board = new Board();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTextBoxes();
            ColorTextBoxes();
            UpdateValues();
        }

        private void CreateTextBoxes()
        {
            var firstControl = buttonBox1;
            var lastControl = buttonBox1;

            for (int i = 1; i < Constants.BoardSize; i++)
            {
                var tb = new ButtonBox //TextBox
                {
                    Name = $"Square{i}",
                    Parent = grpBoard,
                    Font = lastControl.Font,
                    Width = lastControl.Width,
                    Height = lastControl.Height,
                    Left = lastControl.Left + lastControl.Width + 5,
                    Top = lastControl.Top,
                    Tag = $"Index{i}",
                };

                if (i % Math.Sqrt(Constants.BoardSize) == 0)
                {
                    tb.Top += firstControl.Height + 5;
                    tb.Left = firstControl.Left;
                }

                lastControl = tb;
            }

            grpBoard.Width = lastControl.Left + lastControl.Width + 5;
            grpBoard.Height = lastControl.Top + lastControl.Height + 5;
        }

        private void ColorTextBoxes()
        {
            for (int i = 0; i < grpBoard.Controls.Count; i++)
            {
                var control = grpBoard.Controls[i] as ButtonBox;
                var shapeNumber = Functions.FindShapeNumberByIndex(i);
                var color = Constants.ShapeColors.First(e => e.Item1 == shapeNumber).Item2;
                control.BackColor = color;
            }
        }

        private void UpdateValues()
        {
            for (int i = 0; i < 144; i++)
            {
                var control = grpBoard.Controls[i] as ButtonBox;
                var value = _board.Data(i);

                if (value == 0)
                    continue;

                control.PossibleValues = new List<int>();
                control.PossibleValues.Add(value);
                control.lblValue.Visible = true;
                control.lblValue.Text = value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = _board.Column(1);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}