using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzkodyDokumenty
    {
        public int IdSzkodyDokumenty { get; set; }
        public int? SzkodyId { get; set; }
        public int? Lp { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? Wymagany { get; set; }
        public int? Wplynal { get; set; }
        public DateTime? DataWplywu { get; set; }
        public string Uzytkownik { get; set; }
        public string Grupa { get; set; }
        public string Status { get; set; }
        public string Uwagi { get; set; }
        public int? Zalaczniki { get; set; }
        public string UzytkownikPotw { get; set; }
    }
}
