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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMenuNavigation = new System.Windows.Forms.MenuStrip();
            this.subMenuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buySellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.slidShow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenuNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 243);
            this.label1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenuNavigation
            // 
            this.MainMenuNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainMenuNavigation.AutoSize = false;
            this.MainMenuNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuNavigation.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenuNavigation.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuNavigation.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuProfile,
            this.subMenuProperty,
            this.subMenuLocation});
            this.MainMenuNavigation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.MainMenuNavigation.Location = new System.Drawing.Point(12, 259);
            this.MainMenuNavigation.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenuNavigation.Name = "MainMenuNavigation";
            this.MainMenuNavigation.Size = new System.Drawing.Size(257, 232);
            this.MainMenuNavigation.TabIndex = 6;
            this.MainMenuNavigation.Text = "MainMenuNavigation";
            this.MainMenuNavigation.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // subMenuProfile
            // 
            this.subMenuProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.subMenuProfile.Image = global::OOD_Forms_Application.Properties.Resources.radio_dot_1018892;
            this.subMenuProfile.Name = "subMenuProfile";
            this.subMenuProfile.Size = new System.Drawing.Size(160, 47);
            this.subMenuProfile.Text = "Profile";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(232, 48);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(232, 48);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(232, 48);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(232, 48);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(232, 48);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // subMenuProperty
            // 
            this.subMenuProperty.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.addToolStripMenuItem1,
            this.searchToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.buySellToolStripMenuItem});
            this.subMenuProperty.Image = global::OOD_Forms_Application.Properties.Resources.radio_dot_1018892;
            this.subMenuProperty.Name = "subMenuProperty";
            this.subMenuProperty.Size = new System.Drawing.Size(201, 47);
            this.subMenuProperty.Text = "Property";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(276, 48);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(276, 48);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(276, 48);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(276, 48);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(276, 48);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // buySellToolStripMenuItem
            // 
            this.buySellToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.buySellToolStripMenuItem.Name = "buySellToolStripMenuItem";
            this.buySellToolStripMenuItem.Size = new System.Drawing.Size(276, 48);
            this.buySellToolStripMenuItem.Text = "Buy && Sell";
            this.buySellToolStripMenuItem.Click += new System.EventHandler(this.buySellToolStripMenuItem_Click);
            // 
            // subMenuLocation
            // 
            this.subMenuLocation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem2,
            this.addToolStripMenuItem2,
            this.searchToolStripMenuItem2,
            this.dToolStripMenuItem,
            this.editToolStripMenuItem2});
            this.subMenuLocation.Image = global::OOD_Forms_Application.Properties.Resources.radio_dot_1018892;
            this.subMenuLocation.Name = "subMenuLocation";
            this.subMenuLocation.Size = new System.Drawing.Size(209, 47);
            this.subMenuLocation.Text = "Location";
            // 
            // viewToolStripMenuItem2
            // 
            this.viewToolStripMenuItem2.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            this.viewToolStripMenuItem2.Size = new System.Drawing.Size(232, 48);
            this.viewToolStripMenuItem2.Text = "View";
            this.viewToolStripMenuItem2.Click += new System.EventHandler(this.viewToolStripMenuItem2_Click);
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(232, 48);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // searchToolStripMenuItem2
            // 
            this.searchToolStripMenuItem2.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.searchToolStripMenuItem2.Name = "searchToolStripMenuItem2";
            this.searchToolStripMenuItem2.Size = new System.Drawing.Size(232, 48);
            this.searchToolStripMenuItem2.Text = "Search";
            this.searchToolStripMenuItem2.Click += new System.EventHandler(this.searchToolStripMenuItem2_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(232, 48);
            this.dToolStripMenuItem.Text = "Delete";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Image = global::OOD_Forms_Application.Properties.Resources.forward;
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(232, 48);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // slidShow
            // 
            this.slidShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slidShow.Image = ((System.Drawing.Image)(resources.GetObject("slidShow.Image")));
            this.slidShow.Location = new System.Drawing.Point(340, 259);
            this.slidShow.Name = "slidShow";
            this.slidShow.Size = new System.Drawing.Size(687, 388);
            this.slidShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidShow.TabIndex = 5;
            this.slidShow.TabStop = false;
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
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1093, 665);
            this.Controls.Add(this.MainMenuNavigation);
            this.Controls.Add(this.slidShow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.MainMenuNavigation;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.MainMenuNavigation.ResumeLayout(false);
            this.MainMenuNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox slidShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip MainMenuNavigation;
        private System.Windows.Forms.ToolStripMenuItem subMenuProfile;
        private System.Windows.Forms.ToolStripMenuItem subMenuProperty;
        private System.Windows.Forms.ToolStripMenuItem subMenuLocation;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buySellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
    }
}

