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

            for (int i = 1; i < 144; i++)
            {
                var tb = new TextBox();

                tb.Name = $"Square{i}";
                tb.Parent = grpBoard;
                tb.Font = lastTexbox.Font;
                tb.Width = lastTexbox.Width;
                tb.Height = lastTexbox.Height;
                tb.Left = lastTexbox.Left + tb.Width + 5;
                tb.Top = lastTexbox.Top;

                if (i % 12 == 0)
                {
                    tb.Top += tb.Height + 5;
                    tb.Left = textBox1.Left;
                }

                lastTexbox = tb;
            }

            grpBoard.Width = lastTexbox.Left + lastTexbox.Width + 5;
            grpBoard.Height = lastTexbox.Top + lastTexbox.Height + 5;
        }
    }
}