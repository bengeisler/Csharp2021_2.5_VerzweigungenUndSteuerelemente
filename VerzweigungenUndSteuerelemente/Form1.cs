using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerzweigungenUndSteuerelemente
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void chkBoxOption_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoxOption.Checked)
			{
				chkBoxOption.Text = "An";
			}
			else
			{
				chkBoxOption.Text = "Aus";
			}
			// Alternative: Ternärer Operator ? :
			// chkBoxOption.Text = chkBoxOption.Checked ? "An" : "Aus";
		}

		private void btnUmschalten_Click(object sender, EventArgs e)
		{
			// Option 1: if / else
			if (chkBoxOption.Checked)
			{
				chkBoxOption.Checked = false;
			}
			else
			{
				chkBoxOption.Checked = true;
			}

			// Option 2: Ternärer Operator
			chkBoxOption.Checked = chkBoxOption.Checked ? false : true;

			// Option 3: Operator !
			chkBoxOption.Checked = !chkBoxOption.Checked;
		}

		private void rBtnRot_CheckedChanged(object sender, EventArgs e)
		{
			if (rBtnRot.Checked)
			{
				btnUmschalten.BackColor = Color.Red;
			}
		}

		private void rBtnGrün_CheckedChanged(object sender, EventArgs e)
		{
			if (rBtnGrün.Checked)
			{
				btnUmschalten.BackColor = Color.Green;
			}
		}

		private void rBtnBlau_CheckedChanged(object sender, EventArgs e)
		{
			if (rBtnBlau.Checked)
			{
				btnUmschalten.BackColor = Color.Blue;
			}
		}

		private void rBtnSchwarz_CheckedChanged(object sender, EventArgs e)
		{
			if (rBtnSchwarz.Checked) btnUmschalten.ForeColor = Color.Black;
		}

		private void rBtnWeiß_CheckedChanged(object sender, EventArgs e)
		{
			if (rBtnWeiß.Checked) btnUmschalten.ForeColor = Color.White;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			rBtnWeiß.Checked = true;
			rBtnBlau.Checked = true;
		}
	}
}
