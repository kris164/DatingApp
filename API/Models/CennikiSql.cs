using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje cenników SQL (opartych o procedury składowane)
    /// </summary>
    public partial class CennikiSql
    {
        public int IdCennikiSql { get; set; }
        /// <summary>
        /// Nazwa cennika
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy cennik FTL
        /// </summary>
        public int? Ftl { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Relacja do trasy - tab: TRASY
        /// </summary>
        public int? TrasaId { get; set; }
        /// <summary>
        /// Opis trasy
        /// </summary>
        public string Trasa { get; set; }
        /// <summary>
        /// Ważność cennika od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Ważność cennika do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Waluta cennika
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// ID typu cennika - pobierane z XML-a
        /// </summary>
        public string TypId { get; set; }
        /// <summary>
        /// Typ cennika - pobierane z XML-a
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Opis rozszerzony
        /// </summary>
        public byte[] OpisExt { get; set; }
        /// <summary>
        /// Ilość załączników
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Czy cennik używa struktur _TMP
        /// </summary>
        public int? CennikUseTmp { get; set; }
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
        /// <summary>
        /// Nazwa procedury skladowanej
        /// </summary>
        public string Procedura { get; set; }
        /// <summary>
        /// Nazwa schematu
        /// </summary>
        public string SchematNazwa { get; set; }
        /// <summary>
        /// Symbol schematu
        /// </summary>
        public string SchematSymbol { get; set; }
        /// <summary>
        /// Flaga okreslajaca czy cennik jest wzorcem
        /// </summary>
        public int Wzorzec { get; set; }
        /// <summary>
        /// Określenie typu cennika  P - przychod, K koszt, RW - rozliczenie wewnetrzne
        /// </summary>
        public string TypCennika { get; set; }
        /// <summary>
        ///  P - przesyłka, T - trasa, PM - prom, Z Zlecenie FTL,
        /// </summary>
        public string Dotyczy { get; set; }
        /// <summary>
        ///  K - kalkulacja, N nagłówek, 
        /// </summary>
        public string Poziom { get; set; }
        /// <summary>
        ///  P - podjecie, D - dostawa - doręczenie, I - inny, X - podjęcie/ dostawa
        /// </summary>
        public string Kierunek { get; set; }
        /// <summary>
        ///  0 - aktualizacja trwa, 1 aktualizacja rekodru zakonczona
        /// </summary>
        public int? Aktualizacja { get; set; }
        /// <summary>
        ///  0 - cennik aktywny, 1- cennik nieaktywny
        /// </summary>
        public int? Nieaktywny { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        /// <summary>
        /// Flaga, czy cennik KONFIGURACYJNY
        /// </summary>
        public int? Konfiguracja { get; set; }
        /// <summary>
        /// Flaga, czy cennik KONTEKSTOWY
        /// </summary>
        public int? Kontekstowy { get; set; }
    }
}
