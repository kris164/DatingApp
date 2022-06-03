using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy zleceń drobnicowych
    /// </summary>
    public partial class TypyZlecenDrobn
    {
        public int IdTypyZlecenDrobn { get; set; }
        /// <summary>
        /// Kod typu zlecenia
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Symbol na potrzeby liczników systemowych
        /// </summary>
        public string SymbolLicznika { get; set; }
        /// <summary>
        /// Symbol na potrzeby interfejsów FK
        /// </summary>
        public string SymbolFk { get; set; }
        /// <summary>
        /// Flaga, czy typ zlecenia jest widoczny
        /// </summary>
        public short? Widoczny { get; set; }
        /// <summary>
        /// Flaga, czy typ zlecenia jest systemowy - dodany przez InterLAN
        /// </summary>
        public short? Systemowy { get; set; }
        public short? Poziom { get; set; }
        public double? MaxWaga { get; set; }
        public double? MaxObj { get; set; }
        public double? MaxLdm { get; set; }
        public double? MaxMpal { get; set; }
        public double? MaxIlosc { get; set; }
        public double? MaxWagaDoObl { get; set; }
        public short? TrasaDirect { get; set; }
        public short? TrasaDirectKl { get; set; }
        public short? ZabronionaZmianaTypu { get; set; }
        public double? MinWaga { get; set; }
        public double? MinObj { get; set; }
        public double? MinLdm { get; set; }
        public double? MinMpal { get; set; }
        public double? MinIlosc { get; set; }
        public double? MinWagaDoObl { get; set; }
        /// <summary>
        /// Domyślny opis ładunku paczki
        /// </summary>
        public int? DroDefOpisLadId { get; set; }
        public int? OpakId { get; set; }
        public double? OpakWagaMin { get; set; }
        public double? OpakWagaMax { get; set; }
        public double? OpakObjMin { get; set; }
        public double? OpakObjMax { get; set; }
        public double? OpakDlMin { get; set; }
        public double? OpakDlMax { get; set; }
        public double? OpakSzMin { get; set; }
        public double? OpakSzMax { get; set; }
        public double? OpakWyMin { get; set; }
        public double? OpakWyMax { get; set; }
        public double? OpakSumWymMin { get; set; }
        public double? OpakSumWymMax { get; set; }
        public short? WylGenTrasyWgSieci { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
