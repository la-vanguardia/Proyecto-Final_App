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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_Lateral = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comBox_Puertos = new System.Windows.Forms.ComboBox();
            this.Conectar_Puerto = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Lateral_Animate = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Parar_grafico = new Bunifu.Framework.UI.BunifuImageButton();
            this.Graficar = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.Panel_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Parar_grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            this.Panel_Lateral.Controls.Add(this.pictureBox1, 1, 1);
            this.Panel_Lateral.Controls.Add(this.comBox_Puertos, 2, 1);
            this.Panel_Lateral.Controls.Add(this.Conectar_Puerto, 2, 2);
            this.Panel_Lateral_Animate.SetDecoration(this.Panel_Lateral, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Lateral.Name = "Panel_Lateral";
            this.Panel_Lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Lateral_Paint);
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
            // Conectar_Puerto
            // 
            this.Conectar_Puerto.BackColor = System.Drawing.Color.SeaGreen;
            this.Conectar_Puerto.color = System.Drawing.Color.SeaGreen;
            this.Conectar_Puerto.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Conectar_Puerto.Cursor = System.Windows.Forms.Cursors.No;
            this.Panel_Lateral_Animate.SetDecoration(this.Conectar_Puerto, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Conectar_Puerto, "Conectar_Puerto");
            this.Conectar_Puerto.ForeColor = System.Drawing.Color.White;
            this.Conectar_Puerto.Image = ((System.Drawing.Image)(resources.GetObject("Conectar_Puerto.Image")));
            this.Conectar_Puerto.ImagePosition = 20;
            this.Conectar_Puerto.ImageZoom = 50;
            this.Conectar_Puerto.LabelPosition = 41;
            this.Conectar_Puerto.LabelText = "Conectar";
            this.Conectar_Puerto.Name = "Conectar_Puerto";
            this.Conectar_Puerto.Click += new System.EventHandler(this.Conectar_Puerto_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.Cerrar, 3, 0);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Lateral_Animate
            // 
            this.Panel_Lateral_Animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Panel_Lateral_Animate.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Panel_Lateral_Animate.DefaultAnimation = animation2;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chart2, 1, 1);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.Parar_grafico, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Graficar, 1, 0);
            this.Panel_Lateral_Animate.SetDecoration(this.tableLayoutPanel3, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MaximumAutoSize = 10F;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.Panel_Lateral_Animate.SetDecoration(this.chart2, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.chart2, "chart2");
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Series1";
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerSize = 10;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "Series2";
            series4.YValuesPerPoint = 2;
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Click += new System.EventHandler(this.chart2_Click_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Parar_grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graficar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton Graficar;
        private Bunifu.Framework.UI.BunifuImageButton Parar_grafico;
        private System.IO.Ports.SerialPort serialPort1;
        private Bunifu.Framework.UI.BunifuTileButton Conectar_Puerto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

