using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Draw_figures
{
    public partial class MainForm : Form
    {
        public List<MainDraw> allFigures = new List<MainDraw> { };
        public void Rerfresh()
        {
            if (allFigures.Count > 0)
            {
                pbMain.Refresh();
                foreach (MainDraw fig in allFigures)
                    fig.Draw(pbMain);
            }
        }


        public MainForm()
        {
            InitializeComponent();
            cbForm.SelectedIndex = 0;

            Dictionary<FigureName, string> figure_names = new Dictionary<FigureName, string>
            {
                {FigureName.Ellipse, "Овал"},
                {FigureName.Rectangle, "Прямоугольник" },
                {FigureName.Polygon, "Многоугольник" },
                {FigureName.Curve, "Кривая" },
            };
        }

        private MainDraw get_figure(FigureName fig_type, Point point, Size size, Point[] points, Pen pen, SolidBrush brush)
        {
            MainDraw shape;

            switch (fig_type)
            {
                case FigureName.Rectangle:
                    {
                        shape = new drRectangle(point.X, point.Y, size.Width, size.Height);
                        break;
                    }
                case FigureName.Ellipse:
                    {
                        shape = new drElipse(point.X, point.Y, size.Width, size.Height);
                        break;
                    }
                case FigureName.Polygon:
                    {
                        shape = new drPolygon(points);
                        break;
                    }
                case FigureName.Curve:
                    {
                        shape = new drCurve(points);
                        break;
                    }
                default:
                    {
                        shape = null;
                        break;
                    }

            }
            if (shape != null)
            {
                shape.SetColors(pen.Color, (int)pen.Width, brush.Color);
            }
            return shape;
        }
        private void cbForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDraw.Enabled = true;

        }

        private void bPenColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdPen.ShowDialog() == DialogResult.OK)
            {
                pPenColor.BackColor = cdPen.Color;
            }
        }

        private void bBrushColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdBrush.ShowDialog() == DialogResult.OK)
            {
                pBrushColor.BackColor = cdBrush.Color;
            }
        }

        private void bDraw_MouseClick(object sender, MouseEventArgs e)
        {
            Color clPen;
            Color clFill;
            if (cbPen.Checked == true)
                clPen = Color.Empty;
            else
                clPen = pPenColor.BackColor;
            if (cbFill.Checked == true)
                clFill = Color.Empty;
            else
                clFill = pBrushColor.BackColor;
            MainDraw figure;

            Point[] fgPoints = new Point[tbPolygon.Lines.Length];
            char[] separator = { ';' };
            int validCount = 0;
            for (int i = 0; i < tbPolygon.Lines.Length; i++)
            {
                string[] XY = tbPolygon.Lines[i].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                if (XY.Length == 2)
                {
                    try
                    {
                        int x = Convert.ToInt32(XY[0]);
                        int y = Convert.ToInt32(XY[1]);
                        fgPoints[validCount] = new Point(x, y);
                        validCount++;
                    }
                    catch
                    { }
                }
            }
            Array.Resize(ref fgPoints, validCount);

            switch ((int)cbForm.SelectedIndex)
            {
                case 0:
                    {
                        figure = new drRectangle((int)UDCoordinateX.Value, (int)UDCoordinateY.Value, (int)UDSIzeWidth.Value, (int)UDSizeHeight.Value, clPen, (int)tbPenThick.Value, clFill);
                        figure.Draw(pbMain);
                        allFigures.Add(figure);
                        break;
                    }
                case 1:
                    {
                        figure = new drElipse((int)UDCoordinateX.Value, (int)UDCoordinateY.Value, (int)UDSIzeWidth.Value, (int)UDSizeHeight.Value, clPen, (int)tbPenThick.Value, clFill);
                        figure.Draw(pbMain);
                        allFigures.Add(figure);
                        break;
                    }
                case 2:
                    {
                        if (tbPolygon.Lines.Length > 0)
                        {
                            figure = new drPolygon(tbPolygon.Lines, clPen, (int)tbPenThick.Value, clFill);
                            figure.Draw(pbMain);
                            allFigures.Add(figure);
                            // figure = new drPolygon(fgPoints, clPen, (int)UDPenThick.Value, clFill);
                            if (!figure.Is_Input_Correct())
                            {
                                ssMouseWhere.Text = "Обнаружена ошибка во вводе координат";
                            }
                            else
                                ssMouseWhere.Text = " ";
                            Rerfresh();
                        }
                        break;
                    }
                case 3:
                    {
                        if (tbPolygon.Lines.Length > 0)
                        {
                            figure = new drCurve(tbPolygon.Lines, clPen, (int)tbPenThick.Value);
                            figure.Draw(pbMain);
                            allFigures.Add(figure);
                            if (!figure.Is_Input_Correct())
                            {
                                ssMouseWhere.Text = "Обнаружена ошибка во вводе координат";
                            }
                            else
                                ssMouseWhere.Text = " ";
                            Rerfresh();
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void pbMain_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((int)cbForm.SelectedIndex)
            {
              //  case 0:
              //      {
                      //  UDCoordinateX.Value = e.X;
                       // UDCoordinateY.Value = e.Y;
              //          break;
              //      }
              //  case 1:
             //       {
                       // UDCoordinateX.Value = e.X;
                       // UDCoordinateY.Value = e.Y;
              //          break;
              //      }
                case 2:
                    {
                        if (ModifierKeys != Keys.Control)
                        {
                            tbPolygon.AppendText(e.X + ";" + e.Y + Environment.NewLine);
                            pbMain.CreateGraphics().FillEllipse(Brushes.Black, Rectangle.FromLTRB(e.X - 2, e.Y - 2, e.X + 2, e.Y + 2));
                        }
                        else
                        {
                            PolygonUD_X.Value = e.X;
                            PolygonUD_Y.Value = e.Y;
                        }

                        break;
                    }
                case 3:
                    {
                        if (ModifierKeys != Keys.Control)
                        {
                            tbPolygon.AppendText(e.X + ";" + e.Y + Environment.NewLine);
                            pbMain.CreateGraphics().FillEllipse(Brushes.Black, Rectangle.FromLTRB(e.X - 2, e.Y - 2, e.X + 2, e.Y + 2));
                        }
                        else
                        {
                            PolygonUD_X.Value = e.X;
                            PolygonUD_Y.Value = e.Y;
                        }

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void bAddToPolygon_MouseClick(object sender, MouseEventArgs e)
        {
            tbPolygon.AppendText(PolygonUD_X.Value + ";" + PolygonUD_Y.Value + Environment.NewLine);
        }

        private void bDelTB_MouseClick(object sender, MouseEventArgs e)
        {
            tbPolygon.Clear();
        }

        private void bClear_MouseClick(object sender, MouseEventArgs e)
        {
            pbMain.Image = null;
            allFigures.Clear();
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
                switch ((int)cbForm.SelectedIndex)
            {
                case 0:
                    {
                        UDCoordinateX.Value = e.X;
                        UDCoordinateY.Value = e.Y;
                        break;
                    }
                case 1:
                    {
                        UDCoordinateX.Value = e.X;
                        UDCoordinateY.Value = e.Y;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            switch ((int)cbForm.SelectedIndex)
            {
                case 0:
                    {
                        int tempWidth = e.X;
                        int tempHeight = e.Y;
                          if (tempWidth < 0)
                              tempWidth = 0;
                          if (tempHeight < 0)
                              tempHeight = 0;
                          if (tempHeight > (int)pbMain.Size.Height)
                              tempHeight = (int)pbMain.Size.Height;
                         if (tempWidth > (int)pbMain.Size.Width)
                              tempWidth = (int)pbMain.Size.Width;
                        try
                        {
                            if (tempWidth < (int)UDCoordinateX.Value)
                            {
                                UDSIzeWidth.Value = (int)UDCoordinateX.Value - tempWidth;
                                UDCoordinateX.Value = tempWidth;
                            }
                            else
                                UDSIzeWidth.Value = tempWidth - (int)UDCoordinateX.Value;

                            if (tempHeight < (int)UDCoordinateY.Value)
                            {
                                UDSizeHeight.Value = (int)UDCoordinateY.Value - tempHeight;
                                UDCoordinateY.Value = tempHeight;
                            }
                            else
                                UDSizeHeight.Value = tempHeight - (int)UDCoordinateY.Value;
                            ssMouseWhere.Text = " ";
                        }
                        catch
                        { ssMouseWhere.Text = "Выход за пределы холста. Не рекомендуется рисовать"; }
                        break;
                    }
                case 1:
                    {
                        int tempWidth = e.X;
                        int tempHeight = e.Y;
                          if (tempWidth < 0)
                              tempWidth = 0;
                          if (tempHeight < 0)
                              tempHeight = 0;
                          if (tempHeight > (int)pbMain.Size.Height)
                              tempHeight = (int)pbMain.Size.Height;
                         if (tempWidth > (int)pbMain.Size.Width)
                              tempWidth = (int)pbMain.Size.Width;
                        try
                        {
                            if (tempWidth < (int)UDCoordinateX.Value)
                            {
                                UDSIzeWidth.Value = (int)UDCoordinateX.Value - tempWidth;
                                UDCoordinateX.Value = tempWidth;
                            }
                            else
                                UDSIzeWidth.Value = tempWidth - (int)UDCoordinateX.Value;

                            if (tempHeight < (int)UDCoordinateY.Value)
                            {
                                UDSizeHeight.Value = (int)UDCoordinateY.Value - tempHeight;
                                UDCoordinateY.Value = tempHeight;
                            }
                            else
                                UDSizeHeight.Value = tempHeight - (int)UDCoordinateY.Value;
                            ssMouseWhere.Text = " ";
                        }
                        catch
                        { ssMouseWhere.Text = "Выход за пределы холста. Не рекомендуется рисовать"; }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (ModifierKeys != Keys.Control)
            {
                Color clPen;
                Color clFill;
                if (cbPen.Checked == true)
                    clPen = Color.Empty;
                else
                    clPen = pPenColor.BackColor;
                if (cbFill.Checked == true)
                    clFill = Color.Empty;
                else
                    clFill = pBrushColor.BackColor;
                MainDraw figure;
                switch ((int)cbForm.SelectedIndex)
                {
                    case 0:
                        {
                            figure = new drRectangle((int)UDCoordinateX.Value, (int)UDCoordinateY.Value, (int)UDSIzeWidth.Value, (int)UDSizeHeight.Value, clPen, (int)tbPenThick.Value, clFill);
                            figure.Draw(pbMain);
                            allFigures.Add(figure);
                            break;
                        }
                    case 1:
                        {
                            figure = new drElipse((int)UDCoordinateX.Value, (int)UDCoordinateY.Value, (int)UDSIzeWidth.Value, (int)UDSizeHeight.Value, clPen, (int)tbPenThick.Value, clFill);
                            figure.Draw(pbMain);
                            allFigures.Add(figure);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                
            }
        }

        private void pbMain_SizeChanged(object sender, EventArgs e)
        {
            if (UDCoordinateX.Value > pbMain.Size.Width)
                UDCoordinateX.Value = pbMain.Size.Width;
            UDCoordinateX.Maximum = pbMain.Size.Width;
            if (UDCoordinateY.Value > pbMain.Size.Height)
                UDCoordinateY.Value = pbMain.Size.Height;
            UDCoordinateY.Maximum = pbMain.Size.Height;
            if (UDSIzeWidth.Value > pbMain.Size.Width)
                UDSIzeWidth.Value = pbMain.Size.Width;
            UDSIzeWidth.Maximum = pbMain.Size.Width;
            if (UDSizeHeight.Value > pbMain.Size.Height)
                UDSizeHeight.Value = pbMain.Size.Height;
            UDSizeHeight.Maximum = pbMain.Size.Height;
            if (PolygonUD_X.Value > pbMain.Size.Width)
                PolygonUD_X.Value = pbMain.Size.Width;
            PolygonUD_X.Maximum = pbMain.Size.Width;
            if (PolygonUD_Y.Value > pbMain.Size.Height)
                PolygonUD_Y.Value = pbMain.Size.Height;
            PolygonUD_Y.Maximum = pbMain.Size.Height;
        }

        private void bRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            Rerfresh();
        }

        private void bUndo_MouseClick(object sender, MouseEventArgs e)
        {
            if (allFigures.Count > 0)
            {
                pbMain.Refresh();
                allFigures.RemoveAt(allFigures.Count - 1);
                foreach (MainDraw fig in allFigures)
                    fig.Draw(pbMain);
            }
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            ssMouseWhere.Text = (e.X + ":" + e.Y);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // если честно я не помню что это
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Rerfresh();
        }

        private void saveCoord_Click(object sender, EventArgs e)
        {
            if (saveCoordDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveCoordDialog.FileName, tbPolygon.Lines);
            }
        }

        private void uploadCoord_Click(object sender, EventArgs e)
        {
            if (openCoord.ShowDialog() == DialogResult.OK)
            {
                tbPolygon.Lines = File.ReadAllLines(openCoord.FileName);
            }
        }

        private void saveXml_Click(object sender, EventArgs e)
        {
            if (saveXmlDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xml = new XmlDocument();
                XmlDeclaration declaration = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
                xml.AppendChild(declaration);

                XmlElement root = xml.CreateElement("Figures");
                xml.AppendChild(root);

                foreach (MainDraw fig in allFigures)
                {
                    XmlNode node = xml.CreateElement("Figure");
                    XmlAttribute attribute = xml.CreateAttribute("Type");
                    attribute.Value = fig.GetFigureName();
                    node.Attributes.Append(attribute);

                    XmlNode child = xml.CreateElement("Pen");
                    attribute = xml.CreateAttribute("Width");
                    attribute.Value = fig.GetPen().Width.ToString();
                    child.Attributes.Append(attribute);
                    child.InnerText = fig.GetPen().Color.ToArgb().ToString();
                    node.AppendChild(child);


                    if (fig.GetBrush() != null)
                    {
                        child = xml.CreateElement("Brush");
                        child.InnerText = fig.GetBrush().Color.ToArgb().ToString();
                        node.AppendChild(child);
                    }

                    if (!fig.Is_Polygon())
                    {
                        child = xml.CreateElement("Size");
                        attribute = xml.CreateAttribute("Width");
                        attribute.Value = fig.GetSize().Width.ToString();
                        child.Attributes.Append(attribute);
                        attribute = xml.CreateAttribute("Height");
                        attribute.Value = fig.GetSize().Height.ToString();
                        child.Attributes.Append(attribute);
                        node.AppendChild(child);

                        child = xml.CreateElement("TopLeft");
                        attribute = xml.CreateAttribute("X");
                        attribute.Value = fig.GetAnchor().X.ToString();
                        child.Attributes.Append(attribute);
                        attribute = xml.CreateAttribute("Y");
                        attribute.Value = fig.GetAnchor().Y.ToString();
                        child.Attributes.Append(attribute);
                        node.AppendChild(child);
                    }
                    else
                    {
                        child = xml.CreateElement("Points");

                        if (fig.GetPoints() != null)
                        {
                            foreach (Point p in fig.GetPoints())
                            {
                                XmlNode point_node = xml.CreateElement("Point");
                                attribute = xml.CreateAttribute("X");
                                attribute.Value = p.X.ToString();
                                point_node.Attributes.Append(attribute);
                                attribute = xml.CreateAttribute("Y");
                                attribute.Value = p.Y.ToString();
                                point_node.Attributes.Append(attribute);
                                child.AppendChild(point_node);
                            }
                            node.AppendChild(child);
                        }
                    }

                    root.AppendChild(node);
                }

                xml.Save(saveXmlDialog.FileName);
            }
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            if (savePicture.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(pbMain.Width, pbMain.Height);
                var graphics = Graphics.FromImage(bitmap);
                var area = pbMain.RectangleToScreen(pbMain.ClientRectangle);
                graphics.CopyFromScreen(area.Location, Point.Empty, pbMain.Size);
                bitmap.Save(savePicture.FileName, ImageFormat.Png);
            }
        }

        private void uploadXml_Click(object sender, EventArgs e)
        {
            if (openXmlDialog.ShowDialog() == DialogResult.OK)
            {
                allFigures.Clear();
                XmlDocument xml = new XmlDocument();
                xml.Load(openXmlDialog.FileName);
                XmlElement root = xml.DocumentElement;

                foreach (XmlNode node in root)
                {
                    int x = 0;
                    int y = 0;
                    int w = 0;
                    int h = 0;
                    Color pen_color = Color.Empty;
                    Color brush_color = Color.Empty;
                    int pen_w = 1;
                    List<Point> points = new List<Point>();
                    FigureName f_type;
                    string f_name = node.Attributes.GetNamedItem("Type").Value;

                    if (Enum.IsDefined(typeof(FigureName), f_name))
                    {
                        f_type = (FigureName)Enum.Parse(typeof(FigureName), f_name);
                    }
                    else
                        f_type = FigureName.undef;

                    foreach (XmlNode child_node in node.ChildNodes)
                    {
                        if (child_node.Name == "Pen")
                        {
                            pen_w = Convert.ToInt32(child_node.Attributes.GetNamedItem("Width").Value);
                            pen_color = Color.FromArgb(Convert.ToInt32(child_node.InnerText));
                        }
                        else if (child_node.Name == "Brush")
                        {
                            brush_color = Color.FromArgb(Convert.ToInt32(child_node.InnerText));
                        }
                        else if (child_node.Name == "Size")
                        {
                            w = Convert.ToInt32(child_node.Attributes.GetNamedItem("Width").Value);
                            h = Convert.ToInt32(child_node.Attributes.GetNamedItem("Height").Value);
                        }
                        else if (child_node.Name == "TopLeft")
                        {
                            x = Convert.ToInt32(child_node.Attributes.GetNamedItem("X").Value);
                            y = Convert.ToInt32(child_node.Attributes.GetNamedItem("Y").Value);
                        }
                        else if (child_node.Name == "Points")
                        {
                            foreach (XmlNode point_node in child_node.ChildNodes)
                            {
                                if (point_node.Name == "Point")
                                {
                                    int p_x = Convert.ToInt32(point_node.Attributes.GetNamedItem("X").Value);
                                    int p_y = Convert.ToInt32(point_node.Attributes.GetNamedItem("Y").Value);
                                    points.Add(new Point(p_x, p_y));
                                }
                            }
                        }


                    }
                    allFigures.Add(
                    get_figure(f_type,
                    new Point(x, y),
                    new Size(w, h),
                    points.ToArray(),
                    new Pen(pen_color, pen_w),
                    new SolidBrush(brush_color)));
                }
                this.Invalidate();
            }

        }
    }
}
