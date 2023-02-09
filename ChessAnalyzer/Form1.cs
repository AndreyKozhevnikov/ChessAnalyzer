using ChessAnalyzer.Classes;
using ChessGamesParser.ChessArchive;
using ChessGamesParser.Classes;
using ChessGamesParser.Classes.XPOData;
using DevExpress.Export;
using DevExpress.Xpo;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessAnalyzer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
        }

        private void importDataFromFileBtn_Click(object sender, EventArgs e) {
            var importer = new GameImporter();
            importer.ImportGamesFromFile();
        }

        private void importFromApi_Click(object sender, EventArgs e) {
            var importer = new GameImporter();
            importer.ImportGamesFromApi();
        }

        private void exportRating_Click(object sender, EventArgs e) {
            var analyzer = new Analyzer();
            analyzer.ExportRatingToCSV();
        }

        private void buildPGN_Click(object sender, EventArgs e) {
            var analyzer = new Analyzer();
         var lst=   analyzer.TestPGN();
            treeMoves.DataSource= lst;
            treeMoves.KeyFieldName = nameof(MyMove.Key);
            treeMoves.ParentFieldName= nameof(MyMove.ParentKey);
           // treeMoves.ExpandAll();
        }

        private void exportTree_Click(object sender, EventArgs e) {
            
            ExportSettings.DefaultExportType = ExportType.WYSIWYG;
            treeMoves.ExportToXlsx("myTree.xlsx");
        }
    }
}
