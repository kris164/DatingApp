using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Tabela zawierajaca statusy dla wszystkich obiektówe w systemie
    /// </summary>
    public partial class Statusy
    {
        public int IdStatusy { get; set; }
        /// <summary>
        /// Kod statusu
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Kod poprzedniego statusu
        /// </summary>
        public string StatusPoprz { get; set; }
        /// <summary>
        /// Data nadania
        /// </summary>
        public DateTime? Data { get; set; }
        /// <summary>
        /// Godzina nadania
        /// </summary>
        public DateTime? Czas { get; set; }
        /// <summary>
        /// Relacja do użytkownika - tab: UZYTKOWNIK
        /// </summary>
        public int? IdUzytkow { get; set; }
        /// <summary>
        /// Symbol użytkownika
        /// </summary>
        public string Uzytkow { get; set; }
        /// <summary>
        /// ID obiektu: 1-DR, 2_FT, 3-PA, 4-OF, 5-PR, 6-LL, 7-SZ, 8-RP, 9-RS, 10-PW
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// ID rekordu danego typu obiektu
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// Dowolna informacja do statusu
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        public string Slot1 { get; set; }
        public string Slot2 { get; set; }
        public string Slot3 { get; set; }
        public string Slot4 { get; set; }
        public string Slot5 { get; set; }
        /// <summary>
        /// Slot dodatkowy 1
        /// </summary>
        public string Slot1N { get; set; }
        /// <summary>
        /// Slot dodatkowy 2
        /// </summary>
        public string Slot2N { get; set; }
        /// <summary>
        /// Slot dodatkowy 3
        /// </summary>
        public string Slot3N { get; set; }
        /// <summary>
        /// Slot dodatkowy 4
        /// </summary>
        public string Slot4N { get; set; }
        /// <summary>
        /// Slot dodatkowy 5
        /// </summary>
        public string Slot5N { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Zdarzenie { get; set; }
        /// <summary>
        /// Flaga, czy status pochodzi z procesu skanowania
        /// </summary>
        public int? Skan { get; set; }
        /// <summary>
        /// Relacja do użytkownika który skanował - tab: UZYTKOWNIK
        /// </summary>
        public int? KtoSkanId { get; set; }
        /// <summary>
        /// Symbol użytwkownika który skanował
        /// </summary>
        public string KtoSkan { get; set; }
        /// <summary>
        /// Flaga, czy status dotyczy uszkodzenia
        /// </summary>
        public int? Uszk { get; set; }
        /// <summary>
        /// Symbol uszkodzenia - tab: SYMBOLE_ANOMALII
        /// </summary>
        public string SymbolUszk { get; set; }
        /// <summary>
        /// Opis uszkodzenia
        /// </summary>
        public string OpisUszk { get; set; }
        /// <summary>
        /// Uzupełniający opis uszkodzenia
        /// </summary>
        public string OpisUszkUzup { get; set; }
        /// <summary>
        /// Ilosć załączników do statusu
        /// </summary>
        public int? Zalaczniki { get; set; }
        /// <summary>
        /// Flaga, czy wyeksport. dane np. SAE (0-nie sprocesowano, 1-tak, 2-nie, bo nie trzeba było, -1-nie, bo był bład)
        /// </summary>
        public int? IsExported { get; set; }
        /// <summary>
        /// Data eksportu pliku
        /// </summary>
        public DateTime? IsExportedDt { get; set; }
        /// <summary>
        /// Nazwa utworzonego pliku
        /// </summary>
        public string IsExportedFile { get; set; }
        /// <summary>
        /// Flaga, czy status widoczny poprzez aplikację WWW
        /// </summary>
        public int? Www { get; set; }
        /// <summary>
        /// Flaga, czy status oznacza podjecie
        /// </summary>
        public int? Nadanie { get; set; }
        /// <summary>
        /// Flaga, czy status oznacza doręczenie
        /// </summary>
        public int? Doreczenie { get; set; }
        /// <summary>
        /// Typ obiektu nadrzednego np. LL,PZ,WZ
        /// </summary>
        public string NadrzTyp { get; set; }
        /// <summary>
        /// Relacja do obiektu nadrzędnego
        /// </summary>
        public int? NadrzId { get; set; }
        /// <summary>
        /// Numer obiektu nadrzędnego
        /// </summary>
        public string NadrzNr { get; set; }
        /// <summary>
        /// Zdarzenie nadrz np. ZA,WY,IN,PZ,WZ,MM
        /// </summary>
        public string NadrzZdarz { get; set; }
        /// <summary>
        /// Relacja do przewozu - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListyLinioweId { get; set; }
        /// <summary>
        /// SFM Srv: 0-oczekuje, 1-zrobione
        /// </summary>
        public int? SfmSrvState { get; set; }
        /// <summary>
        /// Flaga, czy status jest zgodny z procesem
        /// </summary>
        public int? Niezgodny { get; set; }
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
        /// Flaga, czy status dotyczy opakowania
        /// </summary>
        public short? DotOpakowan { get; set; }
        /// <summary>
        /// Jakiej ilośc dotyczy status, 0 - domyślnie - oznacza WSZYSTKIE
        /// </summary>
        public double? Ilosc { get; set; }
        /// <summary>
        /// Relcja do statusu - tab: STATUSY
        /// </summary>
        public int? StatusId { get; set; }
        /// <summary>
        /// Kod zdarzenia
        /// </summary>
        public string StatusyZdarz { get; set; }
        /// <summary>
        /// Relacja do dok. mag. - tab: MAGAZYN_ZDARZENIA
        /// </summary>
        public int? MagazynZdarzeniaId { get; set; }
        /// <summary>
        /// Relacja do statusu nadrzędnego
        /// </summary>
        public int? NadrzStatusyId { get; set; }
        public int? EmiState { get; set; }
        public int? WStrefieKlienta { get; set; }
        public double? Lon { get; set; }
        public double? Lat { get; set; }
        public int? OrgStatusId { get; set; }
    }
}
