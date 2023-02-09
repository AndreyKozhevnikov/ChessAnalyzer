using ChessAnalyzer.Classes;
using ChessGamesParser.Classes.XPOData;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraBars.Alerter;
using ilf.pgn.Data;
using ilf.pgn.Data.MoveText;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGamesParser.Classes {


    internal class Analyzer {
        public const string MyName = "freazeek";
        public void ExportRatingToCSV() {
            var uow = new UnitOfWork();
            var allGames = new XPCollection<GamePersist>(uow).ToList().OrderBy(x => x.Date);
            var csv = new StringBuilder();
            foreach(var game in allGames) {
                var date = game.Date;
                int rating;
                if(game.WhiteName == MyName) {
                    rating = game.WhiteRating;
                } else {
                    rating = game.BlackRating;
                }
                var newLine = string.Format("{0},{1}", date, rating);
                csv.AppendLine(newLine);

            }
            System.IO.File.WriteAllText("mycsv.csv", csv.ToString());
        }

        public List<string> GetMovesToExclude() {
            var path = @"..\..\MovesToExclude\list.txt";
            string text = System.IO.File.ReadAllText(path);
            var list = text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            return list.ToList();
        }

        public List<MyMove> TestPGN() {
            var uow = new UnitOfWork();
            var allGames = new XPCollection<GamePersist>(uow, CriteriaOperator.FromLambda<GamePersist>(x => x.WhiteName == MyName)).ToList();
            var csv = new StringBuilder();
            int cnt = 0;
            List<MyMove> moves = new List<MyMove>();
            //var move1W = new MyMove("c4");
            //move1W.MoveNumber = 1;
            //moves.Add(move1W);
            var movesToExclude = GetMovesToExclude();
            foreach(var game in allGames) {

                var reader = new ilf.pgn.PgnReader();
                var gameDb = reader.ReadFromString(game.PGN);

                Game gamePGN = gameDb.Games[0];
                var firstMove = (HalfMoveEntry)gamePGN.MoveText[0];
                if(!IsEnglishOpening(firstMove)) {
                    continue;

                }
                //  move1W.Count++;
                MyMove parentMove = new MyMove("null");
                parentMove.Key = Guid.Empty;
                for(int i = 1; i <= 4; i++) {
                    var moveWst = GetMove(gamePGN.MoveText, i, true)?.ToString();
                    if(moveWst == null) {
                        break;
                    }
                    var existW = moves.Find(x => x.Name == moveWst && x.ParentKey == parentMove.Key);
                    if(existW != null) {
                        existW.Count++;

                    } else {
                        existW = new MyMove(moveWst);
                        existW.ParentMove = parentMove;
                        if(movesToExclude.Contains(existW.FingerPrint)) {
                            break;
                        }
                        existW.MoveNumber = i;
                        existW.Count++;
                        moves.Add(existW);
                    }
                    parentMove = existW;
                    var moveBst = GetMove(gamePGN.MoveText, i, false)?.ToString();
                    if(moveBst == null) {
                        break;
                    }
                    var existB = moves.Find(x => x.Name == moveBst && x.ParentKey == parentMove.Key);
                    if(existB != null) {
                        existB.Count++;
                    } else {
                        existB = new MyMove(moveBst);
                        existB.ParentMove = existW;
                        existB.MoveNumber = i;
                        existB.Count++;
                        moves.Add(existB);
                    }
                    parentMove = existB;
                }

                //var move1Bst = GetMove(gamePGN.MoveText, 1,false).ToString();
                //var existMove1B = moves.Find(x => x.Name == move1Bst);
                //if(existMove1B!=null) {
                //    existMove1B.Count++;
                //} else {
                //    existMove1B = new MyMove(move1Bst);
                //    existMove1B.ParentKey = move1W.Key;
                //    existMove1B.MoveNumber = 1;
                //    existMove1B.Count++;
                //    moves.Add(existMove1B);
                //}

                //var move2Wst= GetMove(gamePGN.MoveText, 2, true).ToString();
                //var exist2W = moves.Find(x => x.Name == move2Wst && x.ParentKey == existMove1B.Key);
                //if(exist2W != null) {
                //    exist2W.Count++;
                //} else {
                //    exist2W = new MyMove(move2Wst);
                //    exist2W.ParentKey = existMove1B.Key;
                //    exist2W.MoveNumber = 2;
                //    exist2W.Count++;
                //    moves.Add(exist2W);
                //}


                //var move2Bst = GetMove(gamePGN.MoveText, 2, false).ToString();
                //var exist2B = moves.Find(x => x.Name == move2Bst && x.ParentKey == exist2W.Key);
                //if(exist2B != null) {
                //    exist2B.Count++;
                //} else {
                //    exist2B = new MyMove(move2Bst);
                //    exist2B.ParentKey = exist2W.Key;
                //    exist2B.MoveNumber = 2;
                //    exist2B.Count++;
                //    moves.Add(exist2B);
                //}



            }
            //  MessageBox.Show(cnt.ToString());
            return moves;
        }

        bool IsEnglishOpening(HalfMoveEntry move) {
            if(move.MoveNumber == 1 && move.Move.Piece == PieceType.Pawn && move.Move.TargetSquare.File == ilf.pgn.Data.File.C && move.Move.TargetSquare.Rank == 4) {
                return true;
            }
            return false;
        }
        HalfMoveEntry GetMove(MoveTextEntryList moves, int number, bool firstMove) {
            return (HalfMoveEntry)moves.Where(x => x.Type == MoveTextEntryType.SingleMove && ((HalfMoveEntry)x).MoveNumber == number && ((HalfMoveEntry)x).IsContinued == !firstMove).FirstOrDefault();
        }

    }
}
