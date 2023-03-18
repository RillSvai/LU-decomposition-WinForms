namespace LU_Decomposition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnMinimaze = new Button();
            btnMaximaze = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            btnList = new Button();
            btnClear = new Button();
            panel2 = new Panel();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            mainText = new RichTextBox();
            typeText = new RichTextBox();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(60, 60, 60);
            pnlMenu.Controls.Add(btnMinimaze);
            pnlMenu.Controls.Add(btnMaximaze);
            pnlMenu.Controls.Add(btnClose);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(850, 40);
            pnlMenu.TabIndex = 0;
            // 
            // btnMinimaze
            // 
            btnMinimaze.Dock = DockStyle.Right;
            btnMinimaze.FlatAppearance.BorderSize = 0;
            btnMinimaze.FlatStyle = FlatStyle.Flat;
            btnMinimaze.Image = Properties.Resources.substract_14;
            btnMinimaze.Location = new Point(715, 0);
            btnMinimaze.Margin = new Padding(0);
            btnMinimaze.Name = "btnMinimaze";
            btnMinimaze.Size = new Size(45, 40);
            btnMinimaze.TabIndex = 2;
            btnMinimaze.UseVisualStyleBackColor = true;
            btnMinimaze.Click += btnMinimaze_Click;
            // 
            // btnMaximaze
            // 
            btnMaximaze.Dock = DockStyle.Right;
            btnMaximaze.FlatAppearance.BorderSize = 0;
            btnMaximaze.FlatStyle = FlatStyle.Flat;
            btnMaximaze.Image = Properties.Resources.square_outline_16;
            btnMaximaze.Location = new Point(760, 0);
            btnMaximaze.Margin = new Padding(0);
            btnMaximaze.Name = "btnMaximaze";
            btnMaximaze.Size = new Size(45, 40);
            btnMaximaze.TabIndex = 1;
            btnMaximaze.UseVisualStyleBackColor = true;
            btnMaximaze.Click += btnMaximaze_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.X_2_16;
            btnClose.Location = new Point(805, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 40);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnList);
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 40);
            panel1.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.Dock = DockStyle.Left;
            btnList.FlatAppearance.BorderSize = 0;
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.Image = Properties.Resources.side_left_view_16;
            btnList.Location = new Point(0, 0);
            btnList.Margin = new Padding(0);
            btnList.Name = "btnList";
            btnList.Size = new Size(45, 40);
            btnList.TabIndex = 3;
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Right;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Image = Properties.Resources.trash_162;
            btnClear.Location = new Point(805, 0);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(45, 40);
            btnClear.TabIndex = 0;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 60, 60);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn5);
            panel2.Controls.Add(btn4);
            panel2.Controls.Add(btn3);
            panel2.Controls.Add(btn2);
            panel2.Controls.Add(btn1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 435);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Top;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(0, 348);
            btn5.Name = "btn5";
            btn5.Size = new Size(145, 86);
            btn5.TabIndex = 4;
            btn5.Text = "Checking answer";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Top;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(0, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(145, 87);
            btn4.TabIndex = 3;
            btn4.Text = "Show all results";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Top;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(0, 174);
            btn3.Name = "btn3";
            btn3.Size = new Size(145, 87);
            btn3.TabIndex = 2;
            btn3.Text = "Show L-matrix, U-matrix";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Top;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(0, 87);
            btn2.Name = "btn2";
            btn2.Size = new Size(145, 87);
            btn2.TabIndex = 1;
            btn2.Text = "Show vector,junctions and determinant";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Top;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(0, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(145, 87);
            btn1.TabIndex = 0;
            btn1.Text = "Show main matrix";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // mainText
            // 
            mainText.BackColor = Color.FromArgb(32, 32, 32);
            mainText.BorderStyle = BorderStyle.FixedSingle;
            mainText.Cursor = Cursors.No;
            mainText.Dock = DockStyle.Bottom;
            mainText.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainText.ForeColor = Color.White;
            mainText.Location = new Point(147, 129);
            mainText.Name = "mainText";
            mainText.ReadOnly = true;
            mainText.Size = new Size(703, 386);
            mainText.TabIndex = 7;
            mainText.Text = "Content...";
            // 
            // typeText
            // 
            typeText.BackColor = Color.FromArgb(32, 32, 32);
            typeText.BorderStyle = BorderStyle.FixedSingle;
            typeText.Cursor = Cursors.No;
            typeText.Dock = DockStyle.Top;
            typeText.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            typeText.ForeColor = Color.White;
            typeText.Location = new Point(147, 80);
            typeText.Name = "typeText";
            typeText.ReadOnly = true;
            typeText.Size = new Size(703, 50);
            typeText.TabIndex = 8;
            typeText.Text = "Type of result...";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(850, 515);
            Controls.Add(typeText);
            Controls.Add(mainText);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnClose;
        private Button btnMinimaze;
        private Button btnMaximaze;
        private Panel panel1;
        private Button btnList;
        private Button btnClear;
        private Panel panel2;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private RichTextBox mainText;
        private RichTextBox typeText;
    }
}