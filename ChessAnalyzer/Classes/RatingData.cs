using DevExpress.XtraCharts.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAnalyzer.Classes {
    [DebuggerDisplay("{Date} - {Rating} - {MaxWinSeries}")]
    public class RatingData {

        int rating;
        DateTime date;

        public DateTime Date {
            get => date;
            set => date = value;
        }
        
        public int Rating {
            get => rating;
            set => rating = value;
        }
        public int MaxRating { get; set; }
        public int MinRating { get; set; }
        public int MaxWinSeries { get; set; }
        public int CurrentWinSeries { get; set; }
        public int MaxLooseSeries { get; set; }

        public int MaxDrawDown { get; set; }
        public int CurrentDrawDown { get; set; }

    }
    [DebuggerDisplay("{Date} - {Open} - {High} - {Low} - {Close}")]
    public class MyCandle {
        public DateTime Date { get; set; }
        public int Open { get; set; }
        public int Close { get; set; }
        public int High { get; set; }
        public int Low { get; set; }
        public int Volume { get; set; }
    }

    public class Rating {
        public Rating() {
            RatingData = new List<RatingData>();
            Candles = new List<MyCandle>();
            MinRating = int.MaxValue;
        }
        public List<RatingData> RatingData { get; set; }
        public List<MyCandle> Candles { get; set; }
        public int MaxRating { get; set; }
        public int MinRating { get; set; }
        public int MaxWinSeries { get; set; }
        public int MaxLooseSeries { get; set; }

        public int MaxDrawDown { get; set; }



    }
}
