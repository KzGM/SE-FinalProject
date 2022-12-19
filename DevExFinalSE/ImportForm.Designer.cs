namespace DevExFinalSE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAccID = new System.Windows.Forms.ComboBox();
            this.accountantBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.test_se2DataSet2 = new DevExFinalSE.test_se2DataSet2();
            this.accountantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtIID = new System.Windows.Forms.TextBox();
            this.lblimportid = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodManageDataSet = new DevExFinalSE.GoodManageDataSet();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkIID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ImportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountantID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkAccID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkPID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImportPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.accountantTableAdapter = new DevExFinalSE.GoodManageDataSetTableAdapters.AccountantTableAdapter();
            this.test_se2DataSet = new DevExFinalSE.test_se2DataSet();
            this.testse2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testse2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailTableAdapter = new DevExFinalSE.test_se2DataSet2TableAdapters.OrderDetailTableAdapter();
            this.orderDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new DevExFinalSE.test_se2DataSet2TableAdapters.OrdersTableAdapter();
            this.accountantTableAdapter1 = new DevExFinalSE.test_se2DataSet2TableAdapters.AccountantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkIID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkAccID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testse2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testse2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.txtTotal);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.cbAccID);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtIID);
            this.panelControl1.Controls.Add(this.lblimportid);
            this.panelControl1.Controls.Add(this.datePicker);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(834, 132);
            this.panelControl1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.Location = new System.Drawing.Point(616, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 50);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(722, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(722, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(342, 76);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 28);
            this.txtTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // cbAccID
            // 
            this.cbAccID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountantBindingSource2, "AccountantID", true));
            this.cbAccID.DataSource = this.accountantBindingSource1;
            this.cbAccID.DisplayMember = "AccountantID";
            this.cbAccID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccID.FormattingEnabled = true;
            this.cbAccID.Location = new System.Drawing.Point(156, 76);
            this.cbAccID.Name = "cbAccID";
            this.cbAccID.Size = new System.Drawing.Size(121, 29);
            this.cbAccID.TabIndex = 5;
            this.cbAccID.ValueMember = "AccountantID";
            this.cbAccID.SelectedIndexChanged += new System.EventHandler(this.cbAccID_SelectedIndexChanged);
            // 
            // accountantBindingSource2
            // 
            this.accountantBindingSource2.DataMember = "Accountant";
            this.accountantBindingSource2.DataSource = this.test_se2DataSet2;
            // 
            // test_se2DataSet2
            // 
            this.test_se2DataSet2.DataSetName = "test_se2DataSet2";
            this.test_se2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantBindingSource1
            // 
            this.accountantBindingSource1.DataMember = "Accountant";
            this.accountantBindingSource1.DataSource = this.test_se2DataSet2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accountant ID";
            // 
            // txtIID
            // 
            this.txtIID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIID.Location = new System.Drawing.Point(157, 29);
            this.txtIID.Name = "txtIID";
            this.txtIID.Size = new System.Drawing.Size(118, 28);
            this.txtIID.TabIndex = 3;
            this.txtIID.TextChanged += new System.EventHandler(this.txtIID_TextChanged);
            // 
            // lblimportid
            // 
            this.lblimportid.AutoSize = true;
            this.lblimportid.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimportid.Location = new System.Drawing.Point(33, 33);
            this.lblimportid.Name = "lblimportid";
            this.lblimportid.Size = new System.Drawing.Size(83, 21);
            this.lblimportid.TabIndex = 2;
            this.lblimportid.Text = "Import ID";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(340, 28);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(134, 28);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "Accountant";
            this.accountantBindingSource.DataSource = this.goodManageDataSet;
            // 
            // goodManageDataSet
            // 
            this.goodManageDataSet.DataSetName = "GoodManageDataSet";
            this.goodManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 132);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkPID,
            this.lkIID,
            this.lkAccID});
            this.gridControl1.Size = new System.Drawing.Size(834, 422);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.IID,
            this.ImportDate,
            this.AccountantID,
            this.ProductID,
            this.ProductName,
            this.ImportPrice,
            this.Quantity,
            this.Total});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", this.Total, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 32;
            // 
            // IID
            // 
            this.IID.Caption = "Import ID";
            this.IID.ColumnEdit = this.lkIID;
            this.IID.FieldName = "IID";
            this.IID.MinWidth = 25;
            this.IID.Name = "IID";
            this.IID.Visible = true;
            this.IID.VisibleIndex = 1;
            this.IID.Width = 77;
            // 
            // lkIID
            // 
            this.lkIID.AutoHeight = false;
            this.lkIID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkIID.Name = "lkIID";
            // 
            // ImportDate
            // 
            this.ImportDate.Caption = "Import Date";
            this.ImportDate.FieldName = "ImportDate";
            this.ImportDate.MinWidth = 25;
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.Visible = true;
            this.ImportDate.VisibleIndex = 2;
            this.ImportDate.Width = 120;
            // 
            // AccountantID
            // 
            this.AccountantID.Caption = "Accountant ID";
            this.AccountantID.ColumnEdit = this.lkAccID;
            this.AccountantID.FieldName = "AccountantID";
            this.AccountantID.MinWidth = 25;
            this.AccountantID.Name = "AccountantID";
            this.AccountantID.Visible = true;
            this.AccountantID.VisibleIndex = 3;
            this.AccountantID.Width = 92;
            // 
            // lkAccID
            // 
            this.lkAccID.AutoHeight = false;
            this.lkAccID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkAccID.Name = "lkAccID";
            // 
            // ProductID
            // 
            this.ProductID.Caption = "Product ID";
            this.ProductID.ColumnEdit = this.lkPID;
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 25;
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 4;
            this.ProductID.Width = 81;
            // 
            // lkPID
            // 
            this.lkPID.AutoHeight = false;
            this.lkPID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPID.Name = "lkPID";
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 5;
            this.ProductName.Width = 94;
            // 
            // ImportPrice
            // 
            this.ImportPrice.Caption = "Import Price";
            this.ImportPrice.FieldName = "ImportPrice";
            this.ImportPrice.MinWidth = 25;
            this.ImportPrice.Name = "ImportPrice";
            this.ImportPrice.Visible = true;
            this.ImportPrice.VisibleIndex = 6;
            this.ImportPrice.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 25;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 7;
            this.Quantity.Width = 94;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "TotalPrice";
            this.Total.MinWidth = 25;
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 8;
            this.Total.Width = 94;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // test_se2DataSet
            // 
            this.test_se2DataSet.DataSetName = "test_se2DataSet";
            this.test_se2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testse2DataSetBindingSource
            // 
            this.testse2DataSetBindingSource.DataSource = this.test_se2DataSet;
            this.testse2DataSetBindingSource.Position = 0;
            // 
            // testse2DataSetBindingSource1
            // 
            this.testse2DataSetBindingSource1.DataSource = this.test_se2DataSet;
            this.testse2DataSetBindingSource1.Position = 0;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "OrderDetail";
            this.orderDetailBindingSource.DataSource = this.test_se2DataSet2;
            // 
            // orderDetailTableAdapter
            // 
            this.orderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // orderDetailBindingSource1
            // 
            this.orderDetailBindingSource1.DataMember = "OrderDetail";
            this.orderDetailBindingSource1.DataSource = this.test_se2DataSet2;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.test_se2DataSet2;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // accountantTableAdapter1
            // 
            this.accountantTableAdapter1.ClearBeforeFill = true;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 554);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkIID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkAccID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testse2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testse2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox txtIID;
        private System.Windows.Forms.Label lblimportid;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private GoodManageDataSet goodManageDataSet;
        private System.Windows.Forms.BindingSource accountantBindingSource;
        private GoodManageDataSetTableAdapters.AccountantTableAdapter accountantTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn IID;
        private DevExpress.XtraGrid.Columns.GridColumn ImportDate;
        private DevExpress.XtraGrid.Columns.GridColumn AccountantID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkIID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkPID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkAccID;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn ImportPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private test_se2DataSet test_se2DataSet;
        private System.Windows.Forms.BindingSource testse2DataSetBindingSource;
        private System.Windows.Forms.BindingSource testse2DataSetBindingSource1;
        private test_se2DataSet2 test_se2DataSet2;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private test_se2DataSet2TableAdapters.OrderDetailTableAdapter orderDetailTableAdapter;
        private System.Windows.Forms.BindingSource orderDetailBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private test_se2DataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource accountantBindingSource1;
        private test_se2DataSet2TableAdapters.AccountantTableAdapter accountantTableAdapter1;
        private System.Windows.Forms.BindingSource accountantBindingSource2;
    }
}