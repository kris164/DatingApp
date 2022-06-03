using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class WariantyGenZawyTra
    {
        public int IdWariantyGenZawyTras { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public int? Aktywny { get; set; }
        public int? Algorytm { get; set; }
        public int? NaPodstZawyPrzesylek { get; set; }
        public int? Scalaj { get; set; }
        public int? PomijajZa { get; set; }
        public int? LokalizacjaJakoZa { get; set; }
        public int? PomijajWy { get; set; }
        public int? LokalizacjaJakoWy { get; set; }
        public int? ProceduraDbId { get; set; }
        public string ProceduraDb { get; set; }
        public int? Domyslny { get; set; }
        public string DomyslnyDlaTrasyTypu { get; set; }
        public int? UstawEtaZa { get; set; }
        public int? UstawEtaZaId { get; set; }
        public int? UstawEtaWy { get; set; }
        public int? UstawEtaWyId { get; set; }
        public int? UstawWrnZa { get; set; }
        public int? UstawWrnZaId { get; set; }
        public int? UstawWrnWy { get; set; }
        public int? UstawWrnWyId { get; set; }
        public int? ZalWgDatyDo { get; set; }
        public int? WylWgDatyDo { get; set; }
        public int? NaPodstLokTrasy { get; set; }
        public int? UzyjProc { get; set; }
        public string Procedura { get; set; }
    }
}
