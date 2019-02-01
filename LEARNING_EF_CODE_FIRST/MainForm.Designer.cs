namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.countryNameTextBox = new System.Windows.Forms.TextBox();
			this.countryCodeFromTextBox = new System.Windows.Forms.TextBox();
			this.countryCodeToTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.countriesListBox = new System.Windows.Forms.ListBox();
			this.recordCountLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// countryNameTextBox
			// 
			this.countryNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.countryNameTextBox.Location = new System.Drawing.Point(12, 12);
			this.countryNameTextBox.Name = "countryNameTextBox";
			this.countryNameTextBox.Size = new System.Drawing.Size(266, 20);
			this.countryNameTextBox.TabIndex = 0;
			// 
			// countryCodeFromTextBox
			// 
			this.countryCodeFromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.countryCodeFromTextBox.Location = new System.Drawing.Point(12, 38);
			this.countryCodeFromTextBox.Name = "countryCodeFromTextBox";
			this.countryCodeFromTextBox.Size = new System.Drawing.Size(266, 20);
			this.countryCodeFromTextBox.TabIndex = 1;
			// 
			// countryCodeToTextBox
			// 
			this.countryCodeToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.countryCodeToTextBox.Location = new System.Drawing.Point(12, 64);
			this.countryCodeToTextBox.Name = "countryCodeToTextBox";
			this.countryCodeToTextBox.Size = new System.Drawing.Size(266, 20);
			this.countryCodeToTextBox.TabIndex = 2;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(12, 90);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 3;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// countriesListBox
			// 
			this.countriesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.countriesListBox.FormattingEnabled = true;
			this.countriesListBox.Location = new System.Drawing.Point(12, 119);
			this.countriesListBox.Name = "countriesListBox";
			this.countriesListBox.Size = new System.Drawing.Size(266, 134);
			this.countriesListBox.TabIndex = 4;
			// 
			// recordCountLabel
			// 
			this.recordCountLabel.AutoSize = true;
			this.recordCountLabel.Location = new System.Drawing.Point(93, 95);
			this.recordCountLabel.Name = "recordCountLabel";
			this.recordCountLabel.Size = new System.Drawing.Size(22, 13);
			this.recordCountLabel.TabIndex = 5;
			this.recordCountLabel.Text = "-----";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 262);
			this.Controls.Add(this.recordCountLabel);
			this.Controls.Add(this.countriesListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.countryCodeToTextBox);
			this.Controls.Add(this.countryCodeFromTextBox);
			this.Controls.Add(this.countryNameTextBox);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox countryNameTextBox;
		private System.Windows.Forms.TextBox countryCodeFromTextBox;
		private System.Windows.Forms.TextBox countryCodeToTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ListBox countriesListBox;
		private System.Windows.Forms.Label recordCountLabel;
	}
}
