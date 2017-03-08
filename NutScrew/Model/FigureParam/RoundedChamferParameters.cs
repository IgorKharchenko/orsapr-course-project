using Kompas6API5;
using Kompas6Constants3D;
using NutScrew.Model.Point;
using NutScrew.Model.FigureParam;
using NutScrew.Model.Entity;
using NutScrew.Error;
using NutScrew.Validator;

namespace NutScrew.Model.FigureParam
{
	/// <summary>
	/// Parameters for "Rounded chamfer" class
	/// </summary>
	public struct RoundedChamferParameters
	{
		/// <summary>
		/// Part with detail in 3D document
		/// </summary>
		public ksPart Document3DPart;

		/// <summary>
		/// Sketch of regular polygon -- base of rounded chamfer
		/// </summary>
		public ksEntity RegularPolygonSketch;

		/// <summary>
		/// Parameters of regular polygon -- base of rounded chamfer
		/// </summary>
		public RegularPolygonParameter RegularPolygonParameters;

		/// <summary>
		/// 2D point of base plane
		/// </summary>
		public KompasPoint2D BasePlanePoint;

		/// <summary>
		/// Direction of rounded chamfer
		/// </summary>
		public Direction_Type Direction;

		/// <summary>
		/// Rounded chamfer parameters
		/// </summary>
		/// <param name="document3DPart">Part with detail in 3D document</param>
		/// <param name="regularPolygonSketch">Sketch of regular polygon -- base of rounded chamfer</param>
		/// <param name="regularPolygonParameters">Parameters of regular polygon -- base of rounded chamfer</param>
		/// <param name="basePlanePoint">2D point of base plane</param>
		/// <param name="direction">Direction of rounded chamfer</param>
		public RoundedChamferParameters(ksPart document3DPart, ksEntity regularPolygonSketch, RegularPolygonParameter regularPolygonParameters, KompasPoint2D basePlanePoint, Direction_Type direction)
		{
			Document3DPart = document3DPart;
			RegularPolygonSketch = regularPolygonSketch;
			RegularPolygonParameters = regularPolygonParameters;
			BasePlanePoint = basePlanePoint;
			Direction = direction;
		}
    }
}
