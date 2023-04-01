using DevExpress.XtraEditors;
using DevExpress.XtraTab;

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
            this.importFromApi = new DevExpress.XtraEditors.SimpleButton();
            this.exportRating = new DevExpress.XtraEditors.SimpleButton();
            this.buildPGN = new DevExpress.XtraEditors.SimpleButton();
            this.treeMoves = new DevExpress.XtraTreeList.TreeList();
            this.NameCl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Count = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.FingerPrint = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MoveNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.AnswerCl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.exportTree = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ratingChart = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.chartCandle = new DevExpress.XtraCharts.ChartControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bulidPgnFull = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCandle)).BeginInit();
            this.SuspendLayout();
            // 
            // importFromApi
            // 
            this.importFromApi.Location = new System.Drawing.Point(83, 13);
            this.importFromApi.Name = "importFromApi";
            this.importFromApi.Size = new System.Drawing.Size(199, 34);
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
            this.AnswerCl});
            this.treeMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMoves.Location = new System.Drawing.Point(0, 0);
            this.treeMoves.Name = "treeMoves";
            this.treeMoves.Size = new System.Drawing.Size(2322, 1325);
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
            // AnswerCl
            // 
            this.AnswerCl.Caption = "Answer";
            this.AnswerCl.FieldName = "Answer";
            this.AnswerCl.Name = "AnswerCl";
            this.AnswerCl.UnboundDataType = typeof(string);
            this.AnswerCl.Visible = true;
            this.AnswerCl.VisibleIndex = 4;
            // 
            // exportTree
            // 
            this.exportTree.Location = new System.Drawing.Point(849, 12);
            this.exportTree.Name = "exportTree";
            this.exportTree.Size = new System.Drawing.Size(112, 34);
            this.exportTree.TabIndex = 5;
            this.exportTree.Text = "exportTree";
            this.exportTree.Click += new System.EventHandler(this.exportTree_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 53);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(2324, 1360);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.treeMoves);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(2322, 1325);
            this.xtraTabPage1.Text = "Data";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ratingChart);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(2322, 1325);
            this.xtraTabPage2.Text = "Chart";
            // 
            // ratingChart
            // 
            this.ratingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratingChart.Location = new System.Drawing.Point(0, 0);
            this.ratingChart.Name = "ratingChart";
            this.ratingChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ratingChart.Size = new System.Drawing.Size(2322, 1325);
            this.ratingChart.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.chartCandle);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(2322, 1325);
            this.xtraTabPage3.Text = "Candle";
            // 
            // chartCandle
            // 
            this.chartCandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCandle.Location = new System.Drawing.Point(0, 0);
            this.chartCandle.Name = "chartCandle";
            this.chartCandle.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartCandle.Size = new System.Drawing.Size(2322, 1325);
            this.chartCandle.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(980, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 34);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "ShowRating";
            this.simpleButton1.Click += new System.EventHandler(this.buildRatingButton1_Click);
            // 
            // bulidPgnFull
            // 
            this.bulidPgnFull.Location = new System.Drawing.Point(560, 13);
            this.bulidPgnFull.Name = "bulidPgnFull";
            this.bulidPgnFull.Size = new System.Drawing.Size(112, 34);
            this.bulidPgnFull.TabIndex = 8;
            this.bulidPgnFull.Text = "bulidPgnFull";
            this.bulidPgnFull.Click += new System.EventHandler(this.bulidPgnFull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2339, 1425);
            this.Controls.Add(this.bulidPgnFull);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.exportTree);
            this.Controls.Add(this.buildPGN);
            this.Controls.Add(this.exportRating);
            this.Controls.Add(this.importFromApi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCandle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton importFromApi;
        private DevExpress.XtraEditors.SimpleButton exportRating;
        private DevExpress.XtraEditors.SimpleButton buildPGN;
        private DevExpress.XtraTreeList.TreeList treeMoves;
        private DevExpress.XtraEditors.SimpleButton exportTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn NameCl;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Count;
        private DevExpress.XtraTreeList.Columns.TreeListColumn FingerPrint;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MoveNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn AnswerCl;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraCharts.ChartControl ratingChart;
        private DevExpress.XtraEditors.SimpleButton bulidPgnFull;
        private XtraTabPage xtraTabPage3;
        private DevExpress.XtraCharts.ChartControl chartCandle;
    }
}

