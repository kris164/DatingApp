using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class PrzesylkiProtNiezg
    {
        public int IdPrzesylkiProtNiezg { get; set; }
        public DateTime? DataProt { get; set; }
        public string NrProt { get; set; }
        public int? NrProtKolejny { get; set; }
        public int? NrProtRok { get; set; }
        public int? NrProtMies { get; set; }
        public string Typ { get; set; }
        public string Zdarzenie { get; set; }
        public int? ListyLinioweId { get; set; }
        public string ListyLiniowe { get; set; }
        public DateTime? ListyLinioweData { get; set; }
        public DateTime? ListyLinioweDataZawy { get; set; }
        public DateTime? ListyLinioweGodzZawy { get; set; }
        public string Lokalizacja { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public string PrzewoznikTel { get; set; }
        public string Stan { get; set; }
        public int? PracownikId { get; set; }
        public string Pracownik { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public string SamochodNrB { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public string NaczepaNrB { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string KierowcaTel { get; set; }
        public int? Kierowca2Id { get; set; }
        public string Kierowca2 { get; set; }
        public string Kierowca2Tel { get; set; }
        public int? PrzesylkiId { get; set; }
        public string Przesylka { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public int? TeczkaId { get; set; }
        public string Teczka { get; set; }
        public int? OpakFirm { get; set; }
        public string OpakFirmOpis { get; set; }
        public int? OpakFolia { get; set; }
        public string OpakFoliaOpis { get; set; }
        public int? OpakSkrzynia { get; set; }
        public string OpakSkrzyniaOpis { get; set; }
        public int? OpakWorek { get; set; }
        public string OpakWorekOpis { get; set; }
        public int? OpakKarton { get; set; }
        public string OpakKartonOpis { get; set; }
        public int? OpakTasma { get; set; }
        public string OpakTasmaOpis { get; set; }
        public int? OpakPojemnik { get; set; }
        public string OpakPojemnikOpis { get; set; }
        public int? OpakInne { get; set; }
        public string OpakInneOpis { get; set; }
        public string SzczOpisNiezg { get; set; }
        public int? OpakZewnUszk { get; set; }
        public int? DostDoTowaru { get; set; }
        public string RodzajNiezg { get; set; }
        public string RodzajNiezgOpis { get; set; }
        public int? DokumZdj { get; set; }
        public int? DokumZdjIlosc { get; set; }
        public string DokumZdjOpis { get; set; }
        public int? Zabezpieczono { get; set; }
        public string ZabezpieczonoOpis { get; set; }
        public int? ZabezpieczonoInne { get; set; }
        public string ZabezpieczonoInneOpis { get; set; }
        public string Uwagi { get; set; }
        public int? Zalaczniki { get; set; }
        public string SymbolUszk { get; set; }
        public string OpisUszk { get; set; }
        public string OpisUszkUzup { get; set; }
        public int? MagazynZdarzeniaId { get; set; }
        public string Dzial { get; set; }
        public DateTime? GodzProt { get; set; }
        public double? Obj { get; set; }
        public string WarunkiDostawy { get; set; }
    }
}
