using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAnalyzer.Classes {
    public class MyMove {
        public MyMove(string _name) {
            Name = _name;
            Key = Guid.NewGuid();
        }

        public Guid Key { get; set; }
        public Guid ParentKey{ get; set; }
        public string Name { get; set; }
        public int MoveNumber { get; set; }
        public int Count{ get; set; }
        public List<MyMove> NextMoves { get; set; }

    }
}
