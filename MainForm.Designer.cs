namespace Calculator
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_CE, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_C, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_div, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_mult, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_sub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_plus, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 99);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 276);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_CE
            // 
            this.btn_CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CE.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CE.Location = new System.Drawing.Point(3, 3);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(63, 63);
            this.btn_CE.TabIndex = 0;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_C.Location = new System.Drawing.Point(72, 3);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(63, 63);
            this.btn_C.TabIndex = 1;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clr.Location = new System.Drawing.Point(141, 3);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(63, 63);
            this.btn_clr.TabIndex = 2;
            this.btn_clr.Text = "<";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_div
            // 
            this.btn_div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_div.Location = new System.Drawing.Point(210, 3);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(63, 63);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_7
            // 
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(3, 72);
            this.btn_7.Name = "btn_7";
            this.btn_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_7.Size = new System.Drawing.Size(63, 63);
            this.btn_7.TabIndex = 4;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(72, 72);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(63, 63);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mult.Location = new System.Drawing.Point(210, 72);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(63, 63);
            this.btn_mult.TabIndex = 7;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_9
            // 
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(141, 72);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(63, 63);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_4
            // 
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(3, 141);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(63, 63);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(72, 141);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(63, 63);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(141, 141);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(63, 63);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sub.Location = new System.Drawing.Point(210, 141);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(63, 63);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(3, 210);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(63, 63);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(72, 210);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(63, 63);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(141, 210);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(63, 63);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_plus.Location = new System.Drawing.Point(210, 210);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(63, 63);
            this.btn_plus.TabIndex = 16;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_dot, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_0, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_result, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 375);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 67);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_dot
            // 
            this.btn_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dot.Location = new System.Drawing.Point(3, 3);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(63, 61);
            this.btn_dot.TabIndex = 0;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_0
            // 
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(72, 3);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(63, 61);
            this.btn_0.TabIndex = 1;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_result
            // 
            this.btn_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_result.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_result.Location = new System.Drawing.Point(141, 3);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(132, 61);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(15, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(270, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(15, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(270, 51);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 448);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 487);
            this.MinimumSize = new System.Drawing.Size(314, 487);
            this.Name = "MainForm";
            this.Text = "MyCalculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_CE;
        private Button btn_C;
        private Button btn_clr;
        private Button btn_div;
        private Button btn_7;
        private Button btn_8;
        private Button btn_mult;
        private Button btn_9;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_sub;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_plus;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_dot;
        private Button btn_0;
        private Button btn_result;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}