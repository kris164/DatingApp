using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmTabor
    {
        public int IdSfmTabor { get; set; }
        public int IdTabor { get; set; }
        public int? IloscPlan { get; set; }
        public int? IloscWyk { get; set; }
        public string POper { get; set; }
        public DateTime? PData { get; set; }
        public string PKraj { get; set; }
        public string PKod { get; set; }
        public string PMiejsce { get; set; }
        public string PZlecnia { get; set; }
        public string AOper { get; set; }
        public DateTime? AData { get; set; }
        public string AKraj { get; set; }
        public string AKod { get; set; }
        public string AMiejsce { get; set; }
        public string AZlecnia { get; set; }
        public string AOpistw { get; set; }
        public short? StatusPoz { get; set; }
        public DateTime? DataPoz { get; set; }
        public string Pozycja { get; set; }
        public string PozLonlat { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public short? StatusWiad { get; set; }
        public DateTime? DataWiad { get; set; }
        public string Wiadomosc { get; set; }
        public short? WStatusWiad { get; set; }
        public DateTime? WDataWiad { get; set; }
        public string WWiadomosc { get; set; }
        public short? Alarm { get; set; }
        public DateTime? DtAktualizacji { get; set; }
        public short? Corridor { get; set; }
        public DateTime? SfmKierowcaData { get; set; }
        public int? SfmKierowcaId { get; set; }
        public string SfmKierowca { get; set; }
        public short? Planzlecen { get; set; }
        public int? IdSfmPos { get; set; }
        public string NrRejNaczepy { get; set; }
        public string NrInwent { get; set; }
        public int? Aktywny { get; set; }
        public int? UzytkownikId { get; set; }
        public string Uzytkownik { get; set; }
        public string Grupa { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double? Ladownosc { get; set; }
        public double? Dlugosc { get; set; }
        public double? Wysokosc { get; set; }
        public double? Szerokosc { get; set; }
        public int? MiejscaPaletowe { get; set; }
        public string TypZabudowy { get; set; }
        public string SposobLadowania { get; set; }
        public DateTime? StatusDt { get; set; }
        public short? AlertStat { get; set; }
        public DateTime? AlertDt { get; set; }
        public string AlertTxt { get; set; }
        /// <summary>
        /// Kod aktywności na pojeździe
        /// </summary>
        public string Aktywnosc { get; set; }
        /// <summary>
        /// Data aktywności
        /// </summary>
        public DateTime? AktywnoscDt { get; set; }
        public DateTime? SfmKierowca2Data { get; set; }
        public int? SfmKierowca2Id { get; set; }
        public string SfmKierowca2 { get; set; }
        public string EtaOper { get; set; }
        public DateTime? EtaOperDt { get; set; }
        public string EtaKraj { get; set; }
        public string EtaKod { get; set; }
        public string EtaMiejsce { get; set; }
        public string EtaZlecnia { get; set; }
        public string EtaOpistw { get; set; }
        public DateTime? EtaData { get; set; }
        public DateTime? EtaDt { get; set; }
        public double? EtaCzas { get; set; }
        public double? EtaKm { get; set; }
    }
}
