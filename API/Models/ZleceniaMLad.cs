using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ZleceniaMLad
    {
        public int IdZleceniaMLad { get; set; }
        /// <summary>
        /// Relacja do zlecenia
        /// </summary>
        public int? ZleceniaMId { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        public int? OpisId { get; set; }
        /// <summary>
        /// Opis towaru
        /// </summary>
        public string Opis { get; set; }
        public int? OpakowanieId { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Symbol opakowania
        /// </summary>
        public string Opakowanie { get; set; }
        /// <summary>
        /// Flaga, czy możliwe piętrowanie
        /// </summary>
        public int? Pietrowanie { get; set; }
        /// <summary>
        /// ADR - kod UN
        /// </summary>
        public string KodUn { get; set; }
        /// <summary>
        /// ADR - Klasa
        /// </summary>
        public string KlasaAdr { get; set; }
        /// <summary>
        /// ADR - Grupa
        /// </summary>
        public string GrupaAdr { get; set; }
        /// <summary>
        /// ADR - Opis
        /// </summary>
        public string OpisAdr { get; set; }
        /// <summary>
        /// Ilość pierwotna
        /// </summary>
        public int? IloscDekl { get; set; }
        /// <summary>
        /// Ilość rzeczywista
        /// </summary>
        public int? IloscRz { get; set; }
        /// <summary>
        /// Waga deklarowana
        /// </summary>
        public double? WagaJedn { get; set; }
        /// <summary>
        /// Waga deklarowana
        /// </summary>
        public double? WagaDekl { get; set; }
        /// <summary>
        /// Waga rzeczywista
        /// </summary>
        public double? WagaRz { get; set; }
        /// <summary>
        /// Waga deklarowana
        /// </summary>
        public double? ObjJedn { get; set; }
        /// <summary>
        /// Objętość deklarowana
        /// </summary>
        public double? ObjDekl { get; set; }
        /// <summary>
        /// Objętość rzeczywista
        /// </summary>
        public double? ObjRz { get; set; }
        /// <summary>
        /// Długość deklarowana
        /// </summary>
        public double? DlDekl { get; set; }
        /// <summary>
        /// Wysokość deklarowana
        /// </summary>
        public double? WyDekl { get; set; }
        /// <summary>
        /// Szerokość deklarowana
        /// </summary>
        public double? SzDekl { get; set; }
        /// <summary>
        /// Długość rzeczywista
        /// </summary>
        public double? DlRz { get; set; }
        /// <summary>
        /// Wysokość rzeczywista
        /// </summary>
        public double? WyRz { get; set; }
        /// <summary>
        /// Szerokość rzeczywista
        /// </summary>
        public double? SzRz { get; set; }
        /// <summary>
        /// Metry ładowne deklarowane
        /// </summary>
        public double? LdmDekl { get; set; }
        /// <summary>
        /// Metry ładowne rzeczywiste
        /// </summary>
        public double? LdmRz { get; set; }
        /// <summary>
        /// Metry dłużycowe deklarowane
        /// </summary>
        public double? DluzycaDekl { get; set; }
        /// <summary>
        /// Metry dłużycowe rzeczywiste
        /// </summary>
        public double? DluzycaRz { get; set; }
        /// <summary>
        /// Miejsca paletowe deklarowane
        /// </summary>
        public double? MpDekl { get; set; }
        /// <summary>
        /// Miejsca paletowe rzeczywiste
        /// </summary>
        public double? MpRz { get; set; }
        /// <summary>
        /// Waga kubaturowa
        /// </summary>
        public double? WagaKubaturowa { get; set; }
        /// <summary>
        /// Waga ładowna
        /// </summary>
        public double? WagaLadowna { get; set; }
        /// <summary>
        /// Flaga, czy jest dodatek za dłużycę
        /// </summary>
        public int? DluzycaDod { get; set; }
        /// <summary>
        /// Dodatkowe KG za dłużycę
        /// </summary>
        public double? DluzycaDodKg { get; set; }
        /// <summary>
        /// Waga obliczeniowa
        /// </summary>
        public double? WagaObl { get; set; }
        /// <summary>
        /// Wartość ładunku
        /// </summary>
        public double? WartoscLadunku { get; set; }
        /// <summary>
        /// Wartość ładunku - waluta
        /// </summary>
        public string WartoscLadunkuWal { get; set; }
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
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string Model { get; set; }
        public string Indeks { get; set; }
    }
}
