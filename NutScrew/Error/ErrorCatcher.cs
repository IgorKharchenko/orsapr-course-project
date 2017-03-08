using System.Windows.Forms;

namespace NutScrew.Error
{
	/// <summary>
	/// Error catcher class
	/// </summary>
	class ErrorCatcher
	{
		/// <summary>
		/// Show error message in case of error is catched
		/// </summary>
		/// <param name="error"></param>
		public void CatchError(ErrorCodes error)
		{
			MessageBox.Show("Error during build figure. \nThe code of error is " + error, "Error", 
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Show success message in case of no errors are catched
		/// </summary>
		public void CatchSuccess()
		{
			MessageBox.Show("Build successful.", "Success", 
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
