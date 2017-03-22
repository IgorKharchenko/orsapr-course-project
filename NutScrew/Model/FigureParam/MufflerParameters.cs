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
	/// Struct of parameters of "Muffler" class.
	/// </summary>
	public struct MufflerParameters
	{
		/// <summary>
		/// Part with detail in 3D document
		/// </summary>
		public ksPart Document3DPart;

		/// <summary>
		/// Axis of base plane of muffler
		/// </summary>
		public Obj3dType BasePlaneAxis;

		/// <summary>
		/// Direction type of muffler
		/// </summary>
		public Direction_Type Direction;

		/// <summary>
		/// Point of base plane of muffler
		/// </summary>
		public KompasPoint2D BasePlanePoint;

		/// <summary>
		/// Muffler parameters
		/// </summary>
		/// <param name="document3DPart">Part with detail in 3D document</param>
		/// <param name="basePlaneAxis">Axis of base plane of muffler</param>
		/// <param name="direction">Direction type of muffler</param>
		/// <param name="basePlanePoint">Point of base plane of muffler</param>
		public MufflerParameters(ksPart document3DPart, Obj3dType basePlaneAxis, Direction_Type direction, KompasPoint2D basePlanePoint)
		{
			Document3DPart = document3DPart;
			BasePlaneAxis = basePlaneAxis;
			Direction = direction;
			BasePlanePoint = basePlanePoint;
		}
    }
}
