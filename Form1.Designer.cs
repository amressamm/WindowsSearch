namespace WindowsSearchApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Top30ResultsOnly = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkPdfOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1400, 750);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearchString
            // 
            this.txtSearchString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchString.Location = new System.Drawing.Point(12, 0);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(588, 29);
            this.txtSearchString.TabIndex = 0;
            this.txtSearchString.TextChanged += new System.EventHandler(this.txtSearchString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Top30ResultsOnly
            // 
            this.Top30ResultsOnly.AutoSize = true;
            this.Top30ResultsOnly.Checked = true;
            this.Top30ResultsOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Top30ResultsOnly.Location = new System.Drawing.Point(1268, 10);
            this.Top30ResultsOnly.Name = "Top30ResultsOnly";
            this.Top30ResultsOnly.Size = new System.Drawing.Size(122, 17);
            this.Top30ResultsOnly.TabIndex = 2;
            this.Top30ResultsOnly.Text = "Top 30 Results Only";
            this.Top30ResultsOnly.UseVisualStyleBackColor = true;
            // 
            // chkPdfOnly
            // 
            this.chkPdfOnly.AutoSize = true;
            this.chkPdfOnly.Checked = true;
            this.chkPdfOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPdfOnly.Location = new System.Drawing.Point(1048, 10);
            this.chkPdfOnly.Name = "chkPdfOnly";
            this.chkPdfOnly.Size = new System.Drawing.Size(71, 17);
            this.chkPdfOnly.TabIndex = 3;
            this.chkPdfOnly.Text = "PDF Only";
            this.chkPdfOnly.UseVisualStyleBackColor = true;
            this.chkPdfOnly.CheckStateChanged += new System.EventHandler(this.chkPdfOnly_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 615);
            this.Controls.Add(this.chkPdfOnly);
            this.Controls.Add(this.Top30ResultsOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchString);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Windows Search Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtSearchString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox Top30ResultsOnly;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.CheckBox chkPdfOnly;
	}
}

