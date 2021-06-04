using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace Draw_figures
{
	public enum FigureName { Rectangle, Ellipse, Polygon, Curve, undef };
	public class MainDraw
    {

		protected Point ancor;
		protected Size size;
		protected Pen pen;
		protected SolidBrush brush;
		protected Point[] points;
		protected bool input_wrong=true;
		protected FigureName figureName;
		protected bool is_polygon;
		public MainDraw()
		{
			
			SetDimensions();
			SetColors(Color.Empty, 1, Color.Empty);
			Point[] pp = new Point[0];
			SetPoints(pp);
   
		}
		public MainDraw(int aX, int aY, int sW, int sH, Color PenColor, int penThick, Color FillColor)
		{
			
			SetDimensions(aX, aY, sW, sH);
			Point[] pp = new Point[0];
			SetPoints(pp);
			SetColors(PenColor, penThick, FillColor);
		}
		public MainDraw(Color PenColor, int penThick, Color FillColor)
		{
			
			SetColors(PenColor, penThick, FillColor);
		}
		public MainDraw(Point[] p_points, Color PenColor, int penThick, Color FillColor)
        {
			SetColors(PenColor, penThick, FillColor);
			points = p_points;
		}
		public MainDraw(Point[] p_points, Color PenColor, int penThick)
		{
			pen = new Pen(PenColor, penThick);
			points = p_points;
		}
		public MainDraw( Color PenColor, int penThick)
		{
			pen = new Pen(PenColor, penThick);
		}
		public MainDraw(int aX, int aY, int sW, int sH)
        {
			SetDimensions(aX, aY, sW, sH);
		}
		public MainDraw(Point[] p_points)
        {
			points = p_points;
		}


		public void Draw(Control control)
		{
			Graphics canvas = control.CreateGraphics();
			DrawFigure(canvas);
		}
		public virtual void DrawFigure(Graphics canvas)
		{

		}


		public void SetPoints(Point[] p_points)
        {
			points = p_points;
        }
		public void SetDimensions (int aX=10, int aY=10, int width=300, int height=300)
        {
			ancor.X = aX;
			ancor.Y = aY;
			size.Width = width;
			size.Height = height;
		}
		public void SetColors(Color PenColor, int penThick, Color FillColor)
        {
			pen = new Pen(PenColor, penThick);
			brush = new SolidBrush(FillColor);
		}
		public void SetPointsList (string[] strList)
        {
			List<Point> vertex;
			vertex = new List<Point> { };
			char[] separator = { ';' };
			for (int i = 0; i < strList.Length; i++)
			{
				string[] XY = strList[i].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				if (XY.Length == 2)
				{
					try
					{
						int x = Convert.ToInt32(XY[0]);
						int y = Convert.ToInt32(XY[1]);
						vertex.Add(new Point(x, y));
					}
					catch
					{ input_wrong = false; }
				}
			}
			points = vertex.ToArray();
		}
		public void SetFigureName(string name)
        {
			
        }

		public Point[] GetPoints ()
        {
			return points;
        }
		public Point GetAnchor ()
        {
			return ancor;
        }
		public Size GetSize ()
        {
			return size;
        }
		public Pen GetPen ()
        {
			return pen;
        }
		public SolidBrush GetBrush ()
        {
			return brush;
        }
		public string GetFigureName ()
        {
			string name;
			if (figureName == FigureName.Rectangle)
				name = "Rectangle";
			else if (figureName == FigureName.Ellipse)
				name = "Ellipse";
			else if (figureName == FigureName.Polygon)
				name = "Polygon";
			else if (figureName == FigureName.Curve)
				name = "Curve";
			else
				name = "Unnown";
			return name;
        }
		public bool Is_Input_Correct ()
        {
			return input_wrong;
        }
		public bool Is_Polygon ()
        {
			return is_polygon;
        }
	}
	public class drElipse : MainDraw
	{
		public drElipse() : base()
		{
			figureName = FigureName.Ellipse;
			is_polygon=false;
		}
		public drElipse(int aX, int aY, int sW, int sH, Color PenColor, int penThick, Color FillColor) : base( aX, aY, sW, sH, PenColor, penThick, FillColor)
		{
			figureName = FigureName.Ellipse;
			is_polygon = false;
		}
		public drElipse(int aX, int aY, int sW, int sH):base (aX, aY, sW, sH)
        {
			figureName = FigureName.Ellipse;
			is_polygon = false;
		}


		public override void DrawFigure(Graphics canvas)
		{
			canvas.FillEllipse(brush, new Rectangle(ancor, size));
			canvas.DrawEllipse(pen, new Rectangle(ancor, size));
		}
	}
	public class drRectangle : MainDraw
	{
		public drRectangle() : base()
		{
			figureName = FigureName.Rectangle;
			is_polygon = false;
		}
		public drRectangle(int aX, int aY, int sW, int sH, Color PenColor, int penThick, Color FillColor) : base(aX, aY, sW, sH, PenColor, penThick, FillColor)
		{
			figureName = FigureName.Rectangle;
			is_polygon = false;
		}
		public drRectangle(int aX, int aY, int sW, int sH) : base(aX, aY, sW, sH)
		{
			figureName = FigureName.Rectangle;
			is_polygon = false;
		}

		public override void DrawFigure(Graphics canvas)
		{
			canvas.FillRectangle(brush, new Rectangle(ancor, size));
			canvas.DrawRectangle(pen, new Rectangle(ancor, size));
		}
	}

	public class drPolygon : MainDraw
	{
		public drPolygon() : base()
		{
			figureName = FigureName.Polygon;
			is_polygon = true;
		}
		public drPolygon(string[] strlist, Color PenColor, int penThick, Color FillColor) : base(PenColor, penThick, FillColor)
		{
			figureName = FigureName.Polygon;
			is_polygon = true;
			SetPointsList(strlist);
		}
		public drPolygon(Point[] p_points, Color PenColor, int penThick, Color FillColor) : base(p_points, PenColor, penThick, FillColor)
		{
			figureName = FigureName.Polygon;
			is_polygon = true;
		}
		public drPolygon(Point[] p_points): base(p_points)
        {
			figureName = FigureName.Polygon;
			is_polygon = true;
		}
		
        public override void DrawFigure(Graphics canvas)
        {
			canvas.FillPolygon(brush, points);
			canvas.DrawPolygon(pen, points);
        }
    }

	public class drCurve : MainDraw
    {
		public drCurve() : base()
			{
				figureName = FigureName.Curve;
				is_polygon = true;
		}
		public drCurve(Point[] p_points, Color PenColor, int penThick) : base(p_points, PenColor, penThick)
        {
			figureName = FigureName.Curve;
			is_polygon = true;
		}
		public drCurve(String[] strlist, Color PenColor, int penThick) : base(PenColor, penThick)
		{
			figureName = FigureName.Curve;
			is_polygon = true;
			SetPointsList(strlist);
		}
		public drCurve(Point[] p_points) : base(p_points)
		{
			figureName = FigureName.Curve;
			is_polygon = true;
		}

		public override void DrawFigure(Graphics canvas)
        {
            base.DrawFigure(canvas);
            {
				canvas.DrawCurve(pen, points);
            }			
        }
    }
}


