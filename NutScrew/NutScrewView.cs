using System;
using System.Windows.Forms;
using NutScrewModel;

namespace NutScrew
{
	public partial class NutScrewView : Form
	{
		public NutScrewView()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var model = new NutScrewModel.NutScrewModel();
			var state = model.CreateDocument();
			
			if (state != 1)
			{
				Console.WriteLine("Return code " + state);
			}
		}
	}
}
