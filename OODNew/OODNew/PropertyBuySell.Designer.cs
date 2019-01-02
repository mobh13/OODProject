namespace OODNew
{
    partial class PropertyBuySell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyBuySell));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbProperties = new System.Windows.Forms.ComboBox();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.cmbSeekers = new System.Windows.Forms.ComboBox();
            this.lblSeekerID = new System.Windows.Forms.Label();
            this.cmbOwners = new System.Windows.Forms.ComboBox();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Navy;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(546, 166);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(532, 75);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Buy && Sell Property";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-2, -76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 317);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDelete.Location = new System.Drawing.Point(284, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Buy && Sell";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(684, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 39);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Clsoe";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(482, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 39);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cmbProperties
            // 
            this.cmbProperties.AllowDrop = true;
            this.cmbProperties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProperties.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProperties.FormattingEnabled = true;
            this.cmbProperties.Location = new System.Drawing.Point(246, 312);
            this.cmbProperties.Name = "cmbProperties";
            this.cmbProperties.Size = new System.Drawing.Size(221, 42);
            this.cmbProperties.TabIndex = 35;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyID.Location = new System.Drawing.Point(70, 315);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(170, 34);
            this.lblPropertyID.TabIndex = 34;
            this.lblPropertyID.Text = "Property ID:";
            // 
            // cmbSeekers
            // 
            this.cmbSeekers.AllowDrop = true;
            this.cmbSeekers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSeekers.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeekers.FormattingEnabled = true;
            this.cmbSeekers.Location = new System.Drawing.Point(721, 307);
            this.cmbSeekers.Name = "cmbSeekers";
            this.cmbSeekers.Size = new System.Drawing.Size(221, 42);
            this.cmbSeekers.TabIndex = 37;
            // 
            // lblSeekerID
            // 
            this.lblSeekerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeekerID.AutoSize = true;
            this.lblSeekerID.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeekerID.Location = new System.Drawing.Point(545, 310);
            this.lblSeekerID.Name = "lblSeekerID";
            this.lblSeekerID.Size = new System.Drawing.Size(147, 34);
            this.lblSeekerID.TabIndex = 36;
            this.lblSeekerID.Text = "Seeker ID:";
            // 
            // cmbOwners
            // 
            this.cmbOwners.AllowDrop = true;
            this.cmbOwners.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOwners.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOwners.FormattingEnabled = true;
            this.cmbOwners.Location = new System.Drawing.Point(504, 394);
            this.cmbOwners.Name = "cmbOwners";
            this.cmbOwners.Size = new System.Drawing.Size(221, 42);
            this.cmbOwners.TabIndex = 39;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblOwnerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerID.Location = new System.Drawing.Point(328, 397);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(148, 34);
            this.lblOwnerID.TabIndex = 38;
            this.lblOwnerID.Text = "Owner ID:";
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
            // PropertyBuySell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1079, 614);
            this.Controls.Add(this.cmbOwners);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.cmbSeekers);
            this.Controls.Add(this.lblSeekerID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbProperties);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PropertyBuySell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy and Sell Property";
            this.Load += new System.EventHandler(this.ProfileView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbProperties;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.ComboBox cmbSeekers;
        private System.Windows.Forms.Label lblSeekerID;
        private System.Windows.Forms.ComboBox cmbOwners;
        private System.Windows.Forms.Label lblOwnerID;
    }
}