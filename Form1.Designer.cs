namespace Draw_figures
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UDCoordinateX = new System.Windows.Forms.NumericUpDown();
            this.UDCoordinateY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UDSIzeWidth = new System.Windows.Forms.NumericUpDown();
            this.UDSizeHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cdPen = new System.Windows.Forms.ColorDialog();
            this.cdBrush = new System.Windows.Forms.ColorDialog();
            this.cbForm = new System.Windows.Forms.ComboBox();
            this.pPenColor = new System.Windows.Forms.Panel();
            this.pBrushColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.cbFill = new System.Windows.Forms.CheckBox();
            this.tbPolygon = new System.Windows.Forms.TextBox();
            this.PolygonUD_X = new System.Windows.Forms.NumericUpDown();
            this.PolygonUD_Y = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ssErrors = new System.Windows.Forms.StatusStrip();
            this.ssMouseWhere = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbPenThick = new System.Windows.Forms.TrackBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ddButtonSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveCoord = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXml = new System.Windows.Forms.ToolStripMenuItem();
            this.ddButtonUpload = new System.Windows.Forms.ToolStripDropDownButton();
            this.uploadCoord = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadXml = new System.Windows.Forms.ToolStripMenuItem();
            this.bUndo = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bAddToPolygon = new System.Windows.Forms.Button();
            this.bDelTB = new System.Windows.Forms.Button();
            this.bDraw = new System.Windows.Forms.Button();
            this.bBrushColor = new System.Windows.Forms.Button();
            this.bPenColor = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.saveCoordDialog = new System.Windows.Forms.SaveFileDialog();
            this.openCoord = new System.Windows.Forms.OpenFileDialog();
            this.saveXmlDialog = new System.Windows.Forms.SaveFileDialog();
            this.savePicture = new System.Windows.Forms.SaveFileDialog();
            this.openXmlDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UDCoordinateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCoordinateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSIzeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonUD_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonUD_Y)).BeginInit();
            this.ssErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenThick)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // UDCoordinateX
            // 
            this.UDCoordinateX.Location = new System.Drawing.Point(26, 79);
            this.UDCoordinateX.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.UDCoordinateX.Name = "UDCoordinateX";
            this.UDCoordinateX.Size = new System.Drawing.Size(120, 20);
            this.UDCoordinateX.TabIndex = 1;
            this.UDCoordinateX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // UDCoordinateY
            // 
            this.UDCoordinateY.Location = new System.Drawing.Point(26, 109);
            this.UDCoordinateY.Maximum = new decimal(new int[] {
            435,
            0,
            0,
            0});
            this.UDCoordinateY.Name = "UDCoordinateY";
            this.UDCoordinateY.Size = new System.Drawing.Size(120, 20);
            this.UDCoordinateY.TabIndex = 1;
            this.UDCoordinateY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите координаты левого верхнего угла (x,y)";
            // 
            // UDSIzeWidth
            // 
            this.UDSIzeWidth.Location = new System.Drawing.Point(26, 169);
            this.UDSIzeWidth.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.UDSIzeWidth.Name = "UDSIzeWidth";
            this.UDSIzeWidth.Size = new System.Drawing.Size(120, 20);
            this.UDSIzeWidth.TabIndex = 1;
            this.UDSIzeWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // UDSizeHeight
            // 
            this.UDSizeHeight.Location = new System.Drawing.Point(26, 199);
            this.UDSizeHeight.Maximum = new decimal(new int[] {
            435,
            0,
            0,
            0});
            this.UDSizeHeight.Name = "UDSizeHeight";
            this.UDSizeHeight.Size = new System.Drawing.Size(120, 20);
            this.UDSizeHeight.TabIndex = 1;
            this.UDSizeHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите размер фигуры";
            // 
            // cdBrush
            // 
            this.cdBrush.Color = System.Drawing.Color.White;
            // 
            // cbForm
            // 
            this.cbForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForm.FormattingEnabled = true;
            this.cbForm.Items.AddRange(new object[] {
            "Прямоугольник",
            "Овал",
            "Полигон",
            "Кривая"});
            this.cbForm.Location = new System.Drawing.Point(171, 319);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(120, 21);
            this.cbForm.TabIndex = 4;
            this.cbForm.SelectedIndexChanged += new System.EventHandler(this.cbForm_SelectedIndexChanged);
            // 
            // pPenColor
            // 
            this.pPenColor.BackColor = System.Drawing.Color.Black;
            this.pPenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPenColor.Location = new System.Drawing.Point(126, 299);
            this.pPenColor.Name = "pPenColor";
            this.pPenColor.Size = new System.Drawing.Size(25, 24);
            this.pPenColor.TabIndex = 5;
            // 
            // pBrushColor
            // 
            this.pBrushColor.BackColor = System.Drawing.Color.White;
            this.pBrushColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBrushColor.Location = new System.Drawing.Point(126, 323);
            this.pBrushColor.Name = "pBrushColor";
            this.pBrushColor.Size = new System.Drawing.Size(25, 24);
            this.pBrushColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Location = new System.Drawing.Point(23, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Толщина контура";
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Location = new System.Drawing.Point(31, 352);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(88, 17);
            this.cbPen.TabIndex = 8;
            this.cbPen.Text = "Нет контура";
            this.cbPen.UseVisualStyleBackColor = true;
            // 
            // cbFill
            // 
            this.cbFill.AutoSize = true;
            this.cbFill.Location = new System.Drawing.Point(31, 378);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(90, 17);
            this.cbFill.TabIndex = 8;
            this.cbFill.Text = "Нет заливки";
            this.cbFill.UseVisualStyleBackColor = true;
            // 
            // tbPolygon
            // 
            this.tbPolygon.AllowDrop = true;
            this.tbPolygon.Location = new System.Drawing.Point(171, 169);
            this.tbPolygon.Multiline = true;
            this.tbPolygon.Name = "tbPolygon";
            this.tbPolygon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPolygon.Size = new System.Drawing.Size(120, 105);
            this.tbPolygon.TabIndex = 9;
            // 
            // PolygonUD_X
            // 
            this.PolygonUD_X.Location = new System.Drawing.Point(171, 79);
            this.PolygonUD_X.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.PolygonUD_X.Name = "PolygonUD_X";
            this.PolygonUD_X.Size = new System.Drawing.Size(120, 20);
            this.PolygonUD_X.TabIndex = 1;
            this.PolygonUD_X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PolygonUD_Y
            // 
            this.PolygonUD_Y.Location = new System.Drawing.Point(171, 109);
            this.PolygonUD_Y.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.PolygonUD_Y.Name = "PolygonUD_Y";
            this.PolygonUD_Y.Size = new System.Drawing.Size(120, 20);
            this.PolygonUD_Y.TabIndex = 1;
            this.PolygonUD_Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Location = new System.Drawing.Point(168, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите координаты вершины";
            // 
            // ssErrors
            // 
            this.ssErrors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMouseWhere,
            this.lbError});
            this.ssErrors.Location = new System.Drawing.Point(0, 456);
            this.ssErrors.Name = "ssErrors";
            this.ssErrors.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssErrors.Size = new System.Drawing.Size(904, 22);
            this.ssErrors.TabIndex = 13;
            this.ssErrors.Text = "Ошибка";
            // 
            // ssMouseWhere
            // 
            this.ssMouseWhere.BackColor = System.Drawing.SystemColors.Control;
            this.ssMouseWhere.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ssMouseWhere.Name = "ssMouseWhere";
            this.ssMouseWhere.Size = new System.Drawing.Size(0, 17);
            this.ssMouseWhere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbError
            // 
            this.lbError.BackColor = System.Drawing.SystemColors.Control;
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(891, 17);
            this.lbError.Spring = true;
            // 
            // tbPenThick
            // 
            this.tbPenThick.Location = new System.Drawing.Point(23, 254);
            this.tbPenThick.Minimum = 1;
            this.tbPenThick.Name = "tbPenThick";
            this.tbPenThick.Size = new System.Drawing.Size(120, 45);
            this.tbPenThick.TabIndex = 15;
            this.tbPenThick.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbPenThick.Value = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddButtonSave,
            this.ddButtonUpload});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(904, 25);
            this.toolStrip.TabIndex = 16;
            this.toolStrip.Text = "toolStrip1";
            // 
            // ddButtonSave
            // 
            this.ddButtonSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCoord,
            this.saveImage,
            this.saveXml});
            this.ddButtonSave.Image = global::Draw_Figures.Properties.Resources.picture_save;
            this.ddButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddButtonSave.Name = "ddButtonSave";
            this.ddButtonSave.Size = new System.Drawing.Size(104, 22);
            this.ddButtonSave.Text = "Сохранить...";
            // 
            // saveCoord
            // 
            this.saveCoord.Name = "saveCoord";
            this.saveCoord.Size = new System.Drawing.Size(180, 22);
            this.saveCoord.Text = "Координаты";
            this.saveCoord.Click += new System.EventHandler(this.saveCoord_Click);
            // 
            // saveImage
            // 
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(180, 22);
            this.saveImage.Text = "Изображение";
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // saveXml
            // 
            this.saveXml.Name = "saveXml";
            this.saveXml.Size = new System.Drawing.Size(180, 22);
            this.saveXml.Text = "Фигуры";
            this.saveXml.Click += new System.EventHandler(this.saveXml_Click);
            // 
            // ddButtonUpload
            // 
            this.ddButtonUpload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadCoord,
            this.uploadXml});
            this.ddButtonUpload.Image = global::Draw_Figures.Properties.Resources.picture_add;
            this.ddButtonUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddButtonUpload.Name = "ddButtonUpload";
            this.ddButtonUpload.Size = new System.Drawing.Size(99, 22);
            this.ddButtonUpload.Text = "Загрузить...";
            // 
            // uploadCoord
            // 
            this.uploadCoord.Name = "uploadCoord";
            this.uploadCoord.Size = new System.Drawing.Size(180, 22);
            this.uploadCoord.Text = "Координаты";
            this.uploadCoord.Click += new System.EventHandler(this.uploadCoord_Click);
            // 
            // uploadXml
            // 
            this.uploadXml.Name = "uploadXml";
            this.uploadXml.Size = new System.Drawing.Size(180, 22);
            this.uploadXml.Text = "Фигуры";
            this.uploadXml.Click += new System.EventHandler(this.uploadXml_Click);
            // 
            // bUndo
            // 
            this.bUndo.Image = global::Draw_Figures.Properties.Resources.arrow_undo;
            this.bUndo.Location = new System.Drawing.Point(264, 373);
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(27, 25);
            this.bUndo.TabIndex = 18;
            this.bUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUndo.UseVisualStyleBackColor = true;
            this.bUndo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bUndo_MouseClick);
            // 
            // bRefresh
            // 
            this.bRefresh.Image = global::Draw_Figures.Properties.Resources.arrow_refresh;
            this.bRefresh.Location = new System.Drawing.Point(264, 344);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(27, 25);
            this.bRefresh.TabIndex = 17;
            this.bRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bRefresh_MouseClick);
            // 
            // bClear
            // 
            this.bClear.Image = global::Draw_Figures.Properties.Resources.bomb;
            this.bClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClear.Location = new System.Drawing.Point(171, 375);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(87, 25);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bClear_MouseClick);
            // 
            // bAddToPolygon
            // 
            this.bAddToPolygon.Image = global::Draw_Figures.Properties.Resources.add;
            this.bAddToPolygon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAddToPolygon.Location = new System.Drawing.Point(171, 144);
            this.bAddToPolygon.Name = "bAddToPolygon";
            this.bAddToPolygon.Size = new System.Drawing.Size(120, 25);
            this.bAddToPolygon.TabIndex = 11;
            this.bAddToPolygon.Text = "Добавить";
            this.bAddToPolygon.UseVisualStyleBackColor = true;
            this.bAddToPolygon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bAddToPolygon_MouseClick);
            // 
            // bDelTB
            // 
            this.bDelTB.Image = global::Draw_Figures.Properties.Resources.bin;
            this.bDelTB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDelTB.Location = new System.Drawing.Point(171, 280);
            this.bDelTB.Name = "bDelTB";
            this.bDelTB.Size = new System.Drawing.Size(120, 25);
            this.bDelTB.TabIndex = 10;
            this.bDelTB.Text = "Очистить";
            this.bDelTB.UseVisualStyleBackColor = true;
            this.bDelTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bDelTB_MouseClick);
            // 
            // bDraw
            // 
            this.bDraw.Enabled = false;
            this.bDraw.Image = global::Draw_Figures.Properties.Resources.pencil;
            this.bDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDraw.Location = new System.Drawing.Point(171, 344);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(87, 25);
            this.bDraw.TabIndex = 3;
            this.bDraw.Text = "Рисовать!";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bDraw_MouseClick);
            // 
            // bBrushColor
            // 
            this.bBrushColor.Image = global::Draw_Figures.Properties.Resources.color_wheel;
            this.bBrushColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBrushColor.Location = new System.Drawing.Point(26, 323);
            this.bBrushColor.Name = "bBrushColor";
            this.bBrushColor.Size = new System.Drawing.Size(100, 25);
            this.bBrushColor.TabIndex = 3;
            this.bBrushColor.Text = "Цвет заливки";
            this.bBrushColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBrushColor.UseVisualStyleBackColor = true;
            this.bBrushColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bBrushColor_MouseClick);
            // 
            // bPenColor
            // 
            this.bPenColor.Image = global::Draw_Figures.Properties.Resources.color_wheel;
            this.bPenColor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPenColor.Location = new System.Drawing.Point(26, 299);
            this.bPenColor.Name = "bPenColor";
            this.bPenColor.Size = new System.Drawing.Size(100, 25);
            this.bPenColor.TabIndex = 3;
            this.bPenColor.Text = "Цвет контура";
            this.bPenColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPenColor.UseVisualStyleBackColor = true;
            this.bPenColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bPenColor_MouseClick);
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(315, 28);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(584, 425);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.SizeChanged += new System.EventHandler(this.pbMain_SizeChanged);
            this.pbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseClick);
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // saveCoordDialog
            // 
            this.saveCoordDialog.DefaultExt = "txt";
            this.saveCoordDialog.FileName = "Coords";
            this.saveCoordDialog.Filter = "Текстовые файлы | *.txt | Все файлы | *.*";
            // 
            // openCoord
            // 
            this.openCoord.DefaultExt = "txt";
            this.openCoord.FileName = "Coord";
            this.openCoord.Filter = "Текстовый файл | *.txt | Все файлы | *.*";
            this.openCoord.Title = "Выберите файл с координатами";
            // 
            // saveXmlDialog
            // 
            this.saveXmlDialog.DefaultExt = "xml";
            this.saveXmlDialog.FileName = "allFigures";
            this.saveXmlDialog.Filter = "Файл xml | *.xml | Все файлы | *.*";
            // 
            // savePicture
            // 
            this.savePicture.DefaultExt = "jpeg";
            this.savePicture.FileName = "Picteresque";
            this.savePicture.Filter = "Изображение | *.jpeg | Все файлы | *.*";
            // 
            // openXmlDialog
            // 
            this.openXmlDialog.DefaultExt = "xml";
            this.openXmlDialog.FileName = "figures";
            this.openXmlDialog.Filter = "Файл xml |*.xml | Все файлы | *.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 478);
            this.Controls.Add(this.bUndo);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tbPenThick);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.ssErrors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAddToPolygon);
            this.Controls.Add(this.PolygonUD_Y);
            this.Controls.Add(this.PolygonUD_X);
            this.Controls.Add(this.bDelTB);
            this.Controls.Add(this.tbPolygon);
            this.Controls.Add(this.cbFill);
            this.Controls.Add(this.cbPen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBrushColor);
            this.Controls.Add(this.pPenColor);
            this.Controls.Add(this.cbForm);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.bBrushColor);
            this.Controls.Add(this.bPenColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UDSizeHeight);
            this.Controls.Add(this.UDSIzeWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UDCoordinateY);
            this.Controls.Add(this.UDCoordinateX);
            this.Controls.Add(this.pbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 466);
            this.Name = "MainForm";
            this.Text = "Рисуем фигурки";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.UDCoordinateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCoordinateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSIzeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonUD_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonUD_Y)).EndInit();
            this.ssErrors.ResumeLayout(false);
            this.ssErrors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenThick)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.NumericUpDown UDCoordinateX;
        private System.Windows.Forms.NumericUpDown UDCoordinateY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UDSIzeWidth;
        private System.Windows.Forms.NumericUpDown UDSizeHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog cdPen;
        private System.Windows.Forms.ColorDialog cdBrush;
        private System.Windows.Forms.Button bPenColor;
        private System.Windows.Forms.Button bBrushColor;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.ComboBox cbForm;
        private System.Windows.Forms.Panel pPenColor;
        private System.Windows.Forms.Panel pBrushColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPen;
        private System.Windows.Forms.CheckBox cbFill;
        private System.Windows.Forms.TextBox tbPolygon;
        private System.Windows.Forms.Button bDelTB;
        private System.Windows.Forms.NumericUpDown PolygonUD_X;
        private System.Windows.Forms.NumericUpDown PolygonUD_Y;
        private System.Windows.Forms.Button bAddToPolygon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip ssErrors;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ToolStripStatusLabel ssMouseWhere;
        private System.Windows.Forms.TrackBar tbPenThick;
        private System.Windows.Forms.ToolStripStatusLabel lbError;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bUndo;
        private System.Windows.Forms.ToolStripDropDownButton ddButtonSave;
        private System.Windows.Forms.ToolStripDropDownButton ddButtonUpload;
        private System.Windows.Forms.ToolStripMenuItem saveCoord;
        private System.Windows.Forms.ToolStripMenuItem saveImage;
        private System.Windows.Forms.ToolStripMenuItem saveXml;
        private System.Windows.Forms.ToolStripMenuItem uploadCoord;
        private System.Windows.Forms.ToolStripMenuItem uploadXml;
        private System.Windows.Forms.SaveFileDialog saveCoordDialog;
        private System.Windows.Forms.OpenFileDialog openCoord;
        private System.Windows.Forms.SaveFileDialog saveXmlDialog;
        private System.Windows.Forms.SaveFileDialog savePicture;
        private System.Windows.Forms.OpenFileDialog openXmlDialog;
    }
}

