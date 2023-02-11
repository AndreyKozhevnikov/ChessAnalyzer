using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAnalyzer.Classes {
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
        

    }
}
