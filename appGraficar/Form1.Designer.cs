namespace appGraficar
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.btnExaminar = new System.Windows.Forms.Button();
      this.lstvDatos = new System.Windows.Forms.ListView();
      this.tvJerarquia = new System.Windows.Forms.TreeView();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
      chartArea1.AxisX.IntervalOffset = 1D;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(744, 41);
      this.chart1.Name = "chart1";
      series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
      series1.ChartArea = "ChartArea1";
      series1.IsXValueIndexed = true;
      series1.Legend = "Legend1";
      series1.Name = "S";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(410, 463);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      this.chart1.Visible = false;
      // 
      // btnExaminar
      // 
      this.btnExaminar.Location = new System.Drawing.Point(12, 12);
      this.btnExaminar.Name = "btnExaminar";
      this.btnExaminar.Size = new System.Drawing.Size(72, 26);
      this.btnExaminar.TabIndex = 1;
      this.btnExaminar.Text = "Examinar";
      this.btnExaminar.UseVisualStyleBackColor = true;
      this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
      // 
      // lstvDatos
      // 
      this.lstvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstvDatos.HideSelection = false;
      this.lstvDatos.Location = new System.Drawing.Point(300, 41);
      this.lstvDatos.Name = "lstvDatos";
      this.lstvDatos.Size = new System.Drawing.Size(438, 463);
      this.lstvDatos.TabIndex = 2;
      this.lstvDatos.UseCompatibleStateImageBehavior = false;
      this.lstvDatos.Visible = false;
      // 
      // tvJerarquia
      // 
      this.tvJerarquia.Location = new System.Drawing.Point(0, 44);
      this.tvJerarquia.Name = "tvJerarquia";
      this.tvJerarquia.Size = new System.Drawing.Size(259, 460);
      this.tvJerarquia.TabIndex = 3;
      this.tvJerarquia.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1155, 516);
      this.Controls.Add(this.tvJerarquia);
      this.Controls.Add(this.lstvDatos);
      this.Controls.Add(this.btnExaminar);
      this.Controls.Add(this.chart1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnExaminar;
    private System.Windows.Forms.ListView lstvDatos;
    private System.Windows.Forms.TreeView tvJerarquia;
  }
}

