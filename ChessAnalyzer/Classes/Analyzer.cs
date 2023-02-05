using ChessGamesParser.Classes.XPOData;
using DevExpress.Xpo;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGamesParser.Classes {


    internal class Analyzer {
        public const string MyName = "freazeek";
        public void ExportRatingToCSV() {
            var uow = new UnitOfWork();
            var allGames = new XPCollection<GamePersist>(uow).ToList();
            var csv = new StringBuilder();
            foreach (var game in allGames) {
                var date = game.Date;
                int rating;
                if(game.WhiteName== MyName) {
                    rating = game.WhiteRating;
                } else {
                    rating = game.BlackRating;
                }
                var newLine = string.Format("{0},{1}", date, rating);
                csv.AppendLine(newLine);

            }
            File.WriteAllText("mycsv.csv", csv.ToString());
        }

        public void TestPGN() {
            var uow = new UnitOfWork();
            var allGames = new XPCollection<GamePersist>(uow).ToList();
            var csv = new StringBuilder();
            foreach(var game in allGames) {

                var reader = new ilf.pgn.PgnReader();
                var gameDb = reader.ReadFromString(game.PGN);

                ilf.pgn.Data.Game gamePGN = gameDb.Games[0];

            }
        }
    }
}
