namespace OOD_Forms_Application
{
    partial class ControlPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("View");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Search");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Profile", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("View");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Search");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Sell & Buy");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Property", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("View");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Search");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Location", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.slidShow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Navy;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(681, 173);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Control Panel";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, -49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 291);
            this.label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(12, 248);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "View";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Search";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Add";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Edit";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Delete";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Profile";
            treeNode7.Name = "Node8";
            treeNode7.Text = "View";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Search";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Add";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Edit";
            treeNode11.Name = "Node12";
            treeNode11.Text = "Delete";
            treeNode12.Name = "Node18";
            treeNode12.Text = "Sell & Buy";
            treeNode13.Name = "Node1";
            treeNode13.Text = "Property";
            treeNode14.Name = "Node13";
            treeNode14.Text = "View";
            treeNode15.Name = "Node14";
            treeNode15.Text = "Search";
            treeNode16.Name = "Node15";
            treeNode16.Text = "Add";
            treeNode17.Name = "Node16";
            treeNode17.Text = "Edit";
            treeNode18.Name = "Node17";
            treeNode18.Text = "Delete";
            treeNode19.Name = "Node2";
            treeNode19.Text = "Location";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode13,
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(249, 440);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // slidShow
            // 
            this.slidShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.slidShow.Image = ((System.Drawing.Image)(resources.GetObject("slidShow.Image")));
            this.slidShow.Location = new System.Drawing.Point(340, 259);
            this.slidShow.Name = "slidShow";
            this.slidShow.Size = new System.Drawing.Size(687, 388);
            this.slidShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidShow.TabIndex = 5;
            this.slidShow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1093, 665);
            this.Controls.Add(this.slidShow);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox slidShow;
        private System.Windows.Forms.Timer timer1;
    }
}

