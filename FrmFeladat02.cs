namespace WFA230509
{
    public partial class FrmFeladat02 : Form
    {
        public FrmFeladat02()
        {
            InitializeComponent();
            lblHelloWorld.Click += OnLblHelloWorldClick;
            btnGomb.Click += OnBtnGombClick;
            btnGomb.MouseEnter += OnBtnGombMouseEnter;
            btnGomb.MouseMove += OnBtnGombMouseMove;
            btnGomb.MouseLeave += OnBtnGombMouseLeave;
        }

        private void OnBtnGombMouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            btnGomb.Text = btnGomb.Text.ToLower();
        }

        private void OnBtnGombMouseMove(object? sender, MouseEventArgs e)
        {
            //this.Text = "...";
            lblHelloWorld.Text = $"x:= {Cursor.Position.X}; y:= {Cursor.Position.Y}";
        }

        private void OnBtnGombMouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void OnBtnGombClick(object? sender, EventArgs e)
        {
            btnGomb.Text = btnGomb.Text.ToUpper();
        }

        private void OnLblHelloWorldClick(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}