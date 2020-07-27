using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200727_API
{
    class Faktai
    {
        /*
         * 
    "definitions": [
        {
            "type": "noun",
            "definition": "a small finch-like Old World bird related to the weaver birds, typically with brown and grey plumage.",
            "example": null,
            "image_url": "https://media.owlbot.info/dictionary/images/eeew.jpg.400x400_q85_box-0,0,1220,1220_crop_detail.jpg",
            "emoji": null
        }
    ],
    "word": "sparrow",
    "pronunciation": "ˈsperō"*/
        public Informacija[] definitions { get; set; }
        public string word { get; set; }
        public string pronunciation { get; set; }
    }

    class Informacija
    {
        public string type { get; set; }
        public string definition { get; set; }
        public string example { get; set; }
        public string image_url { get; set; }
        public string emoji { get; set; }
    }
}
