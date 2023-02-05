using ChessGamesParser.ChessArchive;
using ChessGamesParser.Classes;
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

        }
    }
}
