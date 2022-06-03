using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Model
    {
        public int IdModel { get; set; }
        public int? MarkaId { get; set; }
        public string Nazwa { get; set; }
        public string ProdOd { get; set; }
        public string ProdDo { get; set; }
        public string Vin { get; set; }
    }
}
