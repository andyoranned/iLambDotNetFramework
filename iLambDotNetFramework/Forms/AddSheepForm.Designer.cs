namespace iLambDotNetFramework.Forms
{
    partial class AddSheepForm
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
            this.splitContainerAddSheep = new System.Windows.Forms.SplitContainer();
            this.panelGetPic = new System.Windows.Forms.Panel();
            this.buttonBackAddS = new System.Windows.Forms.Button();
            this.buttonNextAddS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddSheep)).BeginInit();
            this.splitContainerAddSheep.Panel1.SuspendLayout();
            this.splitContainerAddSheep.Panel2.SuspendLayout();
            this.splitContainerAddSheep.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAddSheep
            // 
            this.splitContainerAddSheep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAddSheep.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAddSheep.Name = "splitContainerAddSheep";
            this.splitContainerAddSheep.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAddSheep.Panel1
            // 
            this.splitContainerAddSheep.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.splitContainerAddSheep.Panel1.Controls.Add(this.panelGetPic);
            // 
            // splitContainerAddSheep.Panel2
            // 
            this.splitContainerAddSheep.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.splitContainerAddSheep.Panel2.Controls.Add(this.buttonBackAddS);
            this.splitContainerAddSheep.Panel2.Controls.Add(this.buttonNextAddS);
            this.splitContainerAddSheep.Size = new System.Drawing.Size(1478, 810);
            this.splitContainerAddSheep.SplitterDistance = 724;
            this.splitContainerAddSheep.TabIndex = 2;
            // 
            // panelGetPic
            // 
            this.panelGetPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.panelGetPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGetPic.Location = new System.Drawing.Point(0, 0);
            this.panelGetPic.Name = "panelGetPic";
            this.panelGetPic.Size = new System.Drawing.Size(1478, 724);
            this.panelGetPic.TabIndex = 1;
            // 
            // buttonBackAddS
            // 
            this.buttonBackAddS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBackAddS.BackgroundImage = global::iLambDotNetFramework.Properties.Resources.icons8_arrow_48_1_;
            this.buttonBackAddS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackAddS.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBackAddS.Location = new System.Drawing.Point(0, 0);
            this.buttonBackAddS.Name = "buttonBackAddS";
            this.buttonBackAddS.Size = new System.Drawing.Size(74, 82);
            this.buttonBackAddS.TabIndex = 2;
            this.buttonBackAddS.UseVisualStyleBackColor = true;
            // 
            // buttonNextAddS
            // 
            this.buttonNextAddS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNextAddS.BackgroundImage = global::iLambDotNetFramework.Properties.Resources.icons8_arrow_48;
            this.buttonNextAddS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextAddS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextAddS.Location = new System.Drawing.Point(1404, 0);
            this.buttonNextAddS.Name = "buttonNextAddS";
            this.buttonNextAddS.Size = new System.Drawing.Size(74, 82);
            this.buttonNextAddS.TabIndex = 1;
            this.buttonNextAddS.UseVisualStyleBackColor = true;
            // 
            // AddSheepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1478, 810);
            this.Controls.Add(this.splitContainerAddSheep);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSheepForm";
            this.Text = "AddSheep";
            this.Load += new System.EventHandler(this.AddSheepForm_Load);
            this.splitContainerAddSheep.Panel1.ResumeLayout(false);
            this.splitContainerAddSheep.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAddSheep)).EndInit();
            this.splitContainerAddSheep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerAddSheep;
        private System.Windows.Forms.Button buttonNextAddS;
        private System.Windows.Forms.Button buttonBackAddS;
        private System.Windows.Forms.Panel panelGetPic;
    }
}