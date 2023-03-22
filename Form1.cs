using hw2;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using System.Text.RegularExpressions;

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
            _matrix = new SquareMatrix("-1 1 0\n 0 2 1\n -1 5 3");
            _members = new Vector("1 5 12");
            _decompositionLu = new DecompositionLU(_matrix, _members);
            Decomposition(_decompositionLu);
        }
        //Vision panel with buttons
        private void btnList_Click(object sender, EventArgs e)
            => panel2.Visible = !panel2.Visible;
        // Main matrix
        private void btn1_Click(object sender, EventArgs e)
            => mainText.Text = _decompositionLu.MainMatrix.ToString();

        // Vector of free members
        private void btn2_Click(object sender, EventArgs e)
            => mainText.Text = $"{_decompositionLu.FreeMembers}\n\n{_decompositionLu.Determinant}\n\n{_decompositionLu.Junctions}";
        // L,U matrixes
        private void btn3_Click(object sender, EventArgs e)
            => mainText.Text = $"{_decompositionLu.LMatrix}\n\n{_decompositionLu.Umatrix}";
        // All results of LU decomposition
        private void btn4_Click(object sender, EventArgs e)
            => mainText.Text = _decompositionLu.ToString();
        // Checking answers
        private void btn5_Click(object sender, EventArgs e)
            => mainText.Text = _decompositionLu.CheckingResult();
        // Clear text
        private void btnClear_Click(object sender, EventArgs e)
            => mainText.Text = "Content...";
        // Close programm
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimaze_Click(object sender, EventArgs e)
            => WindowState = FormWindowState.Minimized;
        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void matrixInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void matrixInput_Click(object sender, EventArgs e) => matrixInput.Clear();

        private void vectorInput_Click(object sender, EventArgs e) => vectorInput.Clear();

        private void btnSave_Click(object sender, EventArgs e)
        {
            _matrix = new SquareMatrix(matrixInput.Text);
            _members = new Vector(vectorInput.Text);
            _decompositionLu = new DecompositionLU(_matrix, _members);
            Decomposition(_decompositionLu);
        }

        private void vectorInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidVector(vectorInput.Text, out errorMsg))
            {
                e.Cancel = true;
                vectorInput.Select(0, vectorInput.Text.Length);

                this.errorProvider1.SetError(vectorInput, errorMsg);
            }
        }
        private void vectorInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(vectorInput, "");
        }
        public bool ValidVector(string vector, out string errorMsg)
        {
            if (!Regex.IsMatch(vector, @"^\s*\d+(\s+\d+)*\s*$") || vector == string.Empty)
            {
                errorMsg = "Invalid input format!";
                return false;
            }
            errorMsg = "";
            return true;
        }

        private void matrixInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidMatrix(matrixInput.Text, out errorMsg))
            {
                e.Cancel = true;
                matrixInput.Select(0, matrixInput.Text.Length);

                this.errorProvider1.SetError(matrixInput, errorMsg);
            }
        }

        private void matrixInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(matrixInput, "");
        }
        public bool ValidMatrix(string matrix, out string errorMsg)
        {
            if (matrix == "ex")
            {
                errorMsg = string.Empty;
                return true;

            }
            if (!Regex.IsMatch(matrix, @"^\s*\d+(\s+\d+)*\s*\n*$") || matrix == string.Empty)
            {
                errorMsg = "Invalid input format!";
                return false;
            }
            errorMsg = "";
            return true;
        }
        private void Decomposition(DecompositionLU obj)
        {
            obj.FillingLU();
            obj.FindTransitJunctions();
            obj.FindJunctions();
        }
    }
}