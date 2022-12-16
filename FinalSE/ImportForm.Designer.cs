namespace FinalSE
{
    partial class ImportForm
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
            this.lblImportID = new System.Windows.Forms.Label();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.lblImportDate = new System.Windows.Forms.Label();
            this.txtImportDate = new System.Windows.Forms.TextBox();
            this.lblAccID = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.dtgImport = new System.Windows.Forms.DataGridView();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImportID
            // 
            this.lblImportID.AutoSize = true;
            this.lblImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblImportID.Location = new System.Drawing.Point(40, 31);
            this.lblImportID.Name = "lblImportID";
            this.lblImportID.Size = new System.Drawing.Size(116, 29);
            this.lblImportID.TabIndex = 0;
            this.lblImportID.Text = "Import ID:";
            // 
            // txtImportID
            // 
            this.txtImportID.Location = new System.Drawing.Point(223, 38);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(182, 22);
            this.txtImportID.TabIndex = 1;
            // 
            // lblImportDate
            // 
            this.lblImportDate.AutoSize = true;
            this.lblImportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblImportDate.Location = new System.Drawing.Point(40, 71);
            this.lblImportDate.Name = "lblImportDate";
            this.lblImportDate.Size = new System.Drawing.Size(143, 29);
            this.lblImportDate.TabIndex = 2;
            this.lblImportDate.Text = "Import Date:";
            // 
            // txtImportDate
            // 
            this.txtImportDate.Location = new System.Drawing.Point(223, 78);
            this.txtImportDate.Name = "txtImportDate";
            this.txtImportDate.Size = new System.Drawing.Size(182, 22);
            this.txtImportDate.TabIndex = 3;
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAccID.Location = new System.Drawing.Point(40, 108);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(177, 29);
            this.lblAccID.TabIndex = 4;
            this.lblAccID.Text = "Accountants ID:";
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(223, 115);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(182, 22);
            this.txtAccID.TabIndex = 5;
            // 
            // dtgImport
            // 
            this.dtgImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgImport.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dtgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImport.Location = new System.Drawing.Point(437, 25);
            this.dtgImport.Name = "dtgImport";
            this.dtgImport.RowHeadersWidth = 51;
            this.dtgImport.RowTemplate.Height = 24;
            this.dtgImport.Size = new System.Drawing.Size(523, 504);
            this.dtgImport.TabIndex = 6;
            this.dtgImport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgImport_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 40;
            this.btnDelete.Location = new System.Drawing.Point(104, 482);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(45, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 47);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(223, 156);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(182, 22);
            this.txtPID.TabIndex = 10;
            this.txtPID.TextChanged += new System.EventHandler(this.txtPID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(40, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product ID:";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(223, 198);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(182, 22);
            this.txtPName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(40, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(223, 241);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(182, 22);
            this.txtQuantity.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(40, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity :";
            // 
            // txtIPrice
            // 
            this.txtIPrice.Location = new System.Drawing.Point(223, 286);
            this.txtIPrice.Name = "txtIPrice";
            this.txtIPrice.Size = new System.Drawing.Size(182, 22);
            this.txtIPrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(40, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Import Price:";
            // 
            // txtTPrice
            // 
            this.txtTPrice.Location = new System.Drawing.Point(223, 327);
            this.txtTPrice.Name = "txtTPrice";
            this.txtTPrice.Size = new System.Drawing.Size(182, 22);
            this.txtTPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(40, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total Price:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassLocation;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 40;
            this.btnSearch.Location = new System.Drawing.Point(164, 482);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 47);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(118)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgImport);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.txtImportDate);
            this.Controls.Add(this.lblImportDate);
            this.Controls.Add(this.txtImportID);
            this.Controls.Add(this.lblImportID);
            this.Name = "ImportForm";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImportID;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.TextBox txtImportDate;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.DataGridView dtgImport;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTPrice;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}