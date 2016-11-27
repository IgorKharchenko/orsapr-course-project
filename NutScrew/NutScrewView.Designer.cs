namespace NutScrew
{
	partial class NutScrewView
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
			this.Run = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Run
			// 
			this.Run.Location = new System.Drawing.Point(12, 12);
			this.Run.Name = "Run";
			this.Run.Size = new System.Drawing.Size(187, 42);
			this.Run.TabIndex = 0;
			this.Run.Text = "     И ВО-О-ОТ ТАКОЙ ТАМПОН!     на весь экран";
			this.Run.UseVisualStyleBackColor = true;
			this.Run.Click += new System.EventHandler(this.button1_Click);
			// 
			// NutScrewView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 61);
			this.Controls.Add(this.Run);
			this.Name = "NutScrewView";
			this.Text = "Винт с гайкой";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Run;
	}
}

