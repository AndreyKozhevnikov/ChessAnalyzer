using ChessGamesParser.Classes.JsonClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGamesParser.Classes {
    public class JsonParser {
        public RootGames ParseFile(string jsonFile) {
            string jsonText;
            using(var reader=new StreamReader(jsonFile)) {
                jsonText = reader.ReadToEnd();
                
            }
            RootGames rootGames = JsonConvert.DeserializeObject<RootGames>(jsonText);
            return rootGames;
        }
        public RootGames ParseString(string jsonText) {
            RootGames rootGames = JsonConvert.DeserializeObject<RootGames>(jsonText);
            return rootGames;
        }
    }
}
