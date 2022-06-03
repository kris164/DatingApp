using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ProtNiezg
    {
        public int IdProtNiezg { get; set; }
        public DateTime DataGodzProt { get; set; }
        public string NrProt { get; set; }
        public int? NrProtKolejny { get; set; }
        public int? NrProtRok { get; set; }
        public int? NrProtMies { get; set; }
        public int? MiejsceSporzadzenia { get; set; }
        public int TypyProtNiezgId { get; set; }
        public int ZdarzeniaProtNiezgId { get; set; }
        public int? MagazynZdarzeniaId { get; set; }
        public int? ListyLinioweId { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string Relacja { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Stan { get; set; }
        public int? PracownikId { get; set; }
        public int? SamochodId { get; set; }
        public int? NaczepaId { get; set; }
        public int? KierowcaId { get; set; }
        public string KierowcaTel { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2Tel { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? TeczkaId { get; set; }
        public string RodzajUwagi { get; set; }
        public string SposobOpakUwagi { get; set; }
        public string DodKomentUwagi { get; set; }
        public string Uwagi { get; set; }
        public int? Zalaczniki { get; set; }
        public int? DokumZdj { get; set; }
        public int? DokumZdjIlosc { get; set; }
        public string DokumZdjOpis { get; set; }
        public int? OpakZewnUszk { get; set; }
        public int? DostDoTowaru { get; set; }
        public int? ReklamacjeId { get; set; }
        public int? PoprZabezp { get; set; }
    }
}
