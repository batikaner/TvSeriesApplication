namespace TvSeriesApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnChoose = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbSeries = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDegistir = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lvComment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(213, 80);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(87, 40);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Dizi Seç";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(32, 320);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbSeries
            // 
            this.cmbSeries.BackColor = System.Drawing.Color.Coral;
            this.cmbSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeries.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbSeries.Location = new System.Drawing.Point(75, 12);
            this.cmbSeries.Name = "cmbSeries";
            this.cmbSeries.Size = new System.Drawing.Size(225, 21);
            this.cmbSeries.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::TvSeriesApplication.Properties.Resources.cRickc_;
            this.pictureBox1.Location = new System.Drawing.Point(561, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtDegistir
            // 
            this.txtDegistir.Location = new System.Drawing.Point(200, 41);
            this.txtDegistir.Name = "txtDegistir";
            this.txtDegistir.Size = new System.Drawing.Size(100, 20);
            this.txtDegistir.TabIndex = 9;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(134, 320);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 13);
            this.lblRating.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TvSeriesApplication.Properties.Resources.cRickc_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 251);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(35, 482);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(144, 23);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Ana Sayfayı Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 285);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "User : ";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(577, 436);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(216, 20);
            this.txtComment.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(718, 462);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lvComment
            // 
            this.lvComment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvComment.FullRowSelect = true;
            this.lvComment.HideSelection = false;
            this.lvComment.Location = new System.Drawing.Point(524, 195);
            this.lvComment.Name = "lvComment";
            this.lvComment.Size = new System.Drawing.Size(251, 216);
            this.lvComment.TabIndex = 18;
            this.lvComment.UseCompatibleStateImageBehavior = false;
            this.lvComment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serie ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.lvComment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtDegistir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbSeries);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnChoose);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtDegistir;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ComboBox cmbSeries;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListView lvComment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}