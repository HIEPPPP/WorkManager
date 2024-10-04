namespace WorkManager.GUI
{
    partial class frmRequestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestList));
            this.gcRequest = new DevExpress.XtraGrid.GridControl();
            this.gvRequest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssignedTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuccess = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefesh = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcRequest
            // 
            this.gcRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRequest.Location = new System.Drawing.Point(12, 12);
            this.gcRequest.MainView = this.gvRequest;
            this.gcRequest.Name = "gcRequest";
            this.gcRequest.Size = new System.Drawing.Size(902, 486);
            this.gcRequest.TabIndex = 0;
            this.gcRequest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequest});
            this.gcRequest.Load += new System.EventHandler(this.gcRequest_Load);
            // 
            // gvRequest
            // 
            this.gvRequest.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvRequest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequest.Appearance.Row.Options.UseTextOptions = true;
            this.gvRequest.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRequest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colRequestType,
            this.colDescription,
            this.colDepartment,
            this.colFactory,
            this.colLocation,
            this.colStatus,
            this.colAssignedTo,
            this.colCreateDate,
            this.colRequestBy});
            this.gvRequest.GridControl = this.gcRequest;
            this.gvRequest.Name = "gvRequest";
            this.gvRequest.OptionsView.ShowGroupPanel = false;
            this.gvRequest.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAssignedTo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvRequest.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvRequest_CustomDrawCell);
            this.gvRequest.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvRequest_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colRequestType
            // 
            this.colRequestType.Caption = "Loại yêu cầu";
            this.colRequestType.FieldName = "RequestType";
            this.colRequestType.Name = "colRequestType";
            this.colRequestType.Visible = true;
            this.colRequestType.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colDepartment
            // 
            this.colDepartment.Caption = "Bộ phận";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 3;
            // 
            // colFactory
            // 
            this.colFactory.Caption = "Nhà máy";
            this.colFactory.FieldName = "Factory";
            this.colFactory.Name = "colFactory";
            this.colFactory.Visible = true;
            this.colFactory.VisibleIndex = 4;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Vị trí";
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 5;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // colAssignedTo
            // 
            this.colAssignedTo.Caption = "Người thực hiện";
            this.colAssignedTo.FieldName = "AssignedTo";
            this.colAssignedTo.Name = "colAssignedTo";
            this.colAssignedTo.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colAssignedTo.Visible = true;
            this.colAssignedTo.VisibleIndex = 7;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Ngày tạo";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 8;
            // 
            // colRequestBy
            // 
            this.colRequestBy.Caption = "Người yêu cầu";
            this.colRequestBy.FieldName = "RequestBy";
            this.colRequestBy.Name = "colRequestBy";
            this.colRequestBy.Visible = true;
            this.colRequestBy.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSuccess);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnRefesh);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuccess.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccess.Appearance.Options.UseFont = true;
            this.btnSuccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuccess.ImageOptions.Image")));
            this.btnSuccess.Location = new System.Drawing.Point(656, 12);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(118, 42);
            this.btnSuccess.TabIndex = 9;
            this.btnSuccess.Text = "Hoàn thành";
            this.btnSuccess.Visible = false;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(780, 13);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(116, 42);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Appearance.Options.UseFont = true;
            this.btnRefesh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.ImageOptions.Image")));
            this.btnRefesh.Location = new System.Drawing.Point(270, 12);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(105, 42);
            this.btnRefesh.TabIndex = 7;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(94, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(182, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(6, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmRequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcRequest);
            this.Name = "frmRequestList";
            this.Text = "frmRequestList";
            ((System.ComponentModel.ISupportInitialize)(this.gcRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcRequest;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colFactory;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignedTo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraEditors.SimpleButton btnRefesh;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnSuccess;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestBy;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
    }
}