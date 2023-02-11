namespace ChessAnalyzer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.importDataFromFileBtn = new DevExpress.XtraEditors.SimpleButton();
            this.importFromApi = new DevExpress.XtraEditors.SimpleButton();
            this.exportRating = new DevExpress.XtraEditors.SimpleButton();
            this.buildPGN = new DevExpress.XtraEditors.SimpleButton();
            this.treeMoves = new DevExpress.XtraTreeList.TreeList();
            this.NameCl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Count = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.FingerPrint = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MoveNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.exportTree = new DevExpress.XtraEditors.SimpleButton();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeMoves)).BeginInit();
            this.SuspendLayout();
            // 
            // importDataFromFileBtn
            // 
            this.importDataFromFileBtn.Location = new System.Drawing.Point(25, 13);
            this.importDataFromFileBtn.Name = "importDataFromFileBtn";
            this.importDataFromFileBtn.Size = new System.Drawing.Size(112, 34);
            this.importDataFromFileBtn.TabIndex = 0;
            this.importDataFromFileBtn.Text = "ImportDataFromFile";
            this.importDataFromFileBtn.Click += new System.EventHandler(this.importDataFromFileBtn_Click);
            // 
            // importFromApi
            // 
            this.importFromApi.Location = new System.Drawing.Point(170, 13);
            this.importFromApi.Name = "importFromApi";
            this.importFromApi.Size = new System.Drawing.Size(112, 34);
            this.importFromApi.TabIndex = 1;
            this.importFromApi.Text = "ImportFromApi";
            this.importFromApi.Click += new System.EventHandler(this.importFromApi_Click);
            // 
            // exportRating
            // 
            this.exportRating.Location = new System.Drawing.Point(306, 13);
            this.exportRating.Name = "exportRating";
            this.exportRating.Size = new System.Drawing.Size(112, 34);
            this.exportRating.TabIndex = 2;
            this.exportRating.Text = "ExportRating";
            this.exportRating.Click += new System.EventHandler(this.exportRating_Click);
            // 
            // buildPGN
            // 
            this.buildPGN.Location = new System.Drawing.Point(441, 13);
            this.buildPGN.Name = "buildPGN";
            this.buildPGN.Size = new System.Drawing.Size(112, 34);
            this.buildPGN.TabIndex = 3;
            this.buildPGN.Text = "buildPGN";
            this.buildPGN.Click += new System.EventHandler(this.buildPGN_Click);
            // 
            // treeMoves
            // 
            this.treeMoves.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.NameCl,
            this.Count,
            this.FingerPrint,
            this.MoveNumber,
            this.treeListColumn1});
            this.treeMoves.Location = new System.Drawing.Point(38, 78);
            this.treeMoves.Name = "treeMoves";
            this.treeMoves.Size = new System.Drawing.Size(2279, 1323);
            this.treeMoves.TabIndex = 4;
            this.treeMoves.CustomUnboundColumnData += new DevExpress.XtraTreeList.CustomColumnDataEventHandler(this.treeMoves_CustomUnboundColumnData);
            // 
            // NameCl
            // 
            this.NameCl.Caption = "Name";
            this.NameCl.FieldName = "Name";
            this.NameCl.Name = "NameCl";
            this.NameCl.Visible = true;
            this.NameCl.VisibleIndex = 0;
            // 
            // Count
            // 
            this.Count.Caption = "Count";
            this.Count.FieldName = "Count";
            this.Count.Name = "Count";
            this.Count.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.Count.Visible = true;
            this.Count.VisibleIndex = 1;
            // 
            // FingerPrint
            // 
            this.FingerPrint.Caption = "FingerPrint";
            this.FingerPrint.FieldName = "FingerPrint";
            this.FingerPrint.Name = "FingerPrint";
            this.FingerPrint.Visible = true;
            this.FingerPrint.VisibleIndex = 3;
            // 
            // MoveNumber
            // 
            this.MoveNumber.Caption = "MoveNumber";
            this.MoveNumber.FieldName = "MoveNumber";
            this.MoveNumber.Name = "MoveNumber";
            this.MoveNumber.Visible = true;
            this.MoveNumber.VisibleIndex = 2;
            // 
            // exportTree
            // 
            this.exportTree.Location = new System.Drawing.Point(578, 13);
            this.exportTree.Name = "exportTree";
            this.exportTree.Size = new System.Drawing.Size(112, 34);
            this.exportTree.TabIndex = 5;
            this.exportTree.Text = "exportTree";
            this.exportTree.Click += new System.EventHandler(this.exportTree_Click);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Answer";
            this.treeListColumn1.FieldName = "Answer";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.UnboundDataType = typeof(string);
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2320, 1413);
            this.Controls.Add(this.exportTree);
            this.Controls.Add(this.treeMoves);
            this.Controls.Add(this.buildPGN);
            this.Controls.Add(this.exportRating);
            this.Controls.Add(this.importFromApi);
            this.Controls.Add(this.importDataFromFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeMoves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton importDataFromFileBtn;
        private DevExpress.XtraEditors.SimpleButton importFromApi;
        private DevExpress.XtraEditors.SimpleButton exportRating;
        private DevExpress.XtraEditors.SimpleButton buildPGN;
        private DevExpress.XtraTreeList.TreeList treeMoves;
        private DevExpress.XtraEditors.SimpleButton exportTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn NameCl;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Count;
        private DevExpress.XtraTreeList.Columns.TreeListColumn FingerPrint;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MoveNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}

