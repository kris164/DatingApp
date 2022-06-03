using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Paczki drobnicowe - detal do tabeli PRZESYLKI
    /// </summary>
    public partial class Paczki
    {
        public int IdPaczki { get; set; }
        /// <summary>
        /// Relacja do przesyłki - tab: PRZESYLKI
        /// </summary>
        public int? PrzesylkaId { get; set; }
        /// <summary>
        /// Numer przesyłki
        /// </summary>
        public string Przesylka { get; set; }
        /// <summary>
        /// Flaga, czy paczka została załadowana
        /// </summary>
        public int? Zaladowana { get; set; }
        /// <summary>
        /// Lp
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Ilość rzeczywista
        /// </summary>
        public int? Ilosc { get; set; }
        /// <summary>
        /// Numer zewnętrzny paczki
        /// </summary>
        public string NrPaczkiEx { get; set; }
        /// <summary>
        /// Kod kreskowy paczki
        /// </summary>
        public string KodKreskowy { get; set; }
        /// <summary>
        /// Opis towaru
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Symbol opakowania
        /// </summary>
        public string Opakowanie { get; set; }
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
        /// Waga deklarowana
        /// </summary>
        public double? WagaDekl { get; set; }
        /// <summary>
        /// Objętość deklarowana
        /// </summary>
        public double? ObjDekl { get; set; }
        /// <summary>
        /// Waga rzeczywista
        /// </summary>
        public double? Waga { get; set; }
        /// <summary>
        /// Długość rzeczywista
        /// </summary>
        public double? Dlugosc { get; set; }
        /// <summary>
        /// Wysokość rzeczywista
        /// </summary>
        public double? Wysokosc { get; set; }
        /// <summary>
        /// Szerokość rzeczywista
        /// </summary>
        public double? Szerokosc { get; set; }
        /// <summary>
        /// Objętość rzeczywista
        /// </summary>
        public double? Obj { get; set; }
        /// <summary>
        /// Metry ładowne rzeczywiste
        /// </summary>
        public double? MetryLadowne { get; set; }
        /// <summary>
        /// Relacja do przewozu liniowego - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListLiniowyId { get; set; }
        /// <summary>
        /// Ostatni przewóz liniowy
        /// </summary>
        public string ListLiniowy { get; set; }
        /// <summary>
        /// Relacja do przewozu dystryb. - tab: LISTY_LINIOWE
        /// </summary>
        public int? ListLiniowyDystId { get; set; }
        /// <summary>
        /// Ostatni przewóz dystryb.
        /// </summary>
        public string ListLiniowyDyst { get; set; }
        /// <summary>
        /// Ostatni magazyn załadunku
        /// </summary>
        public int? MagazynP { get; set; }
        /// <summary>
        /// Ostatni magazyn rozładunku
        /// </summary>
        public int? MagazynR { get; set; }
        /// <summary>
        /// Ostatni status globalny paczki
        /// </summary>
        public string OstStatus { get; set; }
        /// <summary>
        /// Flaga, czy paczka ma anomalię
        /// </summary>
        public int? Anomalia { get; set; }
        /// <summary>
        /// Opis anomalii
        /// </summary>
        public string AnomaliaOpis { get; set; }
        /// <summary>
        /// Ilość pierwotna
        /// </summary>
        public int? IloscP { get; set; }
        /// <summary>
        /// Waga jednostkowa
        /// </summary>
        public double? WagaJedn { get; set; }
        /// <summary>
        /// Objętość jednostkowa
        /// </summary>
        public double? ObjJedn { get; set; }
        /// <summary>
        /// Waga pierwotna
        /// </summary>
        public double? WagaP { get; set; }
        /// <summary>
        /// Objętość pierwotna
        /// </summary>
        public double? ObjP { get; set; }
        /// <summary>
        /// Metry ładowne pierwotne
        /// </summary>
        public double? MetryLadowneP { get; set; }
        /// <summary>
        /// Miejsca paletowe rzeczywiste
        /// </summary>
        public double? MiejscaPal { get; set; }
        /// <summary>
        /// Miejsca paletowe pierwotne
        /// </summary>
        public double? MiejscaPalP { get; set; }
        /// <summary>
        /// Kod miejsca w magazynie - tab: MIEJSCE
        /// </summary>
        public string MagLokKod { get; set; }
        /// <summary>
        /// Statusy złożenia w magazynie
        /// </summary>
        public int? MagLokStat { get; set; }
        /// <summary>
        /// Kod anomalii
        /// </summary>
        public string AnomaliaKod { get; set; }
        /// <summary>
        /// Kod opakowania
        /// </summary>
        public string KodOpak { get; set; }
        /// <summary>
        /// Metry dłużycowe pierwotne
        /// </summary>
        public double? MetryDluzycaP { get; set; }
        /// <summary>
        /// Metry dłużycowe rzeczywiste
        /// </summary>
        public double? MetryDluzyca { get; set; }
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
        /// Długość deklarowana
        /// </summary>
        public double? DlugoscDekl { get; set; }
        /// <summary>
        /// Wysokość deklarowana
        /// </summary>
        public double? WysokoscDekl { get; set; }
        /// <summary>
        /// Szerokość deklarowana
        /// </summary>
        public double? SzerokoscDekl { get; set; }
        /// <summary>
        /// Metry ładowne deklarowane
        /// </summary>
        public double? MetryLadowneDekl { get; set; }
        /// <summary>
        /// Miejsca paletowe deklarowane
        /// </summary>
        public double? MiejscaPalDekl { get; set; }
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
        /// Flaga, czy opakowanie wymienne
        /// </summary>
        public int? OpakWym { get; set; }
        /// <summary>
        /// Ilość opakowań wymiennych
        /// </summary>
        public double? OpakWymIlosc { get; set; }
        /// <summary>
        /// Numer pozycji na potrzeby IDOC (SAP)
        /// </summary>
        public string IdocPosnr { get; set; }
        /// <summary>
        /// Flaga, czy możliwe piętrowanie
        /// </summary>
        public int? Pietrowanie { get; set; }
        /// <summary>
        /// Lokalizacja poprzednia
        /// </summary>
        public string LokalizacjaPrev { get; set; }
        /// <summary>
        /// Lokalizacja obecna
        /// </summary>
        public string LokalizacjaCurr { get; set; }
        /// <summary>
        /// Lokalizacja następna
        /// </summary>
        public string LokalizacjaNext { get; set; }
        /// <summary>
        /// Paczka zostałą skorygowana
        /// </summary>
        public int? Korekta { get; set; }
        /// <summary>
        /// Korekta paczki oczekuje akceptacji
        /// </summary>
        public int? KorektaDoAkcept { get; set; }
        /// <summary>
        /// Korekta paczki zaakceptowana
        /// </summary>
        public int? KorektaAkcept { get; set; }
        /// <summary>
        /// Korekta paczki zakceptowana dnia
        /// </summary>
        public DateTime? KorektaAkceptData { get; set; }
        /// <summary>
        /// Korekta paczki zakceptowana o godz
        /// </summary>
        public DateTime? KorektaAkceptGodz { get; set; }
        /// <summary>
        /// Kto akceptował
        /// </summary>
        public string KorektaAkceptKto { get; set; }
        /// <summary>
        /// Lokalizacja korygująca
        /// </summary>
        public string KorektaLokalizacja { get; set; }
        /// <summary>
        /// Ilość opakowań wymiennych do rozliczenia
        /// </summary>
        public double? OpakWymDoRozl { get; set; }
        /// <summary>
        /// Relacja do przesyłki, którą zwrócono opakowania
        /// </summary>
        public double? OpakWymPrzesZwrId { get; set; }
        /// <summary>
        /// Metry dłużycowe deklarowane
        /// </summary>
        public double? MetryDluzycaDekl { get; set; }
        /// <summary>
        /// Relacja do paczki skonsolidowanej - pierwotnej
        /// </summary>
        public int? KonsolidacjaPaczkiId { get; set; }
        /// <summary>
        /// Typ paczki: 0 - ładunek, 1 - tylko opak. wymienne
        /// </summary>
        public int? TypPaczki { get; set; }
        /// <summary>
        /// Ilość opakowań na JT
        /// </summary>
        public int? IloscNaJt { get; set; }
        /// <summary>
        /// Waga opakowań
        /// </summary>
        public double? WagaOpak { get; set; }
        /// <summary>
        /// Kod opakowania towaru
        /// </summary>
        public string KodOpakT { get; set; }
        /// <summary>
        /// Symbol opakowania towaru
        /// </summary>
        public string OpakowanieT { get; set; }
        /// <summary>
        /// ADR - Ograniczenia tuneli
        /// </summary>
        public string AdrOgrTunele { get; set; }
        /// <summary>
        /// ADR - Ilosć i rodzaj
        /// </summary>
        public string AdrIloscIRodz { get; set; }
        /// <summary>
        /// ADR - Ilość całkowita
        /// </summary>
        public string AdrIloscCalk { get; set; }
        /// <summary>
        /// *** na potrzeby interfejsów ***
        /// </summary>
        public int? IdPaczkiEx { get; set; }
        /// <summary>
        /// ID opisu towaru
        /// </summary>
        public int? OpisId { get; set; }
        /// <summary>
        /// Opis towaru - dodatkowy
        /// </summary>
        public string OpisDod { get; set; }
        /// <summary>
        /// Waga jednostkowa deklarowana
        /// </summary>
        public double? WagaJednDekl { get; set; }
        /// <summary>
        /// Objętość jednostkowa deklarowana
        /// </summary>
        public double? ObjJednDekl { get; set; }
        /// <summary>
        /// *** na potrzeby wewnętrzne ***
        /// </summary>
        public int? TworzWieleId { get; set; }
        /// <summary>
        /// 0 - bez, 1 - DEKL-&gt;RZ, 2 - RZ -&gt; DEKL
        /// </summary>
        public int? ZasadaDeklRz { get; set; }
        /// <summary>
        /// Pola do aktualizacji
        /// </summary>
        public string ZasadaDeklRzPola { get; set; }
        /// <summary>
        /// Numer zewnętrzny paczki 2
        /// </summary>
        public string NrPaczkiEx2 { get; set; }
        public DateTime? PFaktDataRoz { get; set; }
        public DateTime? PFaktGodzRoz { get; set; }
        public int? PHaccp { get; set; }
        public int? Etykieta { get; set; }
        public int? EtykietaKurier { get; set; }
        public string MagStrefa { get; set; }
        public int? ZwrotDoId { get; set; }
        public DateTime? PFaktDataZal { get; set; }
        public DateTime? PFaktGodzZal { get; set; }
        /// <summary>
        /// Waga kubaturowa
        /// </summary>
        public double? AirWagaKubaturowa { get; set; }
        /// <summary>
        /// Waga obliczeniowa
        /// </summary>
        public double? AirWagaObl { get; set; }
        public int? Pomiar { get; set; }
        /// <summary>
        /// Numer paczki w zewnętrznej sieci kurierskiej
        /// </summary>
        public string KurierRef { get; set; }
        public int? AirPaczkiId { get; set; }
        public string SqlDebugInfo { get; set; }
        public int? EmiState { get; set; }
        public string ZabezpTowaru { get; set; }
        /// <summary>
        /// MP*
        /// </summary>
        public double? MiejscaPalObl { get; set; }
        /// <summary>
        /// Numer zewnętrzny paczki 3
        /// </summary>
        public string NrPaczkiEx3 { get; set; }
        public int? PaczkaNadrzId { get; set; }
        public string SiecZewnRef1 { get; set; }
        public string SiecZewnRef2 { get; set; }
        public int? StosZamknij { get; set; }
        public string Temperatura { get; set; }
        public int? ZaId { get; set; }
        public int? WyId { get; set; }
    }
}
