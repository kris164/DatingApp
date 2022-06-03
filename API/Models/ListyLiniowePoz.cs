using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ListyLiniowePoz
    {
        public int IdListyLiniowePoz { get; set; }
        public int? Lp { get; set; }
        public int? ListyLinioweId { get; set; }
        public int? PrzesylkiId { get; set; }
        public int? Czesciowka { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public string LokalizacjaZ { get; set; }
        public string LokalizacjaDo { get; set; }
        public int? Skan { get; set; }
        public double? Km { get; set; }
        public int? WyjatekRiAnulowana { get; set; }
        public int? SeriaWydruku { get; set; }
        public string GrupaWydruku { get; set; }
        public int? ByloPonownePlanowanie { get; set; }
        public int? PrzeladunekNaKolach { get; set; }
        public int? DokumOk { get; set; }
        public int? Podjecie { get; set; }
        public int? Doreczenie { get; set; }
        public double? MiejscaPal { get; set; }
        public string BylTypP { get; set; }
        public int? InnaLok { get; set; }
        public string InnaLokalizacja { get; set; }
        public int? PoiPodjecieId { get; set; }
        public string ZaNazwa { get; set; }
        public string ZaAdres { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKod { get; set; }
        public string ZaKraj { get; set; }
        public int? PoiDoreczenieId { get; set; }
        public string WyNazwa { get; set; }
        public string WyAdres { get; set; }
        public string WyMiasto { get; set; }
        public string WyKod { get; set; }
        public string WyKraj { get; set; }
        public int? LlZaId { get; set; }
        public int? LlWyId { get; set; }
        public int? MagazynZdarzeniaPozId { get; set; }
        public int? MagazynZdarzeniaPozPzId { get; set; }
        public int? Niedoreczona { get; set; }
        public int? NiedoreczonaWina { get; set; }
        public int? AwizoWewn { get; set; }
        public int? ZlpId { get; set; }
        public int? ZalNaC { get; set; }
        public int? ZalNaN { get; set; }
        public int? Brak { get; set; }
        public double? AnomaliaOpakIlosc { get; set; }
        public int? Niepodjeta { get; set; }
        public int? BlokadaOdplanowania { get; set; }
        public int? ZlpIdAnul { get; set; }
        /// <summary>
        /// Relacja do użytkownika tworzącego rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? CreateIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika tworzącego rekord
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// Data utworzenia
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Godzina utworzenia
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// Relacja do użytkownika który ostatni modyfikował rekord - tab: UZYTKOWNIK
        /// </summary>
        public int? ModifyIdUser { get; set; }
        /// <summary>
        /// Nazwa użytkownika modyfikującego rekord
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Data ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// Godzina ostatniej modyfikacji
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        public int? Clenie { get; set; }
        public int? SkanWy { get; set; }
        public int? BrakWy { get; set; }
        public double? AnomaliaOpakIloscWy { get; set; }
        public int? WymaganyZaladunek { get; set; }
        public int? DoDepo { get; set; }
        public int? ByloDepozytGdzieJestId { get; set; }
        public string SqlDebugInfo { get; set; }
        public int? SentState { get; set; }
        public DateTime? SentDt { get; set; }
        public int? LlNdId { get; set; }
    }
}
