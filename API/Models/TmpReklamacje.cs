using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpReklamacje
    {
        public int IdTmpReklamacje { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? IdReklamacje { get; set; }
        public int? ObiektTyp { get; set; }
        public int? ObiektId { get; set; }
        public DateTime? DataRekl { get; set; }
    }
}
