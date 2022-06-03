using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// domyślny profil dla konfiguracji kontrolek formularzy
    /// </summary>
    public partial class Userappdefprofile
    {
        public int IdUserappdefprofile { get; set; }
        public string Appname { get; set; }
        public int IdUser { get; set; }
        public int IdProfile { get; set; }
        public string Dzial { get; set; }
    }
}
