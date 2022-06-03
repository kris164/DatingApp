using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik statusów
    /// </summary>
    public partial class Status
    {
        public int IdStatus { get; set; }
        /// <summary>
        /// Typ: FT, DR, LL, OF, PA, SZ, PR, RP, RS, PW
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Lp, dawniej okrślało ważność statusu, teraz po prostu Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Kod statusu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis statusu
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy status systemowy - zdefiniowany przez InterLAN
        /// </summary>
        public int? Systemowy { get; set; }
        /// <summary>
        /// Flaga, czy obiekt z tym statusem ma być tylko do odczytu
        /// </summary>
        public int? TylkoOdczyt { get; set; }
        /// <summary>
        /// Lista symboli użytkowników rozdzielonych średnikami, którzy mogą nadawac dany status
        /// </summary>
        public string KtoMoze { get; set; }
        /// <summary>
        /// Flaga, czy status aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Ważność, hierarchia statusu
        /// </summary>
        public int? Poziom { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public string Nastepniki { get; set; }
        /// <summary>
        /// Flaga, czy propagować statu na przesyłki (tylko dla TYP=LL i ZT)
        /// </summary>
        public int? RowniezNaPrzesylki { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać slot dodatkowy 1
        /// </summary>
        public int? Slot1 { get; set; }
        /// <summary>
        /// Etykieta/znaczenie slotu dodatkowego 1
        /// </summary>
        public string Slot1Nazwa { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać slot dodatkowy 2
        /// </summary>
        public int? Slot2 { get; set; }
        /// <summary>
        /// Etykieta/znaczenie slotu dodatkowego 2
        /// </summary>
        public string Slot2Nazwa { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać slot dodatkowy 3
        /// </summary>
        public int? Slot3 { get; set; }
        /// <summary>
        /// Etykieta/znaczenie slotu dodatkowego 3
        /// </summary>
        public string Slot3Nazwa { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać slot dodatkowy 4
        /// </summary>
        public int? Slot4 { get; set; }
        /// <summary>
        /// Etykieta/znaczenie slotu dodatkowego 4
        /// </summary>
        public string Slot4Nazwa { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać slot dodatkowy 5
        /// </summary>
        public int? Slot5 { get; set; }
        /// <summary>
        /// Etykieta/znaczenie slotu dodatkowego 5
        /// </summary>
        public string Slot5Nazwa { get; set; }
        /// <summary>
        /// Flaga, czy status pochodzi z procesu skanowania
        /// </summary>
        public int? Skan { get; set; }
        /// <summary>
        /// Jaki status na przesyłki ma byc propagowany
        /// </summary>
        public string RowniezNaPrzesylkiJaki { get; set; }
        /// <summary>
        /// Flaga, czy wymagane jest podanie anomalii przy nadawaniu statusu
        /// </summary>
        public int? WymaganaAnomalia { get; set; }
        /// <summary>
        /// Flaga, czy status widoczny poprzez aplikację WWW
        /// </summary>
        public int? Www { get; set; }
        /// <summary>
        /// Flaga, czy status jest podjęciem
        /// </summary>
        public int? Nadanie { get; set; }
        /// <summary>
        /// Flaga, czy status jest doreczeniem
        /// </summary>
        public int? Doreczenie { get; set; }
        /// <summary>
        /// Flaga, czy ma zmapowanie statusu SFM
        /// </summary>
        public int? IsStatusSfm { get; set; }
        /// <summary>
        /// Mapowanie statusu SFM
        /// </summary>
        public int? StatusSfm { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie załadunku/podjęcia
        /// </summary>
        public int? UstawDateZal { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie datę rozładunku/doręczenia
        /// </summary>
        public int? UstawDateRoz { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie datę potwierdzenia
        /// </summary>
        public int? UstawDatePotw { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie ponowne planowanie
        /// </summary>
        public int? UstawPonownePlan { get; set; }
        /// <summary>
        /// Etykieta statusu PL
        /// </summary>
        public string EtykietaPl { get; set; }
        /// <summary>
        /// Etykieta statusu EN
        /// </summary>
        public string EtykietaEn { get; set; }
        /// <summary>
        /// Flaga, czy możliwa jest zmiana daty i godziny statusu
        /// </summary>
        public int? MozliwaZmCzasu { get; set; }
        /// <summary>
        /// ID obiektu: 1-DR, 2_FT, 3-PA, 4-OF, 5-PR, 6-LL, 7-SZ, 8-RP, 9-RS, 10-PW
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie anulowanie
        /// </summary>
        public int? UstawAnulowanie { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie stan rozl. dokumentów
        /// </summary>
        public int? UstawRozlDokum { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie niedoreczenie
        /// </summary>
        public int? UstawNiedoreczone { get; set; }
        /// <summary>
        /// Kolor ramki w gridzie
        /// </summary>
        public int? KolorRamki { get; set; }
        /// <summary>
        /// Kolor tekstu w ramce grida
        /// </summary>
        public int? KolorTekstu { get; set; }
        /// <summary>
        /// Flaga, czy ustawić flage PLANOWANA
        /// </summary>
        public int? DoPlanowania { get; set; }
        /// <summary>
        /// Flaga, czy propagować statu na paczki (tylko dla TYP=DR)
        /// </summary>
        public int? RowniezNaPaczki { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie flage STOP
        /// </summary>
        public int? UstawStop { get; set; }
        /// <summary>
        /// Flaga, czy można anulować przy tym statusie
        /// </summary>
        public int? MoznaAnulowac { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie flage wykonania (tylko dla ZT)
        /// </summary>
        public int? UstawWykonanie { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie kolejność wykonania (tylko dla ZT)
        /// </summary>
        public int? UstawKolWyk { get; set; }
        /// <summary>
        /// Czy i jaki ustawiać status windykacyjny na fakturze
        /// </summary>
        public int? UstawStatusWindFv { get; set; }
        /// <summary>
        /// Flaga, czy ustawić flagę ZAPLANOWANA
        /// </summary>
        public int? DoZaplanowanych { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie niepodjęcie
        /// </summary>
        public int? UstawNiepodjete { get; set; }
        /// <summary>
        /// Czy ustawiać status windykacyjny na fakturze
        /// </summary>
        public int? CzyUstawStatusWindFv { get; set; }
        /// <summary>
        /// Flaga, czy zmienić termin płatnosci na FV, w oparciu o date statusu
        /// </summary>
        public int? UstawTermPlatnFv { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać flage &quot;Bez księgowania&quot;
        /// </summary>
        public int? UstawBezKsiegowania { get; set; }
        /// <summary>
        /// Procedura bazodanowa odpalana po nadaniu statusu
        /// </summary>
        public string ProceduraDb { get; set; }
        /// <summary>
        /// Flaga, czy propagować statu na przes. skonsolidowane (tylko dla TYP=DR)
        /// </summary>
        public int? RowniezNaSkonsolidowane { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać flage &quot;Aktywny&quot;
        /// </summary>
        public int? UstawAktywny { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać flage &quot;Blokada ręczna&quot;
        /// </summary>
        public int? UstawBlokade { get; set; }
        /// <summary>
        /// Tryb statusów - dodatkowy wyróżnik np dla listy zleceń W, ST lub faktur K, P etc
        /// </summary>
        public string Tryb { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać kolor ramki w gridzie
        /// </summary>
        public int? CzyKolorRamki { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać kolor tekstu w ramce grida
        /// </summary>
        public int? CzyKolorTekstu { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie ocenę przewoźnika
        /// </summary>
        public int? UstawOcenePrzew { get; set; }
        /// <summary>
        /// Flaga, czy anulować COD
        /// </summary>
        public int? AnulowanieCod { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie flagę NIE FAKTURUJ
        /// </summary>
        public int? UstawNieFakturuj { get; set; }
        /// <summary>
        /// Flaga, czy status do terminowosci
        /// </summary>
        public int? Terminowosc { get; set; }
        /// <summary>
        /// Flaga, czy wymuszać reczne wprowadzenie daty i godz
        /// </summary>
        public int? MozliwaZmCzasuWymus { get; set; }
        /// <summary>
        /// Flaga, czy wymuszać reczne opisu uzup.
        /// </summary>
        public int? WymOpisUzup { get; set; }
        /// <summary>
        /// Flaga, czy status ma sie pojawiac w powiadomieniach jako wyzwalacz
        /// </summary>
        public int? DotPowiadomien { get; set; }
        /// <summary>
        /// Flaga, czy status ma sie pojawiac w SFM
        /// </summary>
        public int? Sfm { get; set; }
        /// <summary>
        /// Flaga, czy zezwalac na rozbicie kosztó trasy na przesyłki
        /// </summary>
        public int? ZezwNaRktnp { get; set; }
        /// <summary>
        /// Flaga, czy ustawiać na obiekcie stan autofakturowania
        /// </summary>
        public int? UstawStanAutoFv { get; set; }
        /// <summary>
        /// Flaga, czy można ustawic datew przyszłości
        /// </summary>
        public int? MozliwaDataPrzyszla { get; set; }
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
        /// Flaga, czy wyczyscic trasy dla anulowanej przesyłki
        /// </summary>
        public int? CzyscTrasy { get; set; }
        public int? UstawZagrozenie { get; set; }
        /// <summary>
        /// Flaga, czy status widoczny poprzez aplikację MOBILE
        /// </summary>
        public int? Mobile { get; set; }
        public int? UstawSent { get; set; }
        public int? ZamknijTeczke { get; set; }
        /// <summary>
        /// Flaga, czy wymagać podania daty i godz
        /// </summary>
        public int? NieWymagajDt { get; set; }
        /// <summary>
        /// Flaga, czy wykonac akcje na sensorze GPS
        /// </summary>
        public int? MobileGpsSensor { get; set; }
        public int? DictionaryId { get; set; }
        public int? TextId { get; set; }
    }
}
