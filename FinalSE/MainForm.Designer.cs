namespace FinalSE
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnRevenue = new FontAwesome.Sharp.IconButton();
            this.BtnDeliveryNote = new FontAwesome.Sharp.IconButton();
            this.BtnImport = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Company = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.panelMenu.Controls.Add(this.BtnRevenue);
            this.panelMenu.Controls.Add(this.BtnDeliveryNote);
            this.panelMenu.Controls.Add(this.BtnImport);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 703);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnRevenue
            // 
            this.BtnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.BtnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRevenue.FlatAppearance.BorderSize = 0;
            this.BtnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevenue.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnRevenue.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.BtnRevenue.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRevenue.Location = new System.Drawing.Point(0, 220);
            this.BtnRevenue.Name = "BtnRevenue";
            this.BtnRevenue.Size = new System.Drawing.Size(220, 60);
            this.BtnRevenue.TabIndex = 2;
            this.BtnRevenue.Text = "Revenue";
            this.BtnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRevenue.UseVisualStyleBackColor = false;
            this.BtnRevenue.Click += new System.EventHandler(this.BtnRevenue_Click);
            // 
            // BtnDeliveryNote
            // 
            this.BtnDeliveryNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.BtnDeliveryNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeliveryNote.FlatAppearance.BorderSize = 0;
            this.BtnDeliveryNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeliveryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeliveryNote.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDeliveryNote.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.BtnDeliveryNote.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDeliveryNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDeliveryNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeliveryNote.Location = new System.Drawing.Point(0, 160);
            this.BtnDeliveryNote.Name = "BtnDeliveryNote";
            this.BtnDeliveryNote.Size = new System.Drawing.Size(220, 60);
            this.BtnDeliveryNote.TabIndex = 1;
            this.BtnDeliveryNote.Text = "Delivery Note";
            this.BtnDeliveryNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeliveryNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeliveryNote.UseVisualStyleBackColor = false;
            this.BtnDeliveryNote.Click += new System.EventHandler(this.BtnDeliveryNote_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.BtnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnImport.FlatAppearance.BorderSize = 0;
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnImport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImport.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImport.Location = new System.Drawing.Point(0, 100);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(220, 60);
            this.BtnImport.TabIndex = 0;
            this.BtnImport.Text = "Import";
            this.BtnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalSE.Properties.Resources._6341806;
            this.pictureBox1.Location = new System.Drawing.Point(58, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1006, 100);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.Transparent;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 14;
            this.btnMax.Location = new System.Drawing.Point(928, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(36, 34);
            this.btnMax.TabIndex = 4;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 14;
            this.btnMin.Location = new System.Drawing.Point(886, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 34);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 14;
            this.btnExit.Location = new System.Drawing.Point(970, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(54, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(64, 25);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 30);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 42);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.UseVisualStyleBackColor = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.BtnHome_Click_1);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1006, 575);
            this.panelDesktop.TabIndex = 3;
            // 
            // Company
            // 
            this.Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.Company.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Company.FlatAppearance.BorderSize = 0;
            this.Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Company.IconColor = System.Drawing.Color.Black;
            this.Company.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Company.Location = new System.Drawing.Point(220, 675);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(1006, 28);
            this.Company.TabIndex = 1;
            this.Company.TabStop = false;
            this.Company.Text = "Nghia Nguyen Co.Ltd";
            this.Company.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 703);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnImport;
        private FontAwesome.Sharp.IconButton BtnRevenue;
        private FontAwesome.Sharp.IconButton BtnDeliveryNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton Company;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

