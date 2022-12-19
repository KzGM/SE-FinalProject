namespace DevExFinalSE
{
    partial class DeliveryNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryNoteForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_se2DataSet2 = new DevExFinalSE.test_se2DataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblimportid = new System.Windows.Forms.Label();
            this.testse2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_se2DataSet = new DevExFinalSE.test_se2DataSet();
            this.Gridcntr = new DevExpress.XtraGrid.GridControl();
            this.gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AgentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkAgentID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkPID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDetailTableAdapter = new DevExFinalSE.test_se2DataSet2TableAdapters.OrderDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testse2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridcntr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkAgentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.dateTimePicker1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cbStatus);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtOrderID);
            this.panelControl1.Controls.Add(this.lblimportid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(866, 160);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(721, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 50);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(721, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 28);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date";
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderDetailBindingSource, "Status", true));
            this.cbStatus.DataSource = this.orderDetailBindingSource;
            this.cbStatus.DisplayMember = "Status";
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(168, 86);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 29);
            this.cbStatus.TabIndex = 11;
            this.cbStatus.ValueMember = "Status";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "OrderDetail";
            this.orderDetailBindingSource.DataSource = this.test_se2DataSet2;
            // 
            // test_se2DataSet2
            // 
            this.test_se2DataSet2.DataSetName = "test_se2DataSet2";
            this.test_se2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Status";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(169, 34);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(118, 28);
            this.txtOrderID.TabIndex = 7;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // lblimportid
            // 
            this.lblimportid.AutoSize = true;
            this.lblimportid.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimportid.Location = new System.Drawing.Point(56, 38);
            this.lblimportid.Name = "lblimportid";
            this.lblimportid.Size = new System.Drawing.Size(75, 21);
            this.lblimportid.TabIndex = 6;
            this.lblimportid.Text = "Order ID";
            // 
            // testse2DataSetBindingSource
            // 
            this.testse2DataSetBindingSource.DataSource = this.test_se2DataSet;
            this.testse2DataSetBindingSource.Position = 0;
            // 
            // test_se2DataSet
            // 
            this.test_se2DataSet.DataSetName = "test_se2DataSet";
            this.test_se2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Gridcntr
            // 
            this.Gridcntr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridcntr.Location = new System.Drawing.Point(0, 160);
            this.Gridcntr.MainView = this.gridview;
            this.Gridcntr.Name = "Gridcntr";
            this.Gridcntr.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkAgentID,
            this.lkPID,
            this.lkStatus});
            this.Gridcntr.Size = new System.Drawing.Size(866, 403);
            this.Gridcntr.TabIndex = 1;
            this.Gridcntr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridview});
            // 
            // gridview
            // 
            this.gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderID,
            this.AgentID,
            this.OrderDate,
            this.ProductID,
            this.Quantity,
            this.Status,
            this.Price});
            this.gridview.GridControl = this.Gridcntr;
            this.gridview.Name = "gridview";
            // 
            // OrderID
            // 
            this.OrderID.Caption = "Order ID";
            this.OrderID.FieldName = "OrderID";
            this.OrderID.MinWidth = 25;
            this.OrderID.Name = "OrderID";
            this.OrderID.Visible = true;
            this.OrderID.VisibleIndex = 0;
            this.OrderID.Width = 94;
            // 
            // AgentID
            // 
            this.AgentID.Caption = "Agent ID";
            this.AgentID.ColumnEdit = this.lkAgentID;
            this.AgentID.FieldName = "AgentID";
            this.AgentID.MinWidth = 25;
            this.AgentID.Name = "AgentID";
            this.AgentID.Visible = true;
            this.AgentID.VisibleIndex = 1;
            this.AgentID.Width = 94;
            // 
            // lkAgentID
            // 
            this.lkAgentID.AutoHeight = false;
            this.lkAgentID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkAgentID.Name = "lkAgentID";
            // 
            // OrderDate
            // 
            this.OrderDate.Caption = "Order Date";
            this.OrderDate.FieldName = "OrderDate";
            this.OrderDate.MinWidth = 25;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Visible = true;
            this.OrderDate.VisibleIndex = 2;
            this.OrderDate.Width = 94;
            // 
            // ProductID
            // 
            this.ProductID.Caption = "Product ID";
            this.ProductID.ColumnEdit = this.lkPID;
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 25;
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 3;
            this.ProductID.Width = 94;
            // 
            // lkPID
            // 
            this.lkPID.AutoHeight = false;
            this.lkPID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPID.Name = "lkPID";
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 25;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 4;
            this.Quantity.Width = 94;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.ColumnEdit = this.lkStatus;
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 6;
            this.Status.Width = 94;
            // 
            // lkStatus
            // 
            this.lkStatus.AutoHeight = false;
            this.lkStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStatus.Name = "lkStatus";
            // 
            // Price
            // 
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 5;
            this.Price.Width = 94;
            // 
            // orderDetailTableAdapter
            // 
            this.orderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // DeliveryNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 563);
            this.Controls.Add(this.Gridcntr);
            this.Controls.Add(this.panelControl1);
            this.Name = "DeliveryNoteForm";
            this.Text = "DeliveryNoteForm";
            this.Load += new System.EventHandler(this.DeliveryNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testse2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_se2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridcntr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkAgentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl Gridcntr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblimportid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn AgentID;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkAgentID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkPID;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private System.Windows.Forms.BindingSource testse2DataSetBindingSource;
        private test_se2DataSet test_se2DataSet;
        private test_se2DataSet2 test_se2DataSet2;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private test_se2DataSet2TableAdapters.OrderDetailTableAdapter orderDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkStatus;
    }
}