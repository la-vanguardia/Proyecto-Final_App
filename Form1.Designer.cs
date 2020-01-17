namespace App_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_Lateral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comBox_Puertos = new System.Windows.Forms.ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Lateral_Animate = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Graficar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Parar_grafico = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart9 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.PasoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlturaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RepeticionesBox = new System.Windows.Forms.TextBox();
            this.labelTempRest = new System.Windows.Forms.Label();
            this.labelTempRestR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ConectarPuerto = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.Panel_Lateral.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graficar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parar_grafico)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart9)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.Cerrar, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Cerrar, "Cerrar");
            this.Cerrar.ImageActive = null;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.TabStop = false;
            this.Cerrar.Zoom = 10;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click_1);
            // 
            // Panel_Lateral
            // 
            resources.ApplyResources(this.Panel_Lateral, "Panel_Lateral");
            this.Panel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.Panel_Lateral.CausesValidation = false;
            this.Panel_Lateral.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.Panel_Lateral.Controls.Add(this.ConectarPuerto, 1, 2);
            this.Panel_Lateral_Animate.SetDecoration(this.Panel_Lateral, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Lateral.Name = "Panel_Lateral";
            this.Panel_Lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Lateral_Paint);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comBox_Puertos, 1, 0);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel4, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // pictureBox1
            // 
            this.Panel_Lateral_Animate.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // comBox_Puertos
            // 
            this.comBox_Puertos.BackColor = System.Drawing.Color.White;
            this.Panel_Lateral_Animate.SetDecoration(this.comBox_Puertos, BunifuAnimatorNS.DecorationType.None);
            this.comBox_Puertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comBox_Puertos, "comBox_Puertos");
            this.comBox_Puertos.ForeColor = System.Drawing.Color.Black;
            this.comBox_Puertos.FormattingEnabled = true;
            this.comBox_Puertos.Name = "comBox_Puertos";
            this.comBox_Puertos.TabStop = false;
            this.comBox_Puertos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.tableLayoutPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.bunifuImageButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cerrar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Minimizar, 3, 0);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            this.tableLayoutPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.Panel_Lateral_Animate.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDoubleClick);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Minimizar, "Minimizar");
            this.Minimizar.ImageActive = null;
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.TabStop = false;
            this.Minimizar.Zoom = 10;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Lateral_Animate
            // 
            this.Panel_Lateral_Animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Panel_Lateral_Animate.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Panel_Lateral_Animate.DefaultAnimation = animation1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.Graficar, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Parar_grafico, 1, 0);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel5, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // Graficar
            // 
            this.Graficar.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.Graficar, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Graficar, "Graficar");
            this.Graficar.ImageActive = null;
            this.Graficar.Name = "Graficar";
            this.Graficar.TabStop = false;
            this.Graficar.Zoom = 10;
            this.Graficar.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // Parar_grafico
            // 
            this.Parar_grafico.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.Parar_grafico, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Parar_grafico, "Parar_grafico");
            this.Parar_grafico.ImageActive = null;
            this.Parar_grafico.Name = "Parar_grafico";
            this.Parar_grafico.TabStop = false;
            this.Parar_grafico.Zoom = 10;
            this.Parar_grafico.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.chart9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // chart9
            // 
            this.chart9.BackColor = System.Drawing.Color.Transparent;
            this.chart9.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart9.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MaximumAutoSize = 10F;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart9.ChartAreas.Add(chartArea1);
            this.Panel_Lateral_Animate.SetDecoration(this.chart9, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.chart9, "chart9");
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart9.Legends.Add(legend1);
            this.chart9.Name = "chart9";
            this.chart9.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            this.chart9.Series.Add(series1);
            this.chart9.Series.Add(series2);
            this.chart9.Click += new System.EventHandler(this.chart2_Click_1);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel3, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel7, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.PasoBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.AlturaBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.RepeticionesBox, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelTempRest, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.labelTempRestR, 1, 5);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel6, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // PasoBox
            // 
            this.Panel_Lateral_Animate.SetDecoration(this.PasoBox, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.PasoBox, "PasoBox");
            this.PasoBox.Name = "PasoBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AlturaBox
            // 
            this.Panel_Lateral_Animate.SetDecoration(this.AlturaBox, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.AlturaBox, "AlturaBox");
            this.AlturaBox.Name = "AlturaBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // RepeticionesBox
            // 
            this.Panel_Lateral_Animate.SetDecoration(this.RepeticionesBox, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.RepeticionesBox, "RepeticionesBox");
            this.RepeticionesBox.Name = "RepeticionesBox";
            // 
            // labelTempRest
            // 
            resources.ApplyResources(this.labelTempRest, "labelTempRest");
            this.labelTempRest.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.labelTempRest, BunifuAnimatorNS.DecorationType.None);
            this.labelTempRest.ForeColor = System.Drawing.Color.White;
            this.labelTempRest.Name = "labelTempRest";
            // 
            // labelTempRestR
            // 
            resources.ApplyResources(this.labelTempRestR, "labelTempRestR");
            this.labelTempRestR.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Lateral_Animate.SetDecoration(this.labelTempRestR, BunifuAnimatorNS.DecorationType.None);
            this.labelTempRestR.ForeColor = System.Drawing.Color.White;
            this.labelTempRestR.Name = "labelTempRestR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ConectarPuerto
            // 
            this.ConectarPuerto.ActiveBorderThickness = 1;
            this.ConectarPuerto.ActiveCornerRadius = 20;
            this.ConectarPuerto.ActiveFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConectarPuerto.ActiveForecolor = System.Drawing.Color.White;
            this.ConectarPuerto.ActiveLineColor = System.Drawing.Color.White;
            this.ConectarPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            resources.ApplyResources(this.ConectarPuerto, "ConectarPuerto");
            this.ConectarPuerto.ButtonText = "CONECTAR";
            this.ConectarPuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Lateral_Animate.SetDecoration(this.ConectarPuerto, BunifuAnimatorNS.DecorationType.None);
            this.ConectarPuerto.ForeColor = System.Drawing.Color.SeaGreen;
            this.ConectarPuerto.IdleBorderThickness = 1;
            this.ConectarPuerto.IdleCornerRadius = 20;
            this.ConectarPuerto.IdleFillColor = System.Drawing.Color.Transparent;
            this.ConectarPuerto.IdleForecolor = System.Drawing.Color.White;
            this.ConectarPuerto.IdleLineColor = System.Drawing.Color.White;
            this.ConectarPuerto.Name = "ConectarPuerto";
            this.ConectarPuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConectarPuerto.Click += new System.EventHandler(this.ConectarPuerto_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Panel_Lateral);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Lateral_Animate.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.Panel_Lateral.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graficar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Parar_grafico)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart9)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel Panel_Lateral;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Cerrar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private BunifuAnimatorNS.BunifuTransition Panel_Lateral_Animate;
        private System.Windows.Forms.ComboBox comBox_Puertos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Bunifu.Framework.UI.BunifuImageButton Minimizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Bunifu.Framework.UI.BunifuImageButton Graficar;
        private Bunifu.Framework.UI.BunifuImageButton Parar_grafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox PasoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlturaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RepeticionesBox;
        private System.Windows.Forms.Label labelTempRest;
        private System.Windows.Forms.Label labelTempRestR;
        private Bunifu.Framework.UI.BunifuThinButton2 ConectarPuerto;
    }
}

