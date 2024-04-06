namespace iLambDotNetFramework
{
    partial class UserControlLamb
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
            this.splitContainerPicNInfo = new System.Windows.Forms.SplitContainer();
            this.pictureBoxSheepUC = new System.Windows.Forms.PictureBox();
            this.buttonPedigree = new System.Windows.Forms.Button();
            this.buttonSheepInfo = new System.Windows.Forms.Button();
            this.textBoxDoB = new System.Windows.Forms.TextBox();
            this.textBoxEarTag = new System.Windows.Forms.TextBox();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDoB = new System.Windows.Forms.Label();
            this.labelEarTag = new System.Windows.Forms.Label();
            this.labelSheepName = new System.Windows.Forms.Label();
            this.labelSheepSex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPicNInfo)).BeginInit();
            this.splitContainerPicNInfo.Panel1.SuspendLayout();
            this.splitContainerPicNInfo.Panel2.SuspendLayout();
            this.splitContainerPicNInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheepUC)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerPicNInfo
            // 
            this.splitContainerPicNInfo.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerPicNInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPicNInfo.Location = new System.Drawing.Point(1, 1);
            this.splitContainerPicNInfo.Name = "splitContainerPicNInfo";
            // 
            // splitContainerPicNInfo.Panel1
            // 
            this.splitContainerPicNInfo.Panel1.Controls.Add(this.pictureBoxSheepUC);
            // 
            // splitContainerPicNInfo.Panel2
            // 
            this.splitContainerPicNInfo.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.buttonPedigree);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.buttonSheepInfo);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.textBoxDoB);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.textBoxEarTag);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.textBoxSex);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.textBoxName);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.labelDoB);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.labelEarTag);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.labelSheepName);
            this.splitContainerPicNInfo.Panel2.Controls.Add(this.labelSheepSex);
            this.splitContainerPicNInfo.Size = new System.Drawing.Size(718, 198);
            this.splitContainerPicNInfo.SplitterDistance = 239;
            this.splitContainerPicNInfo.TabIndex = 0;
            // 
            // pictureBoxSheepUC
            // 
            this.pictureBoxSheepUC.BackgroundImage = global::iLambDotNetFramework.Properties.Resources.sheep_head_publicdomain;
            this.pictureBoxSheepUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSheepUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSheepUC.InitialImage = global::iLambDotNetFramework.Properties.Resources.sheep_head_publicdomain;
            this.pictureBoxSheepUC.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSheepUC.Name = "pictureBoxSheepUC";
            this.pictureBoxSheepUC.Padding = new System.Windows.Forms.Padding(15);
            this.pictureBoxSheepUC.Size = new System.Drawing.Size(239, 198);
            this.pictureBoxSheepUC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSheepUC.TabIndex = 0;
            this.pictureBoxSheepUC.TabStop = false;
            // 
            // buttonPedigree
            // 
            this.buttonPedigree.Location = new System.Drawing.Point(307, 117);
            this.buttonPedigree.Name = "buttonPedigree";
            this.buttonPedigree.Size = new System.Drawing.Size(125, 48);
            this.buttonPedigree.TabIndex = 9;
            this.buttonPedigree.Text = "Pedigree";
            this.buttonPedigree.UseVisualStyleBackColor = true;
            this.buttonPedigree.Click += new System.EventHandler(this.buttonPedigree_Click);
            // 
            // buttonSheepInfo
            // 
            this.buttonSheepInfo.Location = new System.Drawing.Point(307, 33);
            this.buttonSheepInfo.Name = "buttonSheepInfo";
            this.buttonSheepInfo.Size = new System.Drawing.Size(125, 48);
            this.buttonSheepInfo.TabIndex = 8;
            this.buttonSheepInfo.Text = "Information";
            this.buttonSheepInfo.UseVisualStyleBackColor = true;
            this.buttonSheepInfo.Click += new System.EventHandler(this.buttonSheepInfo_Click);
            // 
            // textBoxDoB
            // 
            this.textBoxDoB.Location = new System.Drawing.Point(106, 154);
            this.textBoxDoB.Name = "textBoxDoB";
            this.textBoxDoB.ReadOnly = true;
            this.textBoxDoB.Size = new System.Drawing.Size(132, 26);
            this.textBoxDoB.TabIndex = 7;
            // 
            // textBoxEarTag
            // 
            this.textBoxEarTag.Location = new System.Drawing.Point(106, 106);
            this.textBoxEarTag.Name = "textBoxEarTag";
            this.textBoxEarTag.ReadOnly = true;
            this.textBoxEarTag.Size = new System.Drawing.Size(132, 26);
            this.textBoxEarTag.TabIndex = 6;
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(106, 61);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.ReadOnly = true;
            this.textBoxSex.Size = new System.Drawing.Size(132, 26);
            this.textBoxSex.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(132, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Location = new System.Drawing.Point(31, 157);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(45, 20);
            this.labelDoB.TabIndex = 3;
            this.labelDoB.Text = "DoB:";
            // 
            // labelEarTag
            // 
            this.labelEarTag.AutoSize = true;
            this.labelEarTag.Location = new System.Drawing.Point(31, 109);
            this.labelEarTag.Name = "labelEarTag";
            this.labelEarTag.Size = new System.Drawing.Size(69, 20);
            this.labelEarTag.TabIndex = 2;
            this.labelEarTag.Text = "Ear Tag:";
            // 
            // labelSheepName
            // 
            this.labelSheepName.AutoSize = true;
            this.labelSheepName.Location = new System.Drawing.Point(31, 21);
            this.labelSheepName.Name = "labelSheepName";
            this.labelSheepName.Size = new System.Drawing.Size(55, 20);
            this.labelSheepName.TabIndex = 1;
            this.labelSheepName.Text = "Name:";
            // 
            // labelSheepSex
            // 
            this.labelSheepSex.AutoSize = true;
            this.labelSheepSex.Location = new System.Drawing.Point(31, 64);
            this.labelSheepSex.Name = "labelSheepSex";
            this.labelSheepSex.Size = new System.Drawing.Size(40, 20);
            this.labelSheepSex.TabIndex = 0;
            this.labelSheepSex.Text = "Sex:";
            // 
            // UserControlLamb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.splitContainerPicNInfo);
            this.Name = "UserControlLamb";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(720, 200);
            this.splitContainerPicNInfo.Panel1.ResumeLayout(false);
            this.splitContainerPicNInfo.Panel2.ResumeLayout(false);
            this.splitContainerPicNInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPicNInfo)).EndInit();
            this.splitContainerPicNInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheepUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerPicNInfo;
        private System.Windows.Forms.PictureBox pictureBoxSheepUC;
        private System.Windows.Forms.Label labelSheepName;
        private System.Windows.Forms.Label labelSheepSex;
        private System.Windows.Forms.Label labelDoB;
        private System.Windows.Forms.Label labelEarTag;
        private System.Windows.Forms.TextBox textBoxDoB;
        private System.Windows.Forms.TextBox textBoxEarTag;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonPedigree;
        private System.Windows.Forms.Button buttonSheepInfo;
    }
}
