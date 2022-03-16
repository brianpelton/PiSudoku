namespace PiSudoku
{
    public partial class ButtonBox : UserControl
    {
        public ButtonBox()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            PossibleValues = new List<int>();
            PossibleValues.AddRange(Constants.PossibleValues);

            Load += ButtonBox_Load;
        }

        private void ButtonBox_Load(object? sender, EventArgs e)
        {
            button1.Click += ButtonClick;
            button2.Click += ButtonClick;
            button3.Click += ButtonClick;
            button4.Click += ButtonClick;
            button5.Click += ButtonClick;
            button6.Click += ButtonClick;
            button7.Click += ButtonClick;
            button8.Click += ButtonClick;
            button9.Click += ButtonClick;
            button10.Click += ButtonClick;
            button11.Click += ButtonClick;
            button12.Click += ButtonClick;
            lblValue.Click += LabelClick;
        }

        private void LabelClick(object? sender, EventArgs e)
        {
            lblValue.Visible = false;
        }

        private void ButtonClick(object? sender, EventArgs e)
        {
            var button = (Button)sender;

            bool isEnabled = !string.IsNullOrEmpty(button.Text);

            if (isEnabled)
            {
                var value = Convert.ToInt32(button.Text);
                PossibleValues.Remove(value);

                button.Text = string.Empty;
                button.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                var value = Convert.ToInt32(button.Tag);
                PossibleValues.Add(value);

                button.Text = button.Tag.ToString();
                button.FlatStyle = FlatStyle.Standard;
            }

            if (PossibleValues.Count == 1)
            {
                lblValue.Text = PossibleValues.FirstOrDefault().ToString();
                lblValue.Visible = true;
            }
        }

        public Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        public List<int> PossibleValues { get; set; }
    }
}
