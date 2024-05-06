namespace iLambDotNetFramework
{
    partial class LambUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelEarTag = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.pictureBoxSheep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheep)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoEllipsis = true;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(0, 220);
            this.labelName.MaximumSize = new System.Drawing.Size(150, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 29);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelEarTag
            // 
            this.labelEarTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEarTag.AutoSize = true;
            this.labelEarTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarTag.Location = new System.Drawing.Point(1, 257);
            this.labelEarTag.Name = "labelEarTag";
            this.labelEarTag.Size = new System.Drawing.Size(86, 20);
            this.labelEarTag.TabIndex = 2;
            this.labelEarTag.Text = "NR203433";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(187, 257);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(60, 20);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "5 years";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Image = global::iLambDotNetFramework.Properties.Resources.icons8_female_16;
            this.labelGender.Location = new System.Drawing.Point(219, 224);
            this.labelGender.MinimumSize = new System.Drawing.Size(25, 25);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(25, 25);
            this.labelGender.TabIndex = 4;
            // 
            // pictureBoxSheep
            // 
            this.pictureBoxSheep.Location = new System.Drawing.Point(5, 4);
            this.pictureBoxSheep.Name = "pictureBoxSheep";
            this.pictureBoxSheep.Size = new System.Drawing.Size(239, 198);
            this.pictureBoxSheep.TabIndex = 0;
            this.pictureBoxSheep.TabStop = false;
            // 
            // LambUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelEarTag);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxSheep);
            this.Name = "LambUserControl";
            this.Size = new System.Drawing.Size(250, 300);
            this.Click += new System.EventHandler(this.LambUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSheep;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEarTag;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
    }
}
