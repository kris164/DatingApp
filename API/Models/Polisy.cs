using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Polisy
    {
        public int IdPolisy { get; set; }
        public int? TaborId { get; set; }
        public string Tabor { get; set; }
        public int? UbezpieczycielId { get; set; }
        public string Ubezpieczyciel { get; set; }
        public string NumerPolisy { get; set; }
        public int? Oc { get; set; }
        public int? Ac { get; set; }
        public int? Nw { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? DataDo { get; set; }
        public string Uwagi { get; set; }
        public double? Znizki { get; set; }
        public double? Skladka { get; set; }
        public int? Zalaczniki { get; set; }
        public int? Aktywna { get; set; }
        public int? Ocp { get; set; }
        public string TaborNrBoczny { get; set; }
        public string Lokalizacja { get; set; }
        public int? KontrahId { get; set; }
        public string Kontrah { get; set; }
        public double? Wartosc { get; set; }
        public string WartoscWal { get; set; }
        public int? Kraj { get; set; }
        public int? Zagranica { get; set; }
        public string Kraje { get; set; }
        public string KrajeKabotaz { get; set; }
        public int? Kabotaz { get; set; }
        public double? SkladkaOc { get; set; }
        public double? SkladkaAc { get; set; }
        public double? SkladkaNw { get; set; }
        public int? OcpTowaryPodwRyzyko { get; set; }
        public int? OcpTowaryKontrTemp { get; set; }
        public string SkladkaWal { get; set; }
        public string SkladkaOcWal { get; set; }
        public string SkladkaAcWal { get; set; }
        public string SkladkaNwWal { get; set; }
        public double? SkladkaInne { get; set; }
        public string SkladkaInneWal { get; set; }
        public string UwagiOc { get; set; }
        public string UwagiAc { get; set; }
        public string UwagiNw { get; set; }
        public double? UdzialWlasnyOc { get; set; }
        public string UdzialWlasnyOcWal { get; set; }
        public double? UdzialWlasnyAc { get; set; }
        public string UdzialWlasnyAcWal { get; set; }
        public DateTime? DataDoAc { get; set; }
        public string ZielonaKartaNr { get; set; }
        public int? Kradziez { get; set; }
        public int? OdpowiedzialnyId { get; set; }
        public string Odpowiedzialny { get; set; }
        public string PolisaGlowna { get; set; }
        public string Mpk { get; set; }
        public double? SkladkaAcProcent { get; set; }
        public int? Rozboj { get; set; }
        public int? Ass { get; set; }
        public double? SkladkaAs { get; set; }
        public string SkladkaAsWal { get; set; }
        public string UwagiAs { get; set; }
        public double? SumaGwarOc { get; set; }
        public string SumaGwarOcWal { get; set; }
        public double? SumaGwarAc { get; set; }
        public string SumaGwarAcWal { get; set; }
        public double? SumaGwarNw { get; set; }
        public string SumaGwarNwWal { get; set; }
        public double? SumaGwarAs { get; set; }
        public string SumaGwarAsWal { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
        public int? WnioskujacyId { get; set; }
        public string Wnioskujacy { get; set; }
        public int? Wnioskujacy2Id { get; set; }
        public string Wnioskujacy2 { get; set; }
        public int? BrokerId { get; set; }
        public string Broker { get; set; }
        public int? OpiekunId { get; set; }
        public string Opiekun { get; set; }
        public double? SkladkaProcent { get; set; }
        public int? Zapytanie { get; set; }
        public int? ZapytanieId { get; set; }
        public int? Anulowana { get; set; }
        public string StatusEmisja { get; set; }
        public int? KontaktId { get; set; }
        public string Kontakt { get; set; }
        public double? Odszkodowanie { get; set; }
        public DateTime? Data { get; set; }
        public int? Niedbalstwo { get; set; }
    }
}
