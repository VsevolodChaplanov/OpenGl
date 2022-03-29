
namespace WinFormsFirstPractice
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
            this.Label_a = new System.Windows.Forms.Label();
            this.a_coeff = new System.Windows.Forms.TextBox();
            this.Label_b = new System.Windows.Forms.Label();
            this.Label_c = new System.Windows.Forms.Label();
            this.b_coeff = new System.Windows.Forms.TextBox();
            this.c_coeff = new System.Windows.Forms.TextBox();
            this.SolveButton = new System.Windows.Forms.Button();
            this.Solution = new System.Windows.Forms.Label();
            this.SolutionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_a
            // 
            this.Label_a.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_a.Location = new System.Drawing.Point(103, 51);
            this.Label_a.Name = "Label_a";
            this.Label_a.Size = new System.Drawing.Size(14, 15);
            this.Label_a.TabIndex = 0;
            this.Label_a.Text = "a";
            this.Label_a.Click += new System.EventHandler(this.label1_Click);
            // 
            // a_coeff
            // 
            this.a_coeff.Location = new System.Drawing.Point(61, 69);
            this.a_coeff.Name = "a_coeff";
            this.a_coeff.Size = new System.Drawing.Size(100, 23);
            this.a_coeff.TabIndex = 1;
            // 
            // Label_b
            // 
            this.Label_b.AutoSize = true;
            this.Label_b.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_b.Location = new System.Drawing.Point(302, 51);
            this.Label_b.Name = "Label_b";
            this.Label_b.Size = new System.Drawing.Size(15, 15);
            this.Label_b.TabIndex = 2;
            this.Label_b.Text = "b";
            this.Label_b.Click += new System.EventHandler(this.Label_B_Click);
            // 
            // Label_c
            // 
            this.Label_c.AutoSize = true;
            this.Label_c.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_c.Location = new System.Drawing.Point(502, 51);
            this.Label_c.Name = "Label_c";
            this.Label_c.Size = new System.Drawing.Size(13, 15);
            this.Label_c.TabIndex = 3;
            this.Label_c.Text = "c";
            // 
            // b_coeff
            // 
            this.b_coeff.Location = new System.Drawing.Point(258, 69);
            this.b_coeff.Name = "b_coeff";
            this.b_coeff.Size = new System.Drawing.Size(100, 23);
            this.b_coeff.TabIndex = 4;
            // 
            // c_coeff
            // 
            this.c_coeff.Location = new System.Drawing.Point(457, 69);
            this.c_coeff.Name = "c_coeff";
            this.c_coeff.Size = new System.Drawing.Size(100, 23);
            this.c_coeff.TabIndex = 5;
            this.c_coeff.TextChanged += new System.EventHandler(this.c_coeff_TextChanged);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(270, 153);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(75, 23);
            this.SolveButton.TabIndex = 6;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // Solution
            // 
            this.Solution.AutoSize = true;
            this.Solution.Location = new System.Drawing.Point(103, 251);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(51, 15);
            this.Solution.TabIndex = 8;
            this.Solution.Text = "Solution";
            this.Solution.Click += new System.EventHandler(this.label2_Click);
            // 
            // SolutionText
            // 
            this.SolutionText.AutoSize = true;
            this.SolutionText.Location = new System.Drawing.Point(103, 227);
            this.SolutionText.Name = "SolutionText";
            this.SolutionText.Size = new System.Drawing.Size(153, 15);
            this.SolutionText.TabIndex = 9;
            this.SolutionText.Text = "Solution of a*x^2+b*x+c=0";
            this.SolutionText.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 332);
            this.Controls.Add(this.SolutionText);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.c_coeff);
            this.Controls.Add(this.b_coeff);
            this.Controls.Add(this.Label_c);
            this.Controls.Add(this.Label_b);
            this.Controls.Add(this.a_coeff);
            this.Controls.Add(this.Label_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_a;
        private System.Windows.Forms.Label Label_b;
        private System.Windows.Forms.Label Label_c;
        private System.Windows.Forms.TextBox a_coeff;
        private System.Windows.Forms.TextBox b_coeff;
        private System.Windows.Forms.TextBox c_coeff;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Label Solution;
        private System.Windows.Forms.Label SolutionText;
    }
}

