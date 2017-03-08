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
	/// <summary>
	/// Test for "FigureParameters" class
	/// </summary>
	[TestFixture]
	class FigureParametersTest
	{
		/// <summary>
		/// Parameters validation test
		/// </summary>
		/// <param name="expected">Expected state of validation: true or false</param>
		/// <param name="parameters">Parameters of figure</param>
		[TestCase(false, 850000,  750000,  1250000, 3750000, 500000,  600000,  TestName = "FigureParameters, very high values (10^^4)")]
		[TestCase(false, 85000,   75000,   125000,  375000,  50000,   60000,   TestName = "FigureParameters, very high values (10^^3)")]
		[TestCase(false, 8500,    7500,    12500,   37500,   5000,    6000,    TestName = "FigureParameters, high values      (10^^2)")]
		[TestCase(true,  850,     750,     1250,    3750,    500,     600,     TestName = "FigureParameters, normal values    (10)")]
		[TestCase(true,  85,      75,      125,     375,     50,      60,      TestName = "FigureParameters, normal values    (1)")]
		[TestCase(true,  0.85,    0.75,    1.25,    3.75,    0.50,    0.60,    TestName = "FigureParameters, very low values  (0.1)")]
		[TestCase(false, 0.085,   0.075,   0.125,   0.375,   0.050,   0.060,   TestName = "FigureParameters, very low values  (0.01)")]
		[TestCase(false, 0.0085,  0.0075,  0.0125,  0.0375,  0.0050,  0.0060,  TestName = "FigureParameters, very low values  (0.001)")]
		[TestCase(false, 0.00085, 0.00075, 0.00125, 0.00375, 0.00050, 0.00060, TestName = "FigureParameters, very low values  (0.0001)")]
		[TestCase(false, 100500,  33375,   128325,  37135,   52340,   60,      TestName = "FigureParameters, incorrect values")]
		[TestCase(false, double.NegativeInfinity, double.PositiveInfinity, double.NegativeInfinity, double.PositiveInfinity, double.NegativeInfinity, double.PositiveInfinity, TestName = "FigureParameters, incorrect values")]
		[TestCase(false, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, TestName = "FigureParameters, incorrect values")]
		[TestCase(false, double.MaxValue + 1, double.MinValue - 1, double.MinValue - 1, double.MaxValue + 1, double.MaxValue + 1, double.MinValue - 1, TestName = "FigureParameters, max and min values")]
		[TestCase(false, null, null, null, null, null, null, TestName = "FigureParameters, null values")]
		public void Normal(bool expected, params double[] parameters)
		{
			var figureParameters = new List<double>();
			for (int i = 0, length = parameters.Length; i < length; i++)
			{
				figureParameters.Add(parameters[i]);
			}

			var validator = new FigureParametersValidator(figureParameters);
			Assert.AreEqual(validator.Validate(), expected);
		}
	}
}
