namespace compiler_app
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
            txtCode = new TextBox();
            label1 = new Label();
            btnAnalyze = new Button();
            dgvTokens = new DataGridView();
            colToken = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTokens).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(240, 57);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.ScrollBars = ScrollBars.Vertical;
            txtCode.Size = new Size(306, 45);
            txtCode.TabIndex = 0;
            txtCode.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Tiny Code";
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(304, 160);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(172, 45);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += button1_Click;
            // 
            // dgvTokens
            // 
            dgvTokens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTokens.Columns.AddRange(new DataGridViewColumn[] { colToken, colType });
            dgvTokens.Location = new Point(240, 269);
            dgvTokens.Name = "dgvTokens";
            dgvTokens.RowHeadersWidth = 51;
            dgvTokens.Size = new Size(383, 271);
            dgvTokens.TabIndex = 3;
            dgvTokens.CellContentClick += dgvTokens_CellContentClick;
            // 
            // colToken
            // 
            colToken.HeaderText = "Token";
            colToken.MinimumWidth = 6;
            colToken.Name = "colToken";
            colToken.Width = 125;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(dgvTokens);
            Controls.Add(btnAnalyze);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTokens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label1;
        private Button btnAnalyze;
        private DataGridView dgvTokens;
        private DataGridViewTextBoxColumn colToken;
        private DataGridViewTextBoxColumn colType;
    }
}
