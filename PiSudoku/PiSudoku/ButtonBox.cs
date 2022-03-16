namespace PiSudoku
{
    public partial class ButtonBox : UserControl
    {
        public ButtonBox()
        {
            InitializeComponent();
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
    }
}
