namespace SOLID.SampleApp
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
			this.SelectedFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.FindFile = new System.Windows.Forms.Button();
			this.Send = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Output = new System.Windows.Forms.Label();
			this.SendFromDatabase = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SelectedFile
			// 
			this.SelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.SelectedFile.Location = new System.Drawing.Point(44, 12);
			this.SelectedFile.Name = "SelectedFile";
			this.SelectedFile.ReadOnly = true;
			this.SelectedFile.Size = new System.Drawing.Size(408, 20);
			this.SelectedFile.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "File:";
			// 
			// FindFile
			// 
			this.FindFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FindFile.Location = new System.Drawing.Point(458, 10);
			this.FindFile.Name = "FindFile";
			this.FindFile.Size = new System.Drawing.Size(25, 23);
			this.FindFile.TabIndex = 2;
			this.FindFile.Text = "...";
			this.FindFile.UseVisualStyleBackColor = true;
			this.FindFile.Click += new System.EventHandler(this.FindFile_Click);
			// 
			// Send
			// 
			this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Send.Location = new System.Drawing.Point(489, 10);
			this.Send.Name = "Send";
			this.Send.Size = new System.Drawing.Size(61, 23);
			this.Send.TabIndex = 3;
			this.Send.Text = "Send";
			this.Send.UseVisualStyleBackColor = true;
			this.Send.Click += new System.EventHandler(this.Send_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.Output);
			this.groupBox1.Location = new System.Drawing.Point(12, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(538, 255);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Output";
			// 
			// Output
			// 
			this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Output.Location = new System.Drawing.Point(3, 16);
			this.Output.Name = "Output";
			this.Output.Size = new System.Drawing.Size(532, 236);
			this.Output.TabIndex = 0;
			// 
			// SendFromDatabase
			// 
			this.SendFromDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SendFromDatabase.Location = new System.Drawing.Point(12, 38);
			this.SendFromDatabase.Name = "SendFromDatabase";
			this.SendFromDatabase.Size = new System.Drawing.Size(125, 23);
			this.SendFromDatabase.TabIndex = 5;
			this.SendFromDatabase.Text = "Send From Database";
			this.SendFromDatabase.UseVisualStyleBackColor = true;
			this.SendFromDatabase.Click += new System.EventHandler(this.SendFromDatabase_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 337);
			this.Controls.Add(this.SendFromDatabase);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Send);
			this.Controls.Add(this.FindFile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SelectedFile);
			this.Name = "Form1";
			this.Text = "Read File - Send Email";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SelectedFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button FindFile;
		private System.Windows.Forms.Button Send;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label Output;
		private System.Windows.Forms.Button SendFromDatabase;
	}
}