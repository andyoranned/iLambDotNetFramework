namespace iLambDotNetFramework.Forms
{
    partial class FlockForm
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
            this.flowLayoutPanelFlock = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelFlock
            // 
            this.flowLayoutPanelFlock.AutoScroll = true;
            this.flowLayoutPanelFlock.AutoSize = true;
            this.flowLayoutPanelFlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(109)))));
            this.flowLayoutPanelFlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFlock.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFlock.Name = "flowLayoutPanelFlock";
            this.flowLayoutPanelFlock.Size = new System.Drawing.Size(1152, 722);
            this.flowLayoutPanelFlock.TabIndex = 0;
            // 
            // FlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 722);
            this.Controls.Add(this.flowLayoutPanelFlock);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlockForm";
            this.Load += new System.EventHandler(this.FlockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFlock;
    }
}