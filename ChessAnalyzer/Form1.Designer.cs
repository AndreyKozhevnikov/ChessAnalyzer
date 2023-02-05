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
            this.exportTree = new DevExpress.XtraEditors.SimpleButton();
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
            this.treeMoves.Location = new System.Drawing.Point(38, 78);
            this.treeMoves.Name = "treeMoves";
            this.treeMoves.Size = new System.Drawing.Size(1345, 960);
            this.treeMoves.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 1050);
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
    }
}

