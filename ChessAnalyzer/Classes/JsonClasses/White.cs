using Newtonsoft.Json;
using System;
using System.Linq;

namespace ChessGamesParser.Classes.JsonClasses {
    public class White {
        public int rating { get; set; }
        public string result { get; set; }

        [JsonProperty("@id")]
        public string id { get; set; }
        public string username { get; set; }
        public string uuid { get; set; }
    }
}
