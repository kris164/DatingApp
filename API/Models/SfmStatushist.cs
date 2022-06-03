using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmStatushist
    {
        public int IdSfmStatushist { get; set; }
        /// <summary>
        /// id statusu SFM
        /// </summary>
        public int? IdSfmStatus { get; set; }
        /// <summary>
        /// numer statusu SFM
        /// </summary>
        public int? NrStat { get; set; }
        /// <summary>
        /// grupa statusu
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// czas statusu
        /// </summary>
        public DateTime? DtStat { get; set; }
        /// <summary>
        /// czas zapisu statusu
        /// </summary>
        public DateTime? DtZapis { get; set; }
        /// <summary>
        /// użytkownik zapisu
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// id pojazdu
        /// </summary>
        public int? IdTabor { get; set; }
        /// <summary>
        /// id pierwszego kierowcy
        /// </summary>
        public int? IdKierowcy1 { get; set; }
        /// <summary>
        /// id drugiego kierowcy
        /// </summary>
        public int? IdKierowcy2 { get; set; }
        /// <summary>
        /// id zlecenia
        /// </summary>
        public int? IdZlecenia { get; set; }
        /// <summary>
        /// id zdarzenia zlecenia
        /// </summary>
        public int? IdZleceniaZaWy { get; set; }
        /// <summary>
        /// id polecenia wyjazdu
        /// </summary>
        public int? IdWyjazdy { get; set; }
        /// <summary>
        /// id pozycji GPS
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// id komunikatu z tabeli SFM_Msg
        /// </summary>
        public int? IdSfmMsg { get; set; }
        /// <summary>
        /// długość geograficzna
        /// </summary>
        public double? Lon { get; set; }
        /// <summary>
        /// szerokość geograficzna
        /// </summary>
        public double? Lat { get; set; }
        /// <summary>
        /// stan licznika kilometrów [km]
        /// </summary>
        public double? Lkm { get; set; }
        /// <summary>
        /// stan paliwa [L]
        /// </summary>
        public double? Paliwo { get; set; }
        /// <summary>
        /// kod kraju (wg ISO)
        /// </summary>
        public string Kraj { get; set; }
        /// <summary>
        /// numer i data CMR
        /// </summary>
        public string Cmr { get; set; }
        /// <summary>
        /// inf. dodatkowe
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// nazwa tabeli objektu związanego z makrem
        /// </summary>
        public string TypObj { get; set; }
        /// <summary>
        /// id objektu związanego z makrem
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// liczba wykonanych akcji
        /// </summary>
        public int? Wykonano { get; set; }
        /// <summary>
        /// zlec.REF_NAD
        /// </summary>
        public string Ref1 { get; set; }
        /// <summary>
        /// zlec.REF_ODB
        /// </summary>
        public string Ref2 { get; set; }
        /// <summary>
        /// zlec.REF_POS
        /// </summary>
        public string Ref3 { get; set; }
        /// <summary>
        /// zlec.REF_4
        /// </summary>
        public string Ref4 { get; set; }
        /// <summary>
        /// zlec.REF_5
        /// </summary>
        public string Ref5 { get; set; }
        /// <summary>
        /// id terminala
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// 0/1 Flaga, czy akcja jest zgodna z procesem
        /// </summary>
        public short? Niezgodny { get; set; }
        /// <summary>
        /// id statusu zlecenia przed akcją (tab. STATUS)
        /// </summary>
        public int? StatusId { get; set; }
        /// <summary>
        /// poziom statusu zlecenia przed akcją (tab. STATUS)
        /// </summary>
        public int? StatusPoziom { get; set; }
        /// <summary>
        /// id statusu zlecenia po akcji (tab. STATUS)
        /// </summary>
        public int? StatusAId { get; set; }
        /// <summary>
        /// poziom statusu zlecenia po akcji (tab. STATUS)
        /// </summary>
        public int? StatusAPoziom { get; set; }
        /// <summary>
        /// poziom akcji zlecenia
        /// </summary>
        public int? PoziomZlec { get; set; }
        /// <summary>
        /// poziom akcji zdarzeń zlecenia
        /// </summary>
        public int? PoziomZawy { get; set; }
        /// <summary>
        /// poziom akcji zdarzeń zlec. głównego
        /// </summary>
        public int? PoziomZawyGl { get; set; }
        /// <summary>
        /// poziom akcji zdarzeń zlec. nadrzędnego
        /// </summary>
        public int? PoziomZawyNd { get; set; }
        /// <summary>
        /// poziom akcji polecenia wyjazdu
        /// </summary>
        public int? PoziomPw { get; set; }
        /// <summary>
        /// poziom akcji taboru
        /// </summary>
        public int? PoziomTabor { get; set; }
        /// <summary>
        /// poziom akcji kierowcy 1
        /// </summary>
        public int? PoziomKier1 { get; set; }
        /// <summary>
        /// poziom akcji kierowcy 2
        /// </summary>
        public int? PoziomKier2 { get; set; }
        /// <summary>
        /// rzeczywista temp. przewozu
        /// </summary>
        public string Temp { get; set; }
        /// <summary>
        /// waga rzeczywista
        /// </summary>
        public double? Waga { get; set; }
        /// <summary>
        /// jednostka wagi (T lub KG)
        /// </summary>
        public string Wagajm { get; set; }
        /// <summary>
        /// LOG wykonania wszystkich akcji w postaci XML
        /// </summary>
        public string ResultXml { get; set; }
        /// <summary>
        /// stan licznika zużytego paliwa [L]
        /// </summary>
        public double? Tfu { get; set; }
        /// <summary>
        /// poziom paliwa w zbiorniku pojazdu [L]
        /// </summary>
        public double? Fla { get; set; }
    }
}
