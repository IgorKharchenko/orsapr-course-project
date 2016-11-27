using System;
using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;
using KompasAPI7;

namespace NutScrewModel
{
	public class NutScrewModel
    {
		private KompasObject kompas = null;
		private ksDocument3D doc3D;

		public int Creator()
		{
			var state = CreateDocument();
			if (state != 1)
			{
				kompas.Quit();
				return state;
			}

			return 1;
		}

		public int CreateDocument()
		{
			// 1. Создание объекта программы
			if (kompas == null)
			{
				Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
				kompas = (KompasObject)Activator.CreateInstance(t);
				kompas.Visible = true;
				kompas.ActivateControllerAPI();
			}
			else
			{
				kompas.Visible = true;
				kompas.ActivateControllerAPI();
			}

			doc3D = (ksDocument3D)kompas.Document3D();

			doc3D.Create();
			// if (!doc3D.Create(false/*видимый*/, true /*деталь*/)) return -1;

			// Новый компонент
			var part = (ksPart)doc3D.GetPart((short)Part_Type.pNew_Part);
			if (part == null) return -2;
			
			// Эскиз
			var entitySketch = (ksEntity)part.NewEntity((short)Obj3dType.o3d_sketch);
			if (entitySketch == null) return -3;
			
			// Свойства эскиза, берутся из самогО эскиза
			var sketchDef = (ksSketchDefinition)entitySketch.GetDefinition();
			if (sketchDef == null) return -4;

			// Базовая плоскость XOY
			//var basePlane = (ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
			//if (basePlane == null) return -5;

			sketchDef.SetPlane((ksEntity)part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY));	// устан. плоскость базовой
			entitySketch.Create();			// создание эскиза

			var doc2D = (ksDocument2D)sketchDef.BeginEdit();

			// Рисование правильного многоугольника
			ksRegularPolygonParam polyParam;
			polyParam = kompas.GetParamStruct((short)92);
			polyParam.count = 8;		// Количество углов
			polyParam.ang = 0;			// Угол радиус-вектора от центра к первой вершине
			polyParam.describe = true;	// Многоугольник является описанным
			polyParam.radius = 25;		// Радиус вписанной окружности
			polyParam.xc = 0; polyParam.yc = 0; // Координаты относительно плоскости

			doc2D.ksRegularPolygon(polyParam, 0);

			sketchDef.EndEdit();

			return 1;
		}

	}
}
