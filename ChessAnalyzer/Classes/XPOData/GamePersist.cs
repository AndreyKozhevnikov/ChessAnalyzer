using ChessGamesParser.Classes.JsonClasses;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace ChessGamesParser.Classes.XPOData {
    public class GamePersist : XPObject {
        double accuracyBlack;
        double accuracyWhite;


        string blackId;
        string blackName;
        int blackRating;
        string blackResult;
        string blackUuid;
        DateTime date;
        string fEN;

        string pGN;
        string tCN;
        string timeControl;
        string uid;
        string url;
        string whiteId;
        string whiteName;
        int whiteRating;
        string whiteResult;
        string whiteUuid;

        public GamePersist(Session session) : base(session) {
        }
        public double BlackAccuracy {
            get => accuracyBlack;
            set => SetPropertyValue(nameof(BlackAccuracy), ref accuracyBlack, value);
        }
        public string BlackId {
            get => blackId;
            set => SetPropertyValue(nameof(BlackId), ref blackId, value);
        }
        public string BlackName {
            get => blackName;
            set => SetPropertyValue(nameof(BlackName), ref blackName, value);
        }

        public int BlackRating {
            get => blackRating;
            set => SetPropertyValue(nameof(BlackRating), ref blackRating, value);
        }
        public string BlackResult {
            get => blackResult;
            set => SetPropertyValue(nameof(BlackResult), ref blackResult, value);
        }
        public string BlackUuid {
            get => blackUuid;
            set => SetPropertyValue(nameof(BlackUuid), ref blackUuid, value);
        }
        public DateTime Date {
            get => date;
            set => SetPropertyValue(nameof(Date), ref date, value);
        }

        public string FEN {
            get => fEN;
            set => SetPropertyValue(nameof(FEN), ref fEN, value);
        }
        [Size(SizeAttribute.Unlimited)]
        public string PGN {
            get => pGN;
            set => SetPropertyValue(nameof(PGN), ref pGN, value);
        }

        [Size(SizeAttribute.Unlimited)]
        public string TCN {
            get => tCN;
            set => SetPropertyValue(nameof(TCN), ref tCN, value);
        }
        public string TimeControl {
            get => timeControl;
            set => SetPropertyValue(nameof(TimeControl), ref timeControl, value);
        }


        public string Url {
            get => url;
            set => SetPropertyValue(nameof(Url), ref url, value);
        }

        public string Uuid {
            get => uid;
            set => SetPropertyValue(nameof(Uuid), ref uid, value);
        }

        public double WhiteAccuracy {
            get => accuracyWhite;
            set => SetPropertyValue(nameof(WhiteAccuracy), ref accuracyWhite, value);
        }
        public string WhiteId {
            get => whiteId;
            set => SetPropertyValue(nameof(WhiteId), ref whiteId, value);
        }
        public string WhiteName {
            get => whiteName;
            set => SetPropertyValue(nameof(WhiteName), ref whiteName, value);
        }

        public int WhiteRating {
            get => whiteRating;
            set => SetPropertyValue(nameof(WhiteRating), ref whiteRating, value);
        }
        public string WhiteResult {
            get => whiteResult;
            set => SetPropertyValue(nameof(WhiteResult), ref whiteResult, value);
        }
        public string WhiteUuid {
            get => whiteUuid;
            set => SetPropertyValue(nameof(WhiteUuid), ref whiteUuid, value);
        }
    }
}
