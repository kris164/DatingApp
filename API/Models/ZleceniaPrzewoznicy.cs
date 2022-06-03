using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaPrzewoznicy
    {
        public int IdZleceniaPrzewoznicy { get; set; }
        public int ZleceniaId { get; set; }
        public int KontrahId { get; set; }
    }
}
