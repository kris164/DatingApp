using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Ustalenium
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public int ObjId { get; set; }
        public string ObjExtId { get; set; }
        public string Loc { get; set; }
        public string Dep { get; set; }
        public string TextCode { get; set; }
    }
}
