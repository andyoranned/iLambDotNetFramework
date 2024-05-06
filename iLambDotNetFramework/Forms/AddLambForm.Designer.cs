namespace iLambDotNetFramework.Forms
{
    partial class AddLambForm
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
            this.splitContainerNav = new System.Windows.Forms.SplitContainer();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNav)).BeginInit();
            this.splitContainerNav.Panel2.SuspendLayout();
            this.splitContainerNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerNav
            // 
            this.splitContainerNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNav.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNav.Name = "splitContainerNav";
            this.splitContainerNav.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerNav.Panel1
            // 
            this.splitContainerNav.Panel1.AutoScroll = true;
            this.splitContainerNav.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(109)))));
            // 
            // splitContainerNav.Panel2
            // 
            this.splitContainerNav.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.splitContainerNav.Panel2.Controls.Add(this.buttonSave);
            this.splitContainerNav.Panel2MinSize = 45;
            this.splitContainerNav.Size = new System.Drawing.Size(1478, 810);
            this.splitContainerNav.SplitterDistance = 750;
            this.splitContainerNav.TabIndex = 0;
            this.splitContainerNav.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.BackgroundImage = global::iLambDotNetFramework.Properties.Resources.icons8_arrow_48;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.Location = new System.Drawing.Point(1430, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(48, 56);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddLambForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 810);
            this.Controls.Add(this.splitContainerNav);
            this.Name = "AddLambForm";
            this.splitContainerNav.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNav)).EndInit();
            this.splitContainerNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerNav;
        public System.Windows.Forms.Button buttonSave;
    }
}