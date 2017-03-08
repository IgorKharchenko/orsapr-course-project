using System;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using NutScrew.Model;
using NutScrew.Manager;
using NutScrew.Validator;
using NutScrew.Error;

namespace NutScrew.View
{
	/// <summary>
	/// Main form of program
	/// </summary>
	public partial class NutScrewView : Form
	{
		/// <summary>
		/// Kompas object manager
		/// </summary>
		private KompasApplication _kompasApp;

		/// <summary>
		/// Figure build manager
		/// </summary>
		private BuildManager _buildManager;

		/// <summary>
		/// Figure parameters
		/// </summary>
		private List<double> _figureParameters;

		/// <summary>
		/// Nut screw view form constructor
		/// </summary>
		public NutScrewView()
		{
			InitializeComponent();

			#if !DEBUG
			// "Defaults" button need for set default figure parameters
			Defaults.Visible = false;
			#endif

			CloseKompas3D.Enabled = false;
			RunButton.Enabled = false;
			SetAllInputsEnabledState(false);

			// Set culture info for current thread
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		}

		/// <summary>
		/// Set state to all inputs "Enabled" property
		/// </summary>
		/// <param name="state">State of "Enabled" property</param>
		private void SetAllInputsEnabledState(bool state)
		{
			// >_<
			foreach (Control control in Controls)
			{
				if (control.GetType() == typeof(GroupBox))
				{
					foreach (Control textbox in control.Controls)
					{
						if (textbox.GetType() == typeof(TextBox))
						{
							textbox.Enabled = state;
						}
					}
				}
			}
		}

		/// <summary>
		/// Set figure parameters
		/// </summary>
		/// <returns>true if operation successful; false in case of error</returns>
		private bool SetFigureParameters()
		{
			try
			{
				var screwHatWidth = Convert.ToDouble(ScrewHatWidth.Text);
				var screwHatInnerDiameter = Convert.ToDouble(ScrewHatInnerDiameter.Text);
				var screwBaseSmoothWidth = Convert.ToDouble(ScrewBaseSmoothWidth.Text);
				var screwBaseThreadWidth = Convert.ToDouble(ScrewBaseThreadWidth.Text);
				var nutHeight = Convert.ToDouble(NutHeight.Text);
				var nutThreadDiameter = Convert.ToDouble(NutThreadDiameter.Text);

				var parameters = new List<double>() {screwHatWidth, screwHatInnerDiameter, screwBaseSmoothWidth,
				screwBaseThreadWidth, nutHeight, nutThreadDiameter };

				var validator = new FigureParametersValidator(parameters);
				if (validator.LastErrorCode != ErrorCodes.OK)
				{
					return false;
				}

				if (!validator.Validate())
				{
					var errorCatcher = new UserInputErrorCatcher();
					errorCatcher.CatchError(validator.ErrorList);

					return false;
				}

				_figureParameters = parameters;
			}
			catch
			{
				MessageBox.Show("There are some empty or invalid fields. Please fill him correctly and try again.", "Information",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return false;
			}

			return true;
		}

		/// <summary>
		/// Validate user input parameters and build figure after that
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RunButton_Click(object sender, EventArgs e)
		{
			var errorCatcher = new ErrorCatcher();

			if (_kompasApp == null)
			{
				MessageBox.Show("Load KOMPAS 3D first.", "Information",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				return;
			}

			if (!SetFigureParameters())
			{
				return;
			}

			_kompasApp.Parameters = _figureParameters;

			// Create 3D document
			if (!_kompasApp.CreateDocument3D())
			{
				return;
			}

			// Create build manager
			_buildManager = new BuildManager(_kompasApp);
			if (_buildManager == null)
			{
				errorCatcher.CatchError(ErrorCodes.ManagerCreatingError);
				return;
			}
			if (_buildManager.LastErrorCode != ErrorCodes.OK)
			{
				errorCatcher.CatchError(_buildManager.LastErrorCode);
				return;
			}

			_buildManager.CreateDetail();

			if (_buildManager.LastErrorCode != ErrorCodes.OK)
			{
				errorCatcher.CatchError(_buildManager.LastErrorCode);
			}
			else
			{
				errorCatcher.CatchSuccess();
			}
		}

		/// <summary>
		/// Load Kompas 3D and set kompas object to controller
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadCompas3D(object sender, EventArgs e)
		{
			if (LoadKompas3D.Enabled)
			{
				var errorCatcher = new ErrorCatcher();

				// Create Kompas application specimen
				_kompasApp = new KompasApplication();
				if (_kompasApp == null)
				{
					errorCatcher.CatchError(ErrorCodes.KompasObjectCreatingError);
				}
				if (_kompasApp.LastErrorCode != ErrorCodes.OK)
				{
					errorCatcher.CatchError(_kompasApp.LastErrorCode);
					return;
				}

				SetAllInputsEnabledState(true);

				RunButton.Enabled = true;

				LoadKompas3D.Enabled = false;
				CloseKompas3D.Enabled = true;
			}
		}
		
		/// <summary>
		/// Unset Kompas 3D object from controller
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseCompas3D(object sender, EventArgs e)
		{
			if (!LoadKompas3D.Enabled)
			{
				_kompasApp.DestructApp();

				SetAllInputsEnabledState(false);

				RunButton.Enabled = false;

				LoadKompas3D.Enabled = true;
				CloseKompas3D.Enabled = false;
			}
		}

		/// <summary>
		/// Sends control to class for user input validation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckNumberKeyPressed(object sender, KeyPressEventArgs e)
		{
			UserInputValidation.CheckNumberKeyPressed(sender, e);
		}

		/// <summary>
		/// Set standart parameters
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Defaults_Click(object sender, EventArgs e)
		{
			ScrewHatWidth.Text = "85";
			ScrewHatInnerDiameter.Text = "75";
			ScrewBaseSmoothWidth.Text = "125";
			ScrewBaseThreadWidth.Text = "375";
			NutHeight.Text = "50";
			NutThreadDiameter.Text = "60";
		}

		// Need to delete this dich'
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
