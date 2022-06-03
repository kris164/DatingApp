using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpWymOpakRozl
    {
        public int IdTmpWymOpakRozl { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? Zrodlo { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? PrzewoznikId { get; set; }
        public int? OpakowanieId { get; set; }
        public int? Ilosc { get; set; }
        public int? OpakWym { get; set; }
        public int? OpakWymDoRozl { get; set; }
        public string MiejsceTyp { get; set; }
        public int? MiejsceId { get; set; }
        public string Miejsce { get; set; }
        public int? NadawcaId { get; set; }
        public int? OdbiorcaId { get; set; }
        public int? KlientId { get; set; }
        public string NrRozl { get; set; }
        public int? Pobral { get; set; }
        public int? Zdal { get; set; }
        public int? NieZwr { get; set; }
        public int? Rozl { get; set; }
        public int? BilansKlient { get; set; }
        public int? BilansNadawca { get; set; }
        public int? BilansOdbiorca { get; set; }
        public int? BilansPrzewoznik { get; set; }
    }
}
