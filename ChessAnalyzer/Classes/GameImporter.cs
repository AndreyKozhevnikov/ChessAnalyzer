using ChessGamesParser.Classes.JsonClasses;
using ChessGamesParser.Classes.XPOData;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://api.chess.com/pub/player/freazeek/games/2022/12
namespace ChessGamesParser.Classes {
    public class GameImporter {
        internal void SaveGames(RootGames? rootGames) {
            if(rootGames == null) {
                return;
            }
            var uow = new UnitOfWork();
            var existingKeys = new XPCollection<GamePersist>(uow).ToList().Select(x => x.Uuid);
            var k = 0;
            foreach(var game in rootGames.games) {
                if(existingKeys.Contains(game.uuid)) {
                    continue;
                }
                var gamePersist = new GamePersist(uow);

                gamePersist.Uuid = game.uuid;
                gamePersist.Url = game.url;
                gamePersist.FEN = game.fen;
                gamePersist.TCN = game.tcn;
                gamePersist.PGN = game.pgn;
                gamePersist.Date = UnixTimeStampToDateTime(game.end_time); //??
                gamePersist.TimeControl = game.time_control;


                gamePersist.WhiteId = game.white.id;
                gamePersist.WhiteName = game.white.username;
                gamePersist.WhiteRating = game.white.rating;
                gamePersist.WhiteUuid = game.white.uuid;
                gamePersist.WhiteResult = game.white.result;


                gamePersist.BlackId = game.black.id;
                gamePersist.BlackName = game.black.username;
                gamePersist.BlackRating = game.black.rating;
                gamePersist.WhiteUuid = game.black.uuid;
                gamePersist.WhiteResult = game.black.result;
                if(game.accuracies != null) {
                    gamePersist.WhiteAccuracy = game.accuracies.white;
                    gamePersist.BlackAccuracy = game.accuracies.black;
                }
                k++;
                if(k > 100) {
                    uow.CommitChanges();
                    k = 0;
                }
            }
            uow.CommitChanges();
        }

        internal void ImportGames() {
            var folder = @"..\..\..\Data\";
            var files = Directory.GetFiles(folder);
            foreach(var file in files) {
                var parser = new JsonParser();
                var games = parser.Parse(file);
                SaveGames(games);
            }


        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp) {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }



    }
}
