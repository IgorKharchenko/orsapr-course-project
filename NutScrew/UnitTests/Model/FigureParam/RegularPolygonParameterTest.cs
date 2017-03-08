using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NutScrew.Model.Entity;
using NutScrew.Validator;
using NutScrew.Error;
using Kompas6Constants3D;
using Kompas6API5;
using NutScrew.Manager;
using NutScrew.Model.FigureParam;
using NutScrew.Model.Point;

namespace NutScrew.UnitTests
{
	[TestFixture]
	class RegularPolygonParameterTest
	{
		[TestCase(ErrorCodes.OK, 3, 10.0, TestName = "RegularPolygonParameter, normal parameters")]
		[TestCase(ErrorCodes.OK, 12, 10.0, TestName = "RegularPolygonParameter, normal parameters")]
		[TestCase(ErrorCodes.ArgumentInvalid, 2, 10.0, TestName = "RegularPolygonParameter, angles count less than 3")]
		[TestCase(ErrorCodes.ArgumentInvalid, 13, 10.0, TestName = "RegularPolygonParameter, angles count more than 12")]
		[TestCase(ErrorCodes.ArgumentInvalid, 0, 0.0, TestName = "RegularPolygonParameter, parameters = zero")]
		[TestCase(ErrorCodes.ArgumentInvalid, -2, -1.0, TestName = "RegularPolygonParameter, parameters less than zero")]
		[TestCase(ErrorCodes.ArgumentInvalid, int.MinValue, double.MinValue, TestName = "RegularPolygonParameter, min values")]
		[TestCase(ErrorCodes.ArgumentInvalid, int.MaxValue, double.MaxValue, TestName = "RegularPolygonParameter, max values")]
		[TestCase(ErrorCodes.ArgumentInvalid, 9, double.NaN, TestName = "RegularPolygonParameter, double not a number values")]
		[TestCase(ErrorCodes.ArgumentInvalid, 9, double.NegativeInfinity, TestName = "RegularPolygonParameter, double infinity values")]
		public void RegPolyParameterNormal(ErrorCodes errorCode, int anglesCount, double inscribedCircleRadius)
		{
			var appTest = new KompasApplicationTest();
			var app = appTest.CreateKompasApplication();

			var sketch = new KompasSketch(app.ScrewPart, Obj3dType.o3d_planeXOZ);
			var sketchEdit = sketch.BeginEntityEdit();

			var rectangleParam = new RegularPolygonParameter(app, anglesCount, inscribedCircleRadius, new KompasPoint2D(0.0, 0.0));
			sketchEdit.ksRectangle(rectangleParam.FigureParam);
			sketch.EndEntityEdit();

			Assert.AreEqual(rectangleParam.LastErrorCode, errorCode);
		}
	}
}
