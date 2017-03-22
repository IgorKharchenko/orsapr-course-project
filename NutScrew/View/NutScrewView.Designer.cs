namespace NutScrew.View
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
			this.RunButton = new System.Windows.Forms.Button();
			this.ScrewHatWidthLabel = new System.Windows.Forms.Label();
			this.ScrewHatInnerCircleLabel = new System.Windows.Forms.Label();
			this.ScrewBaseSmoothPartLabel = new System.Windows.Forms.Label();
			this.ScrewBaseThreadPartLabel = new System.Windows.Forms.Label();
			this.NutThreadDiameter = new System.Windows.Forms.TextBox();
			this.NutHeight = new System.Windows.Forms.TextBox();
			this.ScrewBaseThreadWidth = new System.Windows.Forms.TextBox();
			this.ScrewBaseSmoothWidth = new System.Windows.Forms.TextBox();
			this.ScrewHatInnerDiameter = new System.Windows.Forms.TextBox();
			this.ScrewHatWidth = new System.Windows.Forms.TextBox();
			this.NutThreadDiameterLabel = new System.Windows.Forms.Label();
			this.NutHeightLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Defaults = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CloseKompas3D = new System.Windows.Forms.Button();
			this.UnloadKompasApplicationLabel = new System.Windows.Forms.Label();
			this.LoadKompas3D = new System.Windows.Forms.Button();
			this.LoadKompasAppLabel = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// RunButton
			// 
			this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RunButton.Location = new System.Drawing.Point(151, 457);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(188, 34);
			this.RunButton.TabIndex = 0;
			this.RunButton.Text = "Build nut with screw";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// ScrewHatWidthLabel
			// 
			this.ScrewHatWidthLabel.AutoSize = true;
			this.ScrewHatWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewHatWidthLabel.Location = new System.Drawing.Point(17, 33);
			this.ScrewHatWidthLabel.Name = "ScrewHatWidthLabel";
			this.ScrewHatWidthLabel.Size = new System.Drawing.Size(124, 18);
			this.ScrewHatWidthLabel.TabIndex = 2;
			this.ScrewHatWidthLabel.Text = "Width of hat (W3)";
			// 
			// ScrewHatInnerCircleLabel
			// 
			this.ScrewHatInnerCircleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewHatInnerCircleLabel.Location = new System.Drawing.Point(17, 74);
			this.ScrewHatInnerCircleLabel.Name = "ScrewHatInnerCircleLabel";
			this.ScrewHatInnerCircleLabel.Size = new System.Drawing.Size(180, 22);
			this.ScrewHatInnerCircleLabel.TabIndex = 3;
			this.ScrewHatInnerCircleLabel.Text = "Inner diameter of hat (d)";
			// 
			// ScrewBaseSmoothPartLabel
			// 
			this.ScrewBaseSmoothPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewBaseSmoothPartLabel.Location = new System.Drawing.Point(17, 117);
			this.ScrewBaseSmoothPartLabel.Name = "ScrewBaseSmoothPartLabel";
			this.ScrewBaseSmoothPartLabel.Size = new System.Drawing.Size(180, 22);
			this.ScrewBaseSmoothPartLabel.TabIndex = 5;
			this.ScrewBaseSmoothPartLabel.Text = "Smooth part width (W1)";
			// 
			// ScrewBaseThreadPartLabel
			// 
			this.ScrewBaseThreadPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewBaseThreadPartLabel.Location = new System.Drawing.Point(17, 158);
			this.ScrewBaseThreadPartLabel.Name = "ScrewBaseThreadPartLabel";
			this.ScrewBaseThreadPartLabel.Size = new System.Drawing.Size(164, 22);
			this.ScrewBaseThreadPartLabel.TabIndex = 7;
			this.ScrewBaseThreadPartLabel.Text = "Thread part width (W2)";
			// 
			// NutThreadDiameter
			// 
			this.NutThreadDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NutThreadDiameter.Location = new System.Drawing.Point(242, 62);
			this.NutThreadDiameter.Name = "NutThreadDiameter";
			this.NutThreadDiameter.Size = new System.Drawing.Size(74, 26);
			this.NutThreadDiameter.TabIndex = 17;
			this.NutThreadDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// NutHeight
			// 
			this.NutHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NutHeight.Location = new System.Drawing.Point(242, 24);
			this.NutHeight.Name = "NutHeight";
			this.NutHeight.Size = new System.Drawing.Size(74, 26);
			this.NutHeight.TabIndex = 16;
			this.NutHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// ScrewBaseThreadWidth
			// 
			this.ScrewBaseThreadWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewBaseThreadWidth.Location = new System.Drawing.Point(242, 154);
			this.ScrewBaseThreadWidth.Name = "ScrewBaseThreadWidth";
			this.ScrewBaseThreadWidth.Size = new System.Drawing.Size(74, 26);
			this.ScrewBaseThreadWidth.TabIndex = 15;
			this.ScrewBaseThreadWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// ScrewBaseSmoothWidth
			// 
			this.ScrewBaseSmoothWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewBaseSmoothWidth.Location = new System.Drawing.Point(242, 113);
			this.ScrewBaseSmoothWidth.Name = "ScrewBaseSmoothWidth";
			this.ScrewBaseSmoothWidth.Size = new System.Drawing.Size(74, 26);
			this.ScrewBaseSmoothWidth.TabIndex = 14;
			this.ScrewBaseSmoothWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// ScrewHatInnerDiameter
			// 
			this.ScrewHatInnerDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewHatInnerDiameter.Location = new System.Drawing.Point(242, 70);
			this.ScrewHatInnerDiameter.Name = "ScrewHatInnerDiameter";
			this.ScrewHatInnerDiameter.Size = new System.Drawing.Size(74, 26);
			this.ScrewHatInnerDiameter.TabIndex = 13;
			this.ScrewHatInnerDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// ScrewHatWidth
			// 
			this.ScrewHatWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScrewHatWidth.Location = new System.Drawing.Point(242, 29);
			this.ScrewHatWidth.Name = "ScrewHatWidth";
			this.ScrewHatWidth.Size = new System.Drawing.Size(74, 26);
			this.ScrewHatWidth.TabIndex = 12;
			this.ScrewHatWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberKeyPressed);
			// 
			// NutThreadDiameterLabel
			// 
			this.NutThreadDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NutThreadDiameterLabel.Location = new System.Drawing.Point(17, 66);
			this.NutThreadDiameterLabel.Name = "NutThreadDiameterLabel";
			this.NutThreadDiameterLabel.Size = new System.Drawing.Size(180, 22);
			this.NutThreadDiameterLabel.TabIndex = 10;
			this.NutThreadDiameterLabel.Text = "Smooth part diameter (D)";
			// 
			// NutHeightLabel
			// 
			this.NutHeightLabel.AutoSize = true;
			this.NutHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NutHeightLabel.Location = new System.Drawing.Point(17, 28);
			this.NutHeightLabel.Name = "NutHeightLabel";
			this.NutHeightLabel.Size = new System.Drawing.Size(116, 18);
			this.NutHeightLabel.TabIndex = 9;
			this.NutHeightLabel.Text = "Height of nut (H)";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ScrewHatWidthLabel);
			this.groupBox2.Controls.Add(this.ScrewBaseSmoothPartLabel);
			this.groupBox2.Controls.Add(this.ScrewBaseThreadWidth);
			this.groupBox2.Controls.Add(this.ScrewBaseThreadPartLabel);
			this.groupBox2.Controls.Add(this.ScrewBaseSmoothWidth);
			this.groupBox2.Controls.Add(this.ScrewHatInnerCircleLabel);
			this.groupBox2.Controls.Add(this.ScrewHatInnerDiameter);
			this.groupBox2.Controls.Add(this.ScrewHatWidth);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(9, 132);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(330, 209);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Parameters of screw";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.NutThreadDiameter);
			this.groupBox3.Controls.Add(this.NutHeightLabel);
			this.groupBox3.Controls.Add(this.NutHeight);
			this.groupBox3.Controls.Add(this.NutThreadDiameterLabel);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(9, 347);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(330, 104);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Parameters of nut";
			// 
			// Defaults
			// 
			this.Defaults.Location = new System.Drawing.Point(9, 457);
			this.Defaults.Name = "Defaults";
			this.Defaults.Size = new System.Drawing.Size(119, 34);
			this.Defaults.TabIndex = 19;
			this.Defaults.Text = "Standard parameters";
			this.Defaults.UseVisualStyleBackColor = true;
			this.Defaults.Click += new System.EventHandler(this.Defaults_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CloseKompas3D);
			this.groupBox1.Controls.Add(this.UnloadKompasApplicationLabel);
			this.groupBox1.Controls.Add(this.LoadKompas3D);
			this.groupBox1.Controls.Add(this.LoadKompasAppLabel);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(9, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(330, 114);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kompas Application";
			// 
			// CloseKompas3D
			// 
			this.CloseKompas3D.Location = new System.Drawing.Point(242, 69);
			this.CloseKompas3D.Name = "CloseKompas3D";
			this.CloseKompas3D.Size = new System.Drawing.Size(74, 26);
			this.CloseKompas3D.TabIndex = 5;
			this.CloseKompas3D.Text = "Unload";
			this.CloseKompas3D.UseVisualStyleBackColor = true;
			this.CloseKompas3D.Click += new System.EventHandler(this.CloseCompas3D);
			// 
			// UnloadKompasApplicationLabel
			// 
			this.UnloadKompasApplicationLabel.AutoSize = true;
			this.UnloadKompasApplicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UnloadKompasApplicationLabel.Location = new System.Drawing.Point(17, 73);
			this.UnloadKompasApplicationLabel.Name = "UnloadKompasApplicationLabel";
			this.UnloadKompasApplicationLabel.Size = new System.Drawing.Size(190, 18);
			this.UnloadKompasApplicationLabel.TabIndex = 4;
			this.UnloadKompasApplicationLabel.Text = "Unload Kompas Application";
			// 
			// LoadKompas3D
			// 
			this.LoadKompas3D.Location = new System.Drawing.Point(242, 29);
			this.LoadKompas3D.Name = "LoadKompas3D";
			this.LoadKompas3D.Size = new System.Drawing.Size(74, 26);
			this.LoadKompas3D.TabIndex = 3;
			this.LoadKompas3D.Text = "Load";
			this.LoadKompas3D.UseVisualStyleBackColor = true;
			this.LoadKompas3D.Click += new System.EventHandler(this.LoadCompas3D);
			// 
			// LoadKompasAppLabel
			// 
			this.LoadKompasAppLabel.AutoSize = true;
			this.LoadKompasAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoadKompasAppLabel.Location = new System.Drawing.Point(17, 33);
			this.LoadKompasAppLabel.Name = "LoadKompasAppLabel";
			this.LoadKompasAppLabel.Size = new System.Drawing.Size(176, 18);
			this.LoadKompasAppLabel.TabIndex = 2;
			this.LoadKompasAppLabel.Text = "Load Kompas Application";
			// 
			// NutScrewView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 496);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Defaults);
			this.Controls.Add(this.RunButton);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "NutScrewView";
			this.Text = "Nut with screw";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.Label ScrewHatWidthLabel;
		private System.Windows.Forms.Label ScrewHatInnerCircleLabel;
		private System.Windows.Forms.Label ScrewBaseSmoothPartLabel;
		private System.Windows.Forms.Label ScrewBaseThreadPartLabel;
		private System.Windows.Forms.TextBox NutThreadDiameter;
		private System.Windows.Forms.TextBox NutHeight;
		private System.Windows.Forms.TextBox ScrewBaseThreadWidth;
		private System.Windows.Forms.TextBox ScrewBaseSmoothWidth;
		private System.Windows.Forms.TextBox ScrewHatInnerDiameter;
		private System.Windows.Forms.TextBox ScrewHatWidth;
		private System.Windows.Forms.Label NutThreadDiameterLabel;
		private System.Windows.Forms.Label NutHeightLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button Defaults;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button LoadKompas3D;
		private System.Windows.Forms.Label LoadKompasAppLabel;
		private System.Windows.Forms.Button CloseKompas3D;
		private System.Windows.Forms.Label UnloadKompasApplicationLabel;
	}
}

