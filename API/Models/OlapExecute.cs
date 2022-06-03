using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OlapExecute
    {
        public int IdOlapExecute { get; set; }
        public int OlapDefinicjeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Params { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
