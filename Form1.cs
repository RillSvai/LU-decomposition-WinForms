namespace LU_Decomposition
{
    public partial class Form1 : Form
    {
        private SquareMatrix _matrix;
        private Vector _members;
        private DecompositionLU _decompositionLu;
        public Form1()
        {
            InitializeComponent();
            _matrix = new SquareMatrix("data.txt");
            _members = new Vector("1    5   12   ", 3);
            _decompositionLu = new DecompositionLU(_matrix, _members);
            _decompositionLu.FillingLU();
            _decompositionLu.FindTransitJunctions();
            _decompositionLu.FindJunctions();

        }
        //Vision panel with buttons
        private void btnList_Click(object sender, EventArgs e) => panel2.Visible = !panel2.Visible;
        // Main matrix
        private void btn1_Click(object sender, EventArgs e)
        {
            typeText.Text = "Main matrix => ";
            mainText.Text = _decompositionLu.MainMatrix.ToString();
        }
        // Vector of free members
        private void btn2_Click(object sender, EventArgs e)
        {
            typeText.Text = "Free members, determinant, junctions =>";
            mainText.Text = $"{_decompositionLu.FreeMembers}\n\n{_decompositionLu.Determinant}\n\n{_decompositionLu.Junctions}";
        }
        // L,U matrixes
        private void btn3_Click(object sender, EventArgs e)
        {
            typeText.Text = "L-matrix, U-matrix =>";
            mainText.Text = $"{_decompositionLu.LMatrix}\n\n{_decompositionLu.Umatrix}";
        }
        // All results of LU decomposition
        private void btn4_Click(object sender, EventArgs e)
        {
            typeText.Text = "All results =>";
            mainText.Text = _decompositionLu.ToString();
        }
        // Checking answers
        private void btn5_Click(object sender, EventArgs e)
        {
            typeText.Text = "Checking =>";
            mainText.Text = _decompositionLu.CheckingResult();
        }
        // Clear text
        private void btnClear_Click(object sender, EventArgs e)
        {
            typeText.Text = "Type of result...";
            mainText.Text = "Content...";
        }
        // Close programm
        private void btnClose_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void btnMinimaze_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

    }
}