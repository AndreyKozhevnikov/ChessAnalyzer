using ChessAnalyzer.Classes;
using ChessGamesParser.ChessArchive;
using ChessGamesParser.Classes;
using ChessGamesParser.Classes.XPOData;
using DevExpress.Data.Filtering;
using DevExpress.Export;
using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
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
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            uow = new UnitOfWork();
            //var a = new CorrectAnswer(uow);
            //uow.CommitChanges();
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

        void BuldPGNGrid(bool showAllMoves) {
            var analyzer = new Analyzer();
            correctMovesDict.Clear();
            var lst = analyzer.TestPGN(showAllMoves);
            treeMoves.DataSource = lst;
            treeMoves.KeyFieldName = nameof(MyMove.Key);
            treeMoves.ParentFieldName = nameof(MyMove.ParentKey);
            treeMoves.ExpandAll();
        }

        private void buildPGN_Click(object sender, EventArgs e) {
            BuldPGNGrid(false);
        }

        private void exportTree_Click(object sender, EventArgs e) {

            ExportSettings.DefaultExportType = ExportType.WYSIWYG;
            treeMoves.ExportToXlsx("myTree.xlsx");
        }
        UnitOfWork uow;
        Dictionary<string, string> correctMovesDict = new Dictionary<string, string>();
        private void treeMoves_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e) {
            var move = (MyMove)e.Row;
            if(move.IsWhite) {
                return;
            }
            if(e.IsGetData) {
                string answer;
                correctMovesDict.TryGetValue(move.FingerPrint, out answer);
                if(answer == null) {
                    var answerPers = uow.FindObject<CorrectAnswer>(CriteriaOperator.FromLambda<CorrectAnswer>(x => x.FingerPrint == move.FingerPrint));
                    if(answerPers != null) {
                        answer = answerPers.Answer;
                        correctMovesDict[answerPers.FingerPrint] = answerPers.Answer;
                    }
                }
                if(string.IsNullOrEmpty(answer)) {
                    answer = "!!!!!!!!!!!!!!!!!!!!!";
                }
                e.Value = answer;

            }
            if(e.IsSetData) {
                var correctAnswer = uow.FindObject<CorrectAnswer>(CriteriaOperator.FromLambda<CorrectAnswer>(x => x.FingerPrint == move.FingerPrint));
                if(correctAnswer == null) {
                    correctAnswer = new CorrectAnswer(uow);
                    correctAnswer.FingerPrint = move.FingerPrint;
                }
                correctAnswer.Answer = (string)e.Value;
                correctMovesDict[correctAnswer.FingerPrint] = correctAnswer.Answer;
                uow.CommitChanges();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            var analyzer = new Analyzer();
            var lst = analyzer.GetRating();
            ratingChart.DataSource = lst;
            var minValue = lst.Min(x => x.Rating);
            Series series = new Series("Series1", ViewType.Line);
            series.View.Color = Color.Green;
            ratingChart.Series.Add(series);
            series.ArgumentDataMember = "Date";
            series.ValueDataMembers.AddRange(new string[] { "Rating" });
            series.ArgumentScaleType = ScaleType.Qualitative;
            ((XYDiagram)ratingChart.Diagram).AxisY.VisualRange.MinValue = minValue;
            ((XYDiagram)ratingChart.Diagram).EnableAxisXZooming= true;
            ((XYDiagram)ratingChart.Diagram).EnableAxisYZooming= true;
            ((XYDiagram)ratingChart.Diagram).EnableAxisXScrolling = true;
            ((XYDiagram)ratingChart.Diagram).EnableAxisYScrolling = true;

        }

        private void bulidPgnFull_Click(object sender, EventArgs e) {
            BuldPGNGrid(true);
        }
    }
}
