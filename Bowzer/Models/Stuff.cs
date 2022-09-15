using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bowzer.Models
{
    public class Stuff
    {
        //[JsonPropertyName("kind")]
        //public string Kind { get; set; }
        //[JsonPropertyName("data")]
        //public Data Data { get; set; }

        public string kind { get; set; }
        public Data data { get; set; }
    }
}
