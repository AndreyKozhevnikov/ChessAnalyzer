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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importFromApi);
            this.Controls.Add(this.importDataFromFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton importDataFromFileBtn;
        private DevExpress.XtraEditors.SimpleButton importFromApi;
    }
}

