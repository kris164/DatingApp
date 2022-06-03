using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TachoTrasy
    {
        public int IdTachoTrasy { get; set; }
        public int IdTacho { get; set; }
        public string MiejsceOd { get; set; }
        public string MiejsceDo { get; set; }
    }
}
