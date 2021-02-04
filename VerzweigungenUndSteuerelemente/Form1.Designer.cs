
namespace VerzweigungenUndSteuerelemente
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.chkBoxOption = new System.Windows.Forms.CheckBox();
			this.btnUmschalten = new System.Windows.Forms.Button();
			this.rBtnRot = new System.Windows.Forms.RadioButton();
			this.rBtnGrün = new System.Windows.Forms.RadioButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.rBtnBlau = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rBtnSchwarz = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rBtnWeiß = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkBoxOption
			// 
			this.chkBoxOption.AutoSize = true;
			this.chkBoxOption.Location = new System.Drawing.Point(13, 13);
			this.chkBoxOption.Name = "chkBoxOption";
			this.chkBoxOption.Size = new System.Drawing.Size(44, 17);
			this.chkBoxOption.TabIndex = 0;
			this.chkBoxOption.Text = "Aus";
			this.chkBoxOption.UseVisualStyleBackColor = true;
			this.chkBoxOption.CheckedChanged += new System.EventHandler(this.chkBoxOption_CheckedChanged);
			// 
			// btnUmschalten
			// 
			this.btnUmschalten.Location = new System.Drawing.Point(12, 47);
			this.btnUmschalten.Name = "btnUmschalten";
			this.btnUmschalten.Size = new System.Drawing.Size(114, 23);
			this.btnUmschalten.TabIndex = 1;
			this.btnUmschalten.Text = "Schalter umschalten";
			this.btnUmschalten.UseVisualStyleBackColor = true;
			this.btnUmschalten.Click += new System.EventHandler(this.btnUmschalten_Click);
			// 
			// rBtnRot
			// 
			this.rBtnRot.AutoSize = true;
			this.rBtnRot.Location = new System.Drawing.Point(6, 19);
			this.rBtnRot.Name = "rBtnRot";
			this.rBtnRot.Size = new System.Drawing.Size(42, 17);
			this.rBtnRot.TabIndex = 2;
			this.rBtnRot.Text = "Rot";
			this.rBtnRot.UseVisualStyleBackColor = true;
			this.rBtnRot.CheckedChanged += new System.EventHandler(this.rBtnRot_CheckedChanged);
			// 
			// rBtnGrün
			// 
			this.rBtnGrün.AutoSize = true;
			this.rBtnGrün.Location = new System.Drawing.Point(6, 42);
			this.rBtnGrün.Name = "rBtnGrün";
			this.rBtnGrün.Size = new System.Drawing.Size(48, 17);
			this.rBtnGrün.TabIndex = 3;
			this.rBtnGrün.Text = "Grün";
			this.rBtnGrün.UseVisualStyleBackColor = true;
			this.rBtnGrün.CheckedChanged += new System.EventHandler(this.rBtnGrün_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(78, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// rBtnBlau
			// 
			this.rBtnBlau.AutoSize = true;
			this.rBtnBlau.Location = new System.Drawing.Point(6, 65);
			this.rBtnBlau.Name = "rBtnBlau";
			this.rBtnBlau.Size = new System.Drawing.Size(46, 17);
			this.rBtnBlau.TabIndex = 5;
			this.rBtnBlau.TabStop = true;
			this.rBtnBlau.Text = "Blau";
			this.rBtnBlau.UseVisualStyleBackColor = true;
			this.rBtnBlau.CheckedChanged += new System.EventHandler(this.rBtnBlau_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rBtnRot);
			this.groupBox1.Controls.Add(this.rBtnBlau);
			this.groupBox1.Controls.Add(this.rBtnGrün);
			this.groupBox1.Location = new System.Drawing.Point(12, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(114, 100);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hintergrundfarbe";
			// 
			// rBtnSchwarz
			// 
			this.rBtnSchwarz.AutoSize = true;
			this.rBtnSchwarz.Location = new System.Drawing.Point(6, 19);
			this.rBtnSchwarz.Name = "rBtnSchwarz";
			this.rBtnSchwarz.Size = new System.Drawing.Size(66, 17);
			this.rBtnSchwarz.TabIndex = 7;
			this.rBtnSchwarz.Text = "Schwarz";
			this.rBtnSchwarz.UseVisualStyleBackColor = true;
			this.rBtnSchwarz.CheckedChanged += new System.EventHandler(this.rBtnSchwarz_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rBtnWeiß);
			this.groupBox2.Controls.Add(this.rBtnSchwarz);
			this.groupBox2.Location = new System.Drawing.Point(155, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(121, 100);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Vordergrundfarbe";
			// 
			// rBtnWeiß
			// 
			this.rBtnWeiß.AutoSize = true;
			this.rBtnWeiß.Location = new System.Drawing.Point(6, 42);
			this.rBtnWeiß.Name = "rBtnWeiß";
			this.rBtnWeiß.Size = new System.Drawing.Size(50, 17);
			this.rBtnWeiß.TabIndex = 8;
			this.rBtnWeiß.Text = "Weiß";
			this.rBtnWeiß.UseVisualStyleBackColor = true;
			this.rBtnWeiß.CheckedChanged += new System.EventHandler(this.rBtnWeiß_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 254);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnUmschalten);
			this.Controls.Add(this.chkBoxOption);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkBoxOption;
		private System.Windows.Forms.Button btnUmschalten;
		private System.Windows.Forms.RadioButton rBtnRot;
		private System.Windows.Forms.RadioButton rBtnGrün;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.RadioButton rBtnBlau;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rBtnSchwarz;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rBtnWeiß;
	}
}

