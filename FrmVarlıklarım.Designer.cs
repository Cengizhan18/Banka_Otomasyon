
namespace Banka_Otomasyon
{
    partial class FrmVarlıklarım
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVarlıklarım));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldolaral = new System.Windows.Forms.Label();
            this.lbleuroal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbleurotl = new System.Windows.Forms.Label();
            this.lbldolartl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtdolarmiktar = new System.Windows.Forms.TextBox();
            this.txteuromiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(94, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TL Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(63, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(70, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Miktarı:";
            // 
            // lbldolaral
            // 
            this.lbldolaral.AutoSize = true;
            this.lbldolaral.Location = new System.Drawing.Point(294, 576);
            this.lbldolaral.Name = "lbldolaral";
            this.lbldolaral.Size = new System.Drawing.Size(162, 29);
            this.lbldolaral.TabIndex = 3;
            this.lbldolaral.Text = "Dolar Miktarı:";
            this.lbldolaral.Visible = false;
            this.lbldolaral.Click += new System.EventHandler(this.lbldolaral_Click);
            // 
            // lbleuroal
            // 
            this.lbleuroal.AutoSize = true;
            this.lbleuroal.Location = new System.Drawing.Point(126, 576);
            this.lbleuroal.Name = "lbleuroal";
            this.lbleuroal.Size = new System.Drawing.Size(162, 29);
            this.lbleuroal.TabIndex = 4;
            this.lbleuroal.Text = "Dolar Miktarı:";
            this.lbleuroal.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 5;
            this.label5.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(237, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(63, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dolar Miktarı:";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(820, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 37);
            this.button1.TabIndex = 55;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbleurotl
            // 
            this.lbleurotl.AutoSize = true;
            this.lbleurotl.BackColor = System.Drawing.Color.Transparent;
            this.lbleurotl.Location = new System.Drawing.Point(616, 471);
            this.lbleurotl.Name = "lbleurotl";
            this.lbleurotl.Size = new System.Drawing.Size(162, 29);
            this.lbleurotl.TabIndex = 57;
            this.lbleurotl.Text = "Dolar Miktarı:";
            this.lbleurotl.TextChanged += new System.EventHandler(this.lbleurotl_TextChanged);
            this.lbleurotl.Click += new System.EventHandler(this.lbleurotl_Click);
            // 
            // lbldolartl
            // 
            this.lbldolartl.AutoSize = true;
            this.lbldolartl.BackColor = System.Drawing.Color.Transparent;
            this.lbldolartl.Location = new System.Drawing.Point(615, 409);
            this.lbldolartl.Name = "lbldolartl";
            this.lbldolartl.Size = new System.Drawing.Size(162, 29);
            this.lbldolartl.TabIndex = 56;
            this.lbldolartl.Text = "Dolar Miktarı:";
            this.lbldolartl.TextChanged += new System.EventHandler(this.lbldolartl_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(452, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "Euro - TL  Miktarı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(452, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 29);
            this.label9.TabIndex = 58;
            this.label9.Text = "Dolar - TL Miktarı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 557);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 36);
            this.textBox1.TabIndex = 60;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(692, 552);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 36);
            this.textBox2.TabIndex = 61;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdolarmiktar
            // 
            this.txtdolarmiktar.Enabled = false;
            this.txtdolarmiktar.Location = new System.Drawing.Point(231, 402);
            this.txtdolarmiktar.Name = "txtdolarmiktar";
            this.txtdolarmiktar.Size = new System.Drawing.Size(168, 36);
            this.txtdolarmiktar.TabIndex = 62;
            this.txtdolarmiktar.TextChanged += new System.EventHandler(this.txtdolarmiktar_TextChanged);
            // 
            // txteuromiktar
            // 
            this.txteuromiktar.Enabled = false;
            this.txteuromiktar.Location = new System.Drawing.Point(231, 464);
            this.txteuromiktar.Name = "txteuromiktar";
            this.txteuromiktar.Size = new System.Drawing.Size(168, 36);
            this.txteuromiktar.TabIndex = 63;
            this.txteuromiktar.TextChanged += new System.EventHandler(this.txteuromiktar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(697, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "TL ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(697, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 29);
            this.label10.TabIndex = 65;
            this.label10.Text = "TL ";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Navy;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Varlıklar";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(381, 317);
            this.chart1.TabIndex = 66;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Navy;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(433, 22);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.MarkerSize = 2;
            series2.Name = "Varlıklar";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(381, 317);
            this.chart2.TabIndex = 67;
            this.chart2.Text = "chart2";
            // 
            // FrmVarlıklarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 549);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txteuromiktar);
            this.Controls.Add(this.txtdolarmiktar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbleurotl);
            this.Controls.Add(this.lbldolartl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbleuroal);
            this.Controls.Add(this.lbldolaral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmVarlıklarım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVarlıklarım";
            this.Load += new System.EventHandler(this.FrmVarlıklarım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldolaral;
        private System.Windows.Forms.Label lbleuroal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbleurotl;
        private System.Windows.Forms.Label lbldolartl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtdolarmiktar;
        private System.Windows.Forms.TextBox txteuromiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}