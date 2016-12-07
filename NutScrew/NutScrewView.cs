using System;
using System.Windows.Forms;
using NutScrewModel;

namespace NutScrew
{
	public partial class NutScrewView : Form
	{
		private NutScrewModel.NutScrewModel model;

		public NutScrewView()
		{
			InitializeComponent();
			model = new NutScrewModel.NutScrewModel();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int state = model.CreateFigure();
			
			if (state != 1)
			{
				Console.WriteLine("Return code " + state);
			}
		}
	}
}
