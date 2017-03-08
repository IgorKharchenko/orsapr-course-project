using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NutScrew;
using NutScrew.Model;
using NutScrew.Validator;
using NutScrew.Error;

namespace NutScrew.UnitTests
{
	[TestFixture]
	class KompasApplicationTest
	{
		[TestCase(ErrorCodes.OK, 85, 75, 125, 375, 50, 60, TestName = "ConstructKompasApplication, normal parameters")]
		public void ConstructKompasApplication(ErrorCodes res, params double[] parameters)
		{
			var figureParameters = new List<double>();
			for (int i = 0, length = parameters.Length; i < length; i++)
			{
				figureParameters.Add(parameters[i]);
			}

			var app = new KompasApplication();
			app.Parameters = figureParameters;
			Assert.AreEqual(app.LastErrorCode, res);

			Assert.IsTrue(app.CreateDocument3D());
		}

		/// <summary>
		/// Create Kompas application for tests
		/// </summary>
		/// <returns>Kompas application</returns>
		public KompasApplication CreateKompasApplication()
		{
			var parameters = new List<double>() { 85, 75, 125, 375, 50, 60 };
			var app = new KompasApplication();
			app.Parameters = parameters;
			app.CreateDocument3D();

			return app;
		}

		[TestCase(TestName = "DestructKompasApplication, normal parameters")]
		public void DestructKompasApplication()
		{
			var parameters = new List<double>() { 85, 75, 125, 375, 50, 60 };
			var app = new KompasApplication();
			app.Parameters = parameters;

			app.CreateDocument3D();

			app.DestructApp();
		}
	}
}
