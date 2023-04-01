using ChessAnalyzer.Classes;
using ChessGamesParser.ChessArchive;
using ChessGamesParser.Classes;
using ChessGamesParser.Classes.XPOData;
using DevExpress.Charts.Native;
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
using System.IO;
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
            treeMoves.NodeCellStyle += TreeMoves_NodeCellStyle;
            //var a = new CorrectAnswer(uow);
            //uow.CommitChanges();
        }

        private void TreeMoves_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e) {
            if(e.Column.Name != "AnswerCl")
                return;
            var nd = e.Node;
            var cnt=(int)nd.GetValue("Count");
            if(cnt > 9 && !nd.HasChildren) {
                e.Appearance.BackColor = Color.Red;
            }
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
            var folder = @"..\..\Export\";
            var fileName = string.Format("export-{0}.xlsx", DateTime.Today.ToString("dd-MM-yy"));
            var path = Path.Combine(folder, fileName);
            treeMoves.ExportToXlsx(path);
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

        private void buildRatingButton1_Click(object sender, EventArgs e) {
            var analyzer = new Analyzer();
            var rating = analyzer.GetRating();
            ratingChart.DataSource = rating.RatingData;
            var minValue = rating.RatingData. Min(x => x.Rating);
            
            
            Series series = new Series("Rating", ViewType.Line);
            series.View.Color = Color.Green;
            ratingChart.Series.Add(series);
            series.ArgumentDataMember = "Date";
            series.ValueDataMembers.AddRange(new string[] { "Rating" });
            series.ArgumentScaleType = ScaleType.Qualitative;

            Series maxRatingSeries = new Series("MaxRating", ViewType.Line);
            maxRatingSeries.View.Color = Color.Blue;
            ratingChart.Series.Add(maxRatingSeries);
            maxRatingSeries.ArgumentDataMember = "Date";
            maxRatingSeries.ValueDataMembers.AddRange(new string[] { "MaxRating" });
            maxRatingSeries.ArgumentScaleType = ScaleType.Qualitative;

            var secAccs = new SecondaryAxisY("Second");
            ((XYDiagram)ratingChart.Diagram).SecondaryAxesY.Add(secAccs);

            Series maxWinSeries = new Series("MaxWinSeries", ViewType.Line);
            maxWinSeries.View.Color = Color.Red;
            ratingChart.Series.Add(maxWinSeries);
            maxWinSeries.ArgumentDataMember = "Date";
            maxWinSeries.ValueDataMembers.AddRange(new string[] { "MaxWinSeries" });
            maxWinSeries.ArgumentScaleType = ScaleType.Qualitative;
            ((XYDiagramSeriesViewBase)maxWinSeries.View).AxisY = secAccs;


            Series currWinSeries = new Series("CurrWinSeries", ViewType.Line);
            currWinSeries.View.Color = Color.Purple;
            ratingChart.Series.Add(currWinSeries);
            currWinSeries.ArgumentDataMember = "Date";
            currWinSeries.ValueDataMembers.AddRange(new string[] { "CurrentWinSeries" });
            currWinSeries.ArgumentScaleType = ScaleType.Qualitative;
            ((XYDiagramSeriesViewBase)currWinSeries.View).AxisY = secAccs;

            Series maxDrawSeries = new Series("maxDrawSeries", ViewType.Line);
            maxDrawSeries.View.Color = Color.Purple;
            ratingChart.Series.Add(maxDrawSeries);
            maxDrawSeries.ArgumentDataMember = "Date";
            maxDrawSeries.ValueDataMembers.AddRange(new string[] { "MaxDrawDown" });
            maxDrawSeries.ArgumentScaleType = ScaleType.Qualitative;
            ((XYDiagramSeriesViewBase)maxDrawSeries.View).AxisY = secAccs;

            Series currDrawSeries = new Series("currDrawSeries", ViewType.Line);
            currDrawSeries.View.Color = Color.Red;
            ratingChart.Series.Add(currDrawSeries);
            currDrawSeries.ArgumentDataMember = "Date";
            currDrawSeries.ValueDataMembers.AddRange(new string[] { "CurrentDrawDown" });
            currDrawSeries.ArgumentScaleType = ScaleType.Qualitative;
            ((XYDiagramSeriesViewBase)currDrawSeries.View).AxisY = secAccs;


            ((XYDiagram)ratingChart.Diagram).AxisY.VisualRange.MinValue = minValue;
            ((XYDiagram)ratingChart.Diagram).EnableAxisXZooming= true;
            ((XYDiagram)ratingChart.Diagram).EnableAxisYZooming= true;
            ((XYDiagram)ratingChart.Diagram).EnableAxisXScrolling = true;
            ((XYDiagram)ratingChart.Diagram).EnableAxisYScrolling = true;

            //candle
            chartCandle.DataSource= rating.Candles;
            Series candleSeries = new Series("Candles", ViewType.CandleStick);
            
            candleSeries.SetFinancialDataMembers("Date", "Low", "High", "Open", "Close");
            candleSeries.ArgumentScaleType = ScaleType.DateTime;
            chartCandle.Series.Add(candleSeries);
            CandleStickSeriesView view = (CandleStickSeriesView)candleSeries.View;

            view.LineThickness = 2;
            view.LevelLineLength = 0.25;

            view.ReductionOptions.ColorMode = ReductionColorMode.OpenToCloseValue;
            view.ReductionOptions.FillMode = CandleStickFillMode.AlwaysFilled;
            view.ReductionOptions.Level = StockLevel.Close;
            view.ReductionOptions.Visible = true;

            // Set point colors.
            view.Color = Color.Green;
            view.ReductionOptions.Color = Color.Red;

            ((XYDiagram)chartCandle.Diagram).AxisY.VisualRange.MinValue = minValue;

            Series volumeSeries = new Series("Volume", ViewType.Bar);
            volumeSeries.ArgumentDataMember = "Date";
            volumeSeries.ValueDataMembers.AddRange(new string[] { "Volume" });
            volumeSeries.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            chartCandle.Series.Add(volumeSeries);
            var secAccsCandle = new SecondaryAxisY("Second");
            var diag = ((XYDiagram)chartCandle.Diagram);
           diag.SecondaryAxesY.Add(secAccsCandle);
            var candleView = ((XYDiagramSeriesViewBase)volumeSeries.View);
           candleView.AxisY = secAccsCandle;
            

            var pane = new XYDiagramPane("VolumePane");
            
            diag.Panes.Add(pane);
            candleView.Pane = pane;

        }

        private void bulidPgnFull_Click(object sender, EventArgs e) {
            BuldPGNGrid(true);
        }

        private void candleButton_Click(object sender, EventArgs e) {

        }
    }
}
