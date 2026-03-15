namespace compiler2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.btnScan = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(728, 72);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(442, 484);
            this.txtCode.TabIndex = 0;
            // 
            // dgvTokens
            // 
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Type});
            this.dgvTokens.Location = new System.Drawing.Point(31, 72);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.RowHeadersWidth = 62;
            this.dgvTokens.RowTemplate.Height = 28;
            this.dgvTokens.Size = new System.Drawing.Size(602, 484);
            this.dgvTokens.TabIndex = 1;
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellContentClick);
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnScan.Location = new System.Drawing.Point(558, 590);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(149, 47);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 8;
            this.Token.Name = "Token";
            this.Token.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Token Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(550, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.label1.Size = new System.Drawing.Size(165, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phase1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1220, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.Text = "Team Yousef";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.Button btnScan;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label label1;
    }
}

