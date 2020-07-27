using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200727_API
{

    /*
     *
     *{
    "category": "Programming",
    "type": "single",
    "joke": "TIL that changing random stuff until your program works is \"hacky\" and a \"bad coding practice\" but if you do it fast enough it's \"Machine Learning\" and pays 4x your current salary.",
    "flags": {
        "nsfw": false,
        "religious": false,
        "political": false,
        "racist": false,
        "sexist": false
    },
    "id": 33,
    "error": false
}
     * 
     */
    class JokeClass
    {
        public string category { get; set; }
        public string type { get; set; }
        public string joke { get; set; }
        public flag flags { get; set; }
        public int id { get; set; }
        public bool error { get; set; }
        public string setup { get; set; }
        public string delivery { get; set; }
    }

    class flag
    {
        public bool nsfw { get; set; }
        public bool religious { get; set; }
        public bool political { get; set; }
        public bool racist { get; set; }
        public bool sexist { get; set; }
    }
}
