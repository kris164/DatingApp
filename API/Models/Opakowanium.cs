using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Opakowanium
    {
        public int IdOpakowania { get; set; }
        public string Kod { get; set; }
        public string Opis { get; set; }
        public double? Dl { get; set; }
        public double? Sz { get; set; }
        public double? Wy { get; set; }
        public double? WagaMax { get; set; }
        public short? Zwrotne { get; set; }
        public short? Ryczaltowe { get; set; }
        public short? PodlegaWymianie { get; set; }
        public short? LpWymiany { get; set; }
        public double? MagPrzyjeto { get; set; }
        public double? MagWydano { get; set; }
        public double? MagStan { get; set; }
        public double? StanOg { get; set; }
        public double? Obj { get; set; }
        public double? CenaPln { get; set; }
        public short? PobierajWymiary { get; set; }
        public double? CenaKraj { get; set; }
        public string CenaKrajWal { get; set; }
        public double? CenaZagr { get; set; }
        public string CenaZagrWal { get; set; }
        public double? MPal { get; set; }
        public short? Luzem { get; set; }
        public short? OdziezWisz { get; set; }
        public double? DlMax { get; set; }
        public double? SzMax { get; set; }
        public double? WyMax { get; set; }
        public double? WagaOpak { get; set; }
        public double? ObjMax { get; set; }
        public double? MPalOpak { get; set; }
        public double? WyOpak { get; set; }
        public string ZwrotJt { get; set; }
        public int? ZwrotJtId { get; set; }
        public double? ObjOpak { get; set; }
        public string OpisNota { get; set; }
        public int? OpisNotaId { get; set; }
        public short? MagOpak { get; set; }
        public int? Lp { get; set; }
        public int? WagaOpakDoWagi { get; set; }
        public short? Standard { get; set; }
        public string Wyroznik { get; set; }
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
        public double? DlMin { get; set; }
        public double? SzMin { get; set; }
        public double? WyMin { get; set; }
        public double? WagaMin { get; set; }
        public double? WagaDef { get; set; }
        public double? ObjMin { get; set; }
        public double? MpalMin { get; set; }
        public double? MpalMax { get; set; }
        public short? Paletyzacja { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
