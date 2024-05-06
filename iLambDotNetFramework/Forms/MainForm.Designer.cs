namespace iLambDotNetFramework
{
    partial class MainForm
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
            this.navToolStrip = new System.Windows.Forms.ToolStrip();
            this.panelNavDisplay = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripButtonAddSheep = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDashboard = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFlock = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.farmPictureBox = new System.Windows.Forms.PictureBox();
            this.navToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navToolStrip
            // 
            this.navToolStrip.BackColor = System.Drawing.Color.White;
            this.navToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.navToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.navToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddSheep,
            this.toolStripButtonDashboard,
            this.toolStripButtonFlock,
            this.toolStripButtonSearch});
            this.navToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.navToolStrip.Location = new System.Drawing.Point(0, 0);
            this.navToolStrip.Name = "navToolStrip";
            this.navToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.navToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.navToolStrip.Size = new System.Drawing.Size(178, 933);
            this.navToolStrip.TabIndex = 0;
            this.navToolStrip.Text = "toolStrip1";
            // 
            // panelNavDisplay
            // 
            this.panelNavDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelNavDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(109)))));
            this.panelNavDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelNavDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavDisplay.Name = "panelNavDisplay";
            this.panelNavDisplay.Size = new System.Drawing.Size(1727, 933);
            this.panelNavDisplay.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 117);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navToolStrip);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelNavDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 933);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStripButtonAddSheep
            // 
            this.toolStripButtonAddSheep.AutoSize = false;
            this.toolStripButtonAddSheep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButtonAddSheep.Image = global::iLambDotNetFramework.Properties.Resources.icons8_dorper_sheep_50;
            this.toolStripButtonAddSheep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonAddSheep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddSheep.Name = "toolStripButtonAddSheep";
            this.toolStripButtonAddSheep.Size = new System.Drawing.Size(175, 50);
            this.toolStripButtonAddSheep.Text = "Add Sheep";
            this.toolStripButtonAddSheep.Click += new System.EventHandler(this.toolStripButtonAddSheep_Click);
            // 
            // toolStripButtonDashboard
            // 
            this.toolStripButtonDashboard.AutoSize = false;
            this.toolStripButtonDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButtonDashboard.Image = global::iLambDotNetFramework.Properties.Resources.dashboard_dark;
            this.toolStripButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDashboard.Name = "toolStripButtonDashboard";
            this.toolStripButtonDashboard.Size = new System.Drawing.Size(175, 50);
            this.toolStripButtonDashboard.Text = "Dashboard";
            this.toolStripButtonDashboard.Click += new System.EventHandler(this.toolStripButtonDashboard_Click);
            // 
            // toolStripButtonFlock
            // 
            this.toolStripButtonFlock.AutoSize = false;
            this.toolStripButtonFlock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButtonFlock.Image = global::iLambDotNetFramework.Properties.Resources.pasture_color;
            this.toolStripButtonFlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFlock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFlock.Name = "toolStripButtonFlock";
            this.toolStripButtonFlock.Size = new System.Drawing.Size(175, 50);
            this.toolStripButtonFlock.Text = "Flock";
            this.toolStripButtonFlock.Click += new System.EventHandler(this.toolStripButtonFlock_Click);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.AutoSize = false;
            this.toolStripButtonSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButtonSearch.Image = global::iLambDotNetFramework.Properties.Resources.icons8_sheep_60;
            this.toolStripButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(175, 50);
            this.toolStripButtonSearch.Text = "Search";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.headerPanel.BackgroundImage = global::iLambDotNetFramework.Properties.Resources.farmland;
            this.headerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPanel.Controls.Add(this.farmPictureBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1924, 117);
            this.headerPanel.TabIndex = 2;
            // 
            // farmPictureBox
            // 
            this.farmPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.farmPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.farmPictureBox.Image = global::iLambDotNetFramework.Properties.Resources.gummy_farming;
            this.farmPictureBox.Location = new System.Drawing.Point(1740, 0);
            this.farmPictureBox.Name = "farmPictureBox";
            this.farmPictureBox.Size = new System.Drawing.Size(184, 117);
            this.farmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.farmPictureBox.TabIndex = 0;
            this.farmPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1800, 1006);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navToolStrip.ResumeLayout(false);
            this.navToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.farmPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip navToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddSheep;
        private System.Windows.Forms.ToolStripButton toolStripButtonDashboard;
        private System.Windows.Forms.ToolStripButton toolStripButtonFlock;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox farmPictureBox;
        public System.Windows.Forms.Panel panelNavDisplay;
    }
}

