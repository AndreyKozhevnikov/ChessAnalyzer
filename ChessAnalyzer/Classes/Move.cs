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
        MyMove parentMove;
        public Guid ParentKey { get; private set; }

        public MyMove ParentMove {
            get => parentMove; set {
                parentMove = value;
                ParentKey = parentMove.Key;
            }

        }

        public string FingerPrint {
            get {
                if(ParentMove == null) {
                    return null;
                } else {
                    if(parentMove.FingerPrint == null) {
                        return Name;
                    }
                    return string.Join(" ", ParentMove.FingerPrint, Name);
                }
            }
        }
        public string Name { get; set; }
        public int MoveNumber { get; set; }
        public int Count { get; set; }
        public List<MyMove> NextMoves { get; set; }
        public bool IsWhite { get; set; }

    }
}
