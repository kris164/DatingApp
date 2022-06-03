using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WynagrLp
    {
        public int IdWynagrLp { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public int? WynagrSchematId { get; set; }
        public string WynagrSchemat { get; set; }
        public string Status { get; set; }
        public DateTime? DataZamkniecia { get; set; }
        public string Opis { get; set; }
        public double? Suma { get; set; }
        public int? FakturyId { get; set; }
        public string Faktury { get; set; }
        public string RodzKosztow { get; set; }
        public string ProceduraDbDekr { get; set; }
        public string ProceduraDbDekrInfo { get; set; }
        public DateTime? OstEdycjaDt { get; set; }
        public string OstEdycjaUser { get; set; }
        public int? Zalaczniki { get; set; }
        public string Waluta { get; set; }
        public string Lokalizacja { get; set; }
    }
}
