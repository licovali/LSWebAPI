using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSWebAPI.Models
{
    public class items
    {
        public string id { get; set; }
        public string text { get; set; }
        public string iconCls { get; set; }
        public string parent_id { get; set; }
        public string className { get; set; }
        public bool leaf { get; set; }
    }

    public class root
    {
        public string id { get; set; }
        public string text { get; set; }
        public string iconCls { get; set; }
        public string parent_id { get; set; }
        public string className { get; set; }
        public bool leaf { get; set; }
        public items[] items { get; set; }
    }
}