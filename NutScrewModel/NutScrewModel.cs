using System;
using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;
using KompasAPI7;

namespace NutScrewModel
{
	public class NutScrewModel
    {
		private KompasObject _kompas = null;
		private ksDocument3D _doc3D;
		private ksPart _doc3DPart;

		public NutScrewModel()
		{
			CreateKompasObject();
		}

		/// <summary>
		/// Create an object of program
		/// </summary>
		/// <returns></returns>
		public void CreateKompasObject()
		{
			if (_kompas == null)
			{
				Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
				_kompas = (KompasObject)Activator.CreateInstance(t);
				_kompas.Visible = true;
				_kompas.ActivateControllerAPI();
			}
			else
			{
				_kompas.Visible = true;
				_kompas.ActivateControllerAPI();
			}
		}

		public int CreateDocument3D()
		{
			_doc3D = (ksDocument3D)_kompas.Document3D();
			
			if (!_doc3D.Create(false/*видимый*/, true /*деталь*/)) return -1;

			return 1;
		}

		/// <summary>
		/// Create test figure
		/// </summary>
		/// <returns></returns>
		public int CreateFigure()
		{
			int state = CreateDocument3D();
			if (state != 1) return state;

			CreateScrewHat();
			

			return 1;
		}

		/// <summary>
		/// Create screw hat with extrusion operations
		/// </summary>
		/// <returns></returns>
		public int CreateScrewHat()
		{
			// Сокращения:
			/* regPoly - Regular Polygon */

			// Новый компонент
			_doc3DPart = (ksPart)_doc3D.GetPart((short)Part_Type.pTop_Part);
			if (_doc3DPart == null) return -2;

			// Эскиз многоугольника
			var regPolySketch = (ksEntity)_doc3DPart.NewEntity((short)Obj3dType.o3d_sketch);
			if (regPolySketch == null) return -3;

			// Свойства эскиза многоугольника, берутся из самогО эскиза
			var regPolySketchDef = (ksSketchDefinition)regPolySketch.GetDefinition();
			if (regPolySketchDef == null) return -4;

			// Базовая плоскость XOY для всего компонента
			var screwHatBasePlane = (ksEntity)_doc3DPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
			if (screwHatBasePlane == null) return -5;
			
			regPolySketchDef.SetPlane(screwHatBasePlane); // устан. плоскость базовой
			regPolySketch.Create();          // создание эскиза

			// Интерфейс редактора эскиза многоугольника
			var regPolySketchEdit = (ksDocument2D)regPolySketchDef.BeginEdit();
			if (regPolySketchEdit == null) return -6;

			// Рисование правильного многоугольника
			ksRegularPolygonParam polyParam;
			polyParam = _kompas.GetParamStruct((short)StructType2DEnum.ko_RegularPolygonParam);
			polyParam.count = 6;        // Количество углов
			polyParam.ang = 0;          // Угол радиус-вектора от центра к первой вершине
			polyParam.describe = true;  // Многоугольник является описанным
			polyParam.radius = 25;      // Радиус вписанной окружности
			polyParam.style = 1;		// Стиль линии, без этой опции многогранник создастся как вспомогательный объект
			polyParam.xc = 0; polyParam.yc = 0; // Координаты относительно плоскости

			// Создание многоугольника на эскизе
			if (regPolySketchEdit.ksRegularPolygon(polyParam, 0) == 0) return -7;
			regPolySketchDef.EndEdit();

			// Эскиз выдавливания многоугольника
			var regPolyExtrusion = (ksEntity)_doc3DPart.NewEntity((short)Obj3dType.o3d_baseExtrusion);
			if (regPolyExtrusion == null) return -8;

			// Интерфейс свойств выдавливания многоугольника
			var regPolyExtrusionDef = (ksBaseExtrusionDefinition)regPolyExtrusion.GetDefinition();
			if (regPolyExtrusion == null) return -9;

			regPolyExtrusionDef.directionType = (short)Direction_Type.dtNormal;	// Направление выдавливания
			regPolyExtrusionDef.SetSideParam(true, (short)ksEndTypeEnum.etBlind, 30, 0, false);
			regPolyExtrusionDef.SetSketch(regPolySketch);	// Установка эскиза выдавливания
			regPolyExtrusion.Create();	// Создание операции

			return 1;
		}
	}
}
