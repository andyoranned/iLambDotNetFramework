namespace iLambDotNetFramework.Forms
{
    partial class DashboardForm
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
            this.panelSheep = new System.Windows.Forms.Panel();
            this.labelSheepGreater = new System.Windows.Forms.Label();
            this.labelSheep = new System.Windows.Forms.Label();
            this.labelSheepCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEwes = new System.Windows.Forms.Panel();
            this.labelEweGreater = new System.Windows.Forms.Label();
            this.labelEwe = new System.Windows.Forms.Label();
            this.labelEweCount = new System.Windows.Forms.Label();
            this.panelRams = new System.Windows.Forms.Panel();
            this.labelRamGreater = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelRamCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartFlockSzOverTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxiLamb = new System.Windows.Forms.PictureBox();
            this.panelSheep.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEwes.SuspendLayout();
            this.panelRams.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlockSzOverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiLamb)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSheep
            // 
            this.panelSheep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
            this.panelSheep.Controls.Add(this.labelSheepGreater);
            this.panelSheep.Controls.Add(this.labelSheep);
            this.panelSheep.Controls.Add(this.labelSheepCount);
            this.panelSheep.Location = new System.Drawing.Point(448, 31);
            this.panelSheep.Name = "panelSheep";
            this.panelSheep.Size = new System.Drawing.Size(390, 161);
            this.panelSheep.TabIndex = 0;
            // 
            // labelSheepGreater
            // 
            this.labelSheepGreater.AutoSize = true;
            this.labelSheepGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheepGreater.Location = new System.Drawing.Point(34, 60);
            this.labelSheepGreater.Name = "labelSheepGreater";
            this.labelSheepGreater.Size = new System.Drawing.Size(39, 40);
            this.labelSheepGreater.TabIndex = 6;
            this.labelSheepGreater.Text = ">";
            this.labelSheepGreater.Visible = false;
            // 
            // labelSheep
            // 
            this.labelSheep.AutoSize = true;
            this.labelSheep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheep.Location = new System.Drawing.Point(224, 81);
            this.labelSheep.Name = "labelSheep";
            this.labelSheep.Size = new System.Drawing.Size(126, 40);
            this.labelSheep.TabIndex = 4;
            this.labelSheep.Text = "Sheep";
            // 
            // labelSheepCount
            // 
            this.labelSheepCount.AutoSize = true;
            this.labelSheepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheepCount.Location = new System.Drawing.Point(51, 26);
            this.labelSheepCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelSheepCount.MinimumSize = new System.Drawing.Size(204, 108);
            this.labelSheepCount.Name = "labelSheepCount";
            this.labelSheepCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSheepCount.Size = new System.Drawing.Size(204, 108);
            this.labelSheepCount.TabIndex = 5;
            this.labelSheepCount.Text = "999";
            this.labelSheepCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.pictureBoxiLamb);
            this.panel2.Location = new System.Drawing.Point(31, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 161);
            this.panel2.TabIndex = 3;
            // 
            // panelEwes
            // 
            this.panelEwes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.panelEwes.Controls.Add(this.labelEweGreater);
            this.panelEwes.Controls.Add(this.labelEwe);
            this.panelEwes.Controls.Add(this.labelEweCount);
            this.panelEwes.Location = new System.Drawing.Point(1286, 31);
            this.panelEwes.Name = "panelEwes";
            this.panelEwes.Size = new System.Drawing.Size(390, 161);
            this.panelEwes.TabIndex = 3;
            // 
            // labelEweGreater
            // 
            this.labelEweGreater.AutoSize = true;
            this.labelEweGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEweGreater.Location = new System.Drawing.Point(32, 60);
            this.labelEweGreater.Name = "labelEweGreater";
            this.labelEweGreater.Size = new System.Drawing.Size(39, 40);
            this.labelEweGreater.TabIndex = 7;
            this.labelEweGreater.Text = ">";
            this.labelEweGreater.Visible = false;
            // 
            // labelEwe
            // 
            this.labelEwe.AutoSize = true;
            this.labelEwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEwe.Location = new System.Drawing.Point(222, 84);
            this.labelEwe.Name = "labelEwe";
            this.labelEwe.Size = new System.Drawing.Size(109, 40);
            this.labelEwe.TabIndex = 0;
            this.labelEwe.Text = "Ewes";
            // 
            // labelEweCount
            // 
            this.labelEweCount.AutoSize = true;
            this.labelEweCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEweCount.Location = new System.Drawing.Point(49, 29);
            this.labelEweCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelEweCount.MinimumSize = new System.Drawing.Size(204, 108);
            this.labelEweCount.Name = "labelEweCount";
            this.labelEweCount.Size = new System.Drawing.Size(204, 108);
            this.labelEweCount.TabIndex = 3;
            this.labelEweCount.Text = "999";
            this.labelEweCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRams
            // 
            this.panelRams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panelRams.Controls.Add(this.labelRamGreater);
            this.panelRams.Controls.Add(this.labelRam);
            this.panelRams.Controls.Add(this.labelRamCount);
            this.panelRams.Location = new System.Drawing.Point(867, 31);
            this.panelRams.Name = "panelRams";
            this.panelRams.Size = new System.Drawing.Size(390, 161);
            this.panelRams.TabIndex = 3;
            // 
            // labelRamGreater
            // 
            this.labelRamGreater.AutoSize = true;
            this.labelRamGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRamGreater.Location = new System.Drawing.Point(34, 60);
            this.labelRamGreater.Name = "labelRamGreater";
            this.labelRamGreater.Size = new System.Drawing.Size(39, 40);
            this.labelRamGreater.TabIndex = 7;
            this.labelRamGreater.Text = ">";
            this.labelRamGreater.Visible = false;
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRam.Location = new System.Drawing.Point(224, 81);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(115, 40);
            this.labelRam.TabIndex = 4;
            this.labelRam.Text = "Rams";
            // 
            // labelRamCount
            // 
            this.labelRamCount.AutoSize = true;
            this.labelRamCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRamCount.Location = new System.Drawing.Point(51, 26);
            this.labelRamCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelRamCount.MinimumSize = new System.Drawing.Size(204, 108);
            this.labelRamCount.Name = "labelRamCount";
            this.labelRamCount.Size = new System.Drawing.Size(204, 108);
            this.labelRamCount.TabIndex = 5;
            this.labelRamCount.Text = "999";
            this.labelRamCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartFlockSzOverTime);
            this.panel1.Location = new System.Drawing.Point(31, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 498);
            this.panel1.TabIndex = 4;
            // 
            // chartFlockSzOverTime
            // 
            this.chartFlockSzOverTime.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartFlockSzOverTime.ChartAreas.Add(chartArea1);
            this.chartFlockSzOverTime.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFlockSzOverTime.Legends.Add(legend1);
            this.chartFlockSzOverTime.Location = new System.Drawing.Point(0, 0);
            this.chartFlockSzOverTime.Name = "chartFlockSzOverTime";
            this.chartFlockSzOverTime.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFlockSzOverTime.Series.Add(series1);
            this.chartFlockSzOverTime.Size = new System.Drawing.Size(1645, 498);
            this.chartFlockSzOverTime.TabIndex = 0;
            this.chartFlockSzOverTime.Text = "chart1";
            // 
            // pictureBoxiLamb
            // 
            this.pictureBoxiLamb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxiLamb.Image = global::iLambDotNetFramework.Properties.Resources.iLambLogoGrey;
            this.pictureBoxiLamb.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxiLamb.Name = "pictureBoxiLamb";
            this.pictureBoxiLamb.Size = new System.Drawing.Size(390, 161);
            this.pictureBoxiLamb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxiLamb.TabIndex = 0;
            this.pictureBoxiLamb.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1705, 877);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRams);
            this.Controls.Add(this.panelEwes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSheep);
            this.Name = "DashboardForm";
            this.panelSheep.ResumeLayout(false);
            this.panelSheep.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelEwes.ResumeLayout(false);
            this.panelEwes.PerformLayout();
            this.panelRams.ResumeLayout(false);
            this.panelRams.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFlockSzOverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiLamb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSheep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEwes;
        private System.Windows.Forms.Label labelEwe;
        private System.Windows.Forms.Panel panelRams;
        private System.Windows.Forms.Label labelEweCount;
        private System.Windows.Forms.Label labelSheep;
        private System.Windows.Forms.Label labelSheepCount;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelRamCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlockSzOverTime;
        private System.Windows.Forms.Label labelSheepGreater;
        private System.Windows.Forms.Label labelEweGreater;
        private System.Windows.Forms.Label labelRamGreater;
        private System.Windows.Forms.PictureBox pictureBoxiLamb;
    }
}