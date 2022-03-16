namespace PiSudoku
{
    public partial class ButtonBox : UserControl
    {
        public ButtonBox()
        {
            InitializeComponent();

            if (DesignMode)
                return;

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
        }

        private void ButtonClick(object? sender, EventArgs e)
        {
            var button = (Button)sender;

            bool isEnabled = !string.IsNullOrEmpty(button.Text);

            if (isEnabled)
            {
                button.Text = string.Empty;
                button.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                button.Text = button.Tag.ToString();
                button.FlatStyle = FlatStyle.Standard;
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

        public int[] PossibleValues { get; set; }

        public int Value { get; set; }

        public void Update()
        {


        }
    }
}
