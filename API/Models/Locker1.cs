using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Locker1
    {
        public int Lockerid { get; set; }
        public string Tablename { get; set; }
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Computername { get; set; }
        public string Sessionparams { get; set; }
        public DateTime? Lockdate { get; set; }
    }
}
