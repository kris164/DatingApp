using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TTachoZdarzenium
    {
        public int IdTachoZdarzenia { get; set; }
        public int IdTacho { get; set; }
        public int IdKierowcy { get; set; }
        public int IdTaboru { get; set; }
        public DateTime? DataczasOd { get; set; }
        public DateTime? DataczasDo { get; set; }
        public int? Lp { get; set; }
        /// <summary>
        /// tryb pracy (JAZDA/PRACA/DYZUR/POSTOJ/NIEZNANY)
        /// </summary>
        public string Tryb { get; set; }
        public DateTime? CzasOd { get; set; }
        public DateTime? CzasDo { get; set; }
        public DateTime? CzasTrwania { get; set; }
        /// <summary>
        /// ilość kilometrów
        /// </summary>
        public double? Km { get; set; }
        public int? XStart { get; set; }
        public int? XStop { get; set; }
        /// <summary>
        /// uwagi o czasie jazdy
        /// </summary>
        public string Uwagi { get; set; }
        public short? Zespolowa { get; set; }
        /// <summary>
        /// końcowy licznik kilometrów
        /// </summary>
        public double? Lkm { get; set; }
        /// <summary>
        /// 0-otwarte /1-zamknięcie okresu /2-przetworzona JAZDA
        /// </summary>
        public short? Zrobione { get; set; }
        /// <summary>
        /// typ terminala (źródła danych)
        /// </summary>
        public string TypTerm { get; set; }
        public string Crc { get; set; }
        /// <summary>
        /// czas utworzenia rekordu
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// czas ostatniej aktualizacji rekordu
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// ID terminala SFM
        /// </summary>
        public int? IdSfmTerm { get; set; }
        /// <summary>
        /// ID danych w systemie zewnętrznym
        /// </summary>
        public long? Extid { get; set; }
        /// <summary>
        /// źródło danych M-message /F-ftp /U-user
        /// </summary>
        public string Src { get; set; }
        public DateTime? DtFilter { get; set; }
        /// <summary>
        /// ID definicji systemu telematycznego
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// 0/1 - czy to drugi kierowca przy jeździe w zespole
        /// </summary>
        public short? CoDriver { get; set; }
        /// <summary>
        /// kod kraju rozpoczęcia aktywności
        /// </summary>
        public string Country { get; set; }
    }
}
