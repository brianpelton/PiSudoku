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
        }

        private void CreateTextBoxes()
        {
            var lastTexbox = textBox1;

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
                    Top = lastTexbox.Top
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
    }
}