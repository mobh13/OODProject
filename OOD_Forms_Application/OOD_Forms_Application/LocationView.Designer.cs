namespace OOD_Forms_Application
{
    partial class LocationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationView));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblSubID = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lblTitle.Location = new System.Drawing.Point(650, 172);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(417, 69);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "View Location";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 243);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLocationId
            // 
            this.lblLocationId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationId.Location = new System.Drawing.Point(258, 277);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(177, 34);
            this.lblLocationId.TabIndex = 6;
            this.lblLocationId.Text = "Location ID:";
            // 
            // cmbLocations
            // 
            this.cmbLocations.AllowDrop = true;
            this.cmbLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLocations.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(447, 273);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(298, 42);
            this.cmbLocations.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(762, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(37, 333);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(939, 2);
            this.lblLine.TabIndex = 9;
            // 
            // lblLocationName
            // 
            this.lblLocationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(217, 388);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(218, 32);
            this.lblLocationName.TabIndex = 10;
            this.lblLocationName.Text = "Location Name:";
            this.lblLocationName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSubID
            // 
            this.lblSubID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubID.AutoSize = true;
            this.lblSubID.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubID.Location = new System.Drawing.Point(217, 456);
            this.lblSubID.Name = "lblSubID";
            this.lblSubID.Size = new System.Drawing.Size(226, 32);
            this.lblSubID.TabIndex = 16;
            this.lblSubID.Text = "Location Sub ID: ";
            this.lblSubID.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocationName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.Location = new System.Drawing.Point(447, 388);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.ReadOnly = true;
            this.txtLocationName.Size = new System.Drawing.Size(298, 39);
            this.txtLocationName.TabIndex = 22;
            this.txtLocationName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSubID
            // 
            this.txtSubID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubID.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubID.Location = new System.Drawing.Point(447, 456);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.ReadOnly = true;
            this.txtSubID.Size = new System.Drawing.Size(298, 39);
            this.txtSubID.TabIndex = 28;
            this.txtSubID.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(389, 568);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 39);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(555, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 39);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Clsoe";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LocationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1079, 641);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSubID);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.lblSubID);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbLocations);
            this.Controls.Add(this.lblLocationId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "LocationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Location";
            this.Load += new System.EventHandler(this.ProfileView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblSubID;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}