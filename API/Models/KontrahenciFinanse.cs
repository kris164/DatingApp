using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Finanse kontrahenta w podziale na działy
    /// </summary>
    public partial class KontrahenciFinanse
    {
        public int IdKontrahenciFinanse { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Flaga, czy systemowy
        /// </summary>
        public int Systemowy { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji lub *
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu lub *
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// Waluta rozliczeń z kontrahentem
        /// </summary>
        public string WalutaRozliczen { get; set; }
        /// <summary>
        /// Waluta rozliczeń z kontrahentem - koszty
        /// </summary>
        public string WalutaRozliczenKoszty { get; set; }
        /// <summary>
        /// Waluta rozliczeń z kontrahentem - promy
        /// </summary>
        public string WalutaRozliczenProm { get; set; }
        /// <summary>
        /// Waluta w jakiej podawany jest fracht na zleceniach
        /// </summary>
        public string WalutaFrachtu { get; set; }
        /// <summary>
        /// Waluta w jakiej podawany jest fracht na zleceniach - koszty
        /// </summary>
        public string WalutaFrachtuKoszty { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosci { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosci { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciOd { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: od końca miesiąca wzgl daty z TERMIN_PLATNOSCI_OD
        /// </summary>
        public int? TerminPlatnosciOdKmie { get; set; }
        /// <summary>
        /// Zakup - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosciDost { get; set; }
        /// <summary>
        /// Zakup - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosciDost { get; set; }
        /// <summary>
        /// Zakup - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciDostOd { get; set; }
        /// <summary>
        /// Zakup - Sposób wyliczania daty płatności: od końca miesiąca wzgl daty z TERMIN_PLATNOSCI_DOST_OD
        /// </summary>
        public int? TerminPlatnosciDostOdKmie { get; set; }
        /// <summary>
        /// Sprz. prom - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosciProm { get; set; }
        /// <summary>
        /// Sprz. prom - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosciProm { get; set; }
        /// <summary>
        /// Sprz. prom - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciPromOd { get; set; }
        /// <summary>
        /// Sprz. prom - Sposób wyliczania daty płatności: od końca miesiąca wzgl daty z TERMIN_PLATNOSCI_PROM_OD
        /// </summary>
        public int? TerminPlatnosciPromOdKmie { get; set; }
        /// <summary>
        /// Sprzedaż - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string KursWg { get; set; }
        /// <summary>
        /// Sprzedaż - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? KursZDniaP { get; set; }
        /// <summary>
        /// Sprzedaż - Typ kursy: SR,KU,SP
        /// </summary>
        public string TypKursK { get; set; }
        /// <summary>
        /// Sprzedaż - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? TypTabK { get; set; }
        /// <summary>
        /// Zakup - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string KursWgP { get; set; }
        /// <summary>
        /// Zakup - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? KursZDniaPP { get; set; }
        /// <summary>
        /// Zakup - Typ kursy: SR,KU,SP
        /// </summary>
        public string TypKursP { get; set; }
        /// <summary>
        /// Zakup - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? TypTabP { get; set; }
        /// <summary>
        /// Sprzedaż promów - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string KursWgProm { get; set; }
        /// <summary>
        /// Sprzedaż promów - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? KursZDniaPProm { get; set; }
        /// <summary>
        /// Sprzedaż promów - Typ kursy: SR,KU,SP
        /// </summary>
        public string TypKursProm { get; set; }
        /// <summary>
        /// Sprzedaż promów - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? TypTabProm { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string VKursWg { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? VKursZDniaP { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? VTypTabK { get; set; }
        /// <summary>
        /// Sprzedaż VAT - Typ kursy: SR,KU,SP
        /// </summary>
        public string VTypKursK { get; set; }
        /// <summary>
        /// Zakup VAT - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string VKursWgP { get; set; }
        /// <summary>
        /// Zakup VAT - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? VKursZDniaPP { get; set; }
        /// <summary>
        /// Zakup VAT - Typ kursy: SR,KU,SP
        /// </summary>
        public string VTypKursP { get; set; }
        /// <summary>
        /// Zakup VAT- Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? VTypTabP { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Wg jakiej daty dobierac kurs waluty
        /// </summary>
        public string VKursWgProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Flaga, czy kurs z dnia poprzedzajacego
        /// </summary>
        public int? VKursZDniaPProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Typ tabeli: 0 - NBP, ...
        /// </summary>
        public int? VTypTabProm { get; set; }
        /// <summary>
        /// Sprzedaż promów VAT - Typ kursy: SR,KU,SP
        /// </summary>
        public string VTypKursProm { get; set; }
        public int? MetodaKasowa { get; set; }
        /// <summary>
        /// Relacja do domyślnego konta bankowego do faktur - tab: KONTRAHENCI_KONTA
        /// </summary>
        public int? KontoId { get; set; }
        /// <summary>
        /// Numer domyślnego konta bankowego do faktur
        /// </summary>
        public string Konto { get; set; }
        /// <summary>
        /// Flaga, czy numer domyślnego konta w formacie IBAN
        /// </summary>
        public int? Iban { get; set; }
        /// <summary>
        /// Flaga czy subkonto z generatora
        /// </summary>
        public int? SubGener { get; set; }
        /// <summary>
        /// Osoba odbierająca wydruk faktury
        /// </summary>
        public string WydrukOdebral { get; set; }
        /// <summary>
        /// Domyślna liczba oryginałów faktur
        /// </summary>
        public int? LOrg { get; set; }
        /// <summary>
        /// Domyślna liczba kopii faktur
        /// </summary>
        public int? LKop { get; set; }
        /// <summary>
        /// Flaga, czy płatnik jest odbiorcą faktury
        /// </summary>
        public int? PlatnikOdbFv { get; set; }
        /// <summary>
        /// Relacja do płatnika - tab: KONTRAHENCI
        /// </summary>
        public int? PlatnikId { get; set; }
        /// <summary>
        /// Symbol płatnika
        /// </summary>
        public string Platnik { get; set; }
        /// <summary>
        /// Domyślny język dla wystawianych faktur
        /// </summary>
        public string JezykFaktury { get; set; }
        public DateTime? AutofvStart { get; set; }
        public DateTime? AutofvStop { get; set; }
        public DateTime? AutofvLastrun { get; set; }
        public int? KontrahenciZasadyFvId { get; set; }
        public int? KontrahenciCykleFvId { get; set; }
        /// <summary>
        /// Flaga, czy kontrahent jest zablokowany
        /// </summary>
        public int? Zablokowany { get; set; }
        /// <summary>
        /// Flaga, czy dodawać dodatki paliwowe
        /// </summary>
        public int? DodatkiPaliwowe { get; set; }
        /// <summary>
        /// Flaga, czy dodawać dodatki paliwowe do frachtu
        /// </summary>
        public int? DodatkiPaliwoweDoFr { get; set; }
        public int? AutofvActive { get; set; }
        public int? KontrahenciKryteriumFvId { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślna forma płatności
        /// </summary>
        public string FormaPlatnosciClo { get; set; }
        /// <summary>
        /// Sprzedaż - Domyślny termin płatności
        /// </summary>
        public int? TerminPlatnosciClo { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: 0-od daty wyst, 1-od daty sprzed
        /// </summary>
        public int? TerminPlatnosciCloOd { get; set; }
        /// <summary>
        /// Flaga, czy do spec. FV brac ZA/WY czy NAD/ODB
        /// </summary>
        public int? SpecFvZaWy { get; set; }
        public int? VatWPln { get; set; }
        public int? VatWPlnKoszty { get; set; }
        public int? AutofvGetolder { get; set; }
        public string AutofvEmisja { get; set; }
        /// <summary>
        /// Flaga, dedyk dla RSL
        /// </summary>
        public int? AutofvDataRozlDok { get; set; }
        /// <summary>
        /// Lokalizacja odpowiedzialna lub *
        /// </summary>
        public string LokalizacjaOdp { get; set; }
        public int? SplitPayment { get; set; }
        /// <summary>
        /// Sprzedaż - Sposób wyliczania daty płatności: wg dni roboczych
        /// </summary>
        public int? TerminPlatnosciDniRob { get; set; }
        /// <summary>
        /// Zakup - Sposób wyliczania daty płatności: wg dni roboczych
        /// </summary>
        public int? TerminPlatnosciDostDniRob { get; set; }
        /// <summary>
        /// Sprz. prom - Sposób wyliczania daty płatności: wg dni roboczych
        /// </summary>
        public int? TerminPlatnosciPromDniRob { get; set; }
        public DateTime? DataKontrWykazWl { get; set; }
        public int? WynikKontrWykazWl { get; set; }
        public string RequestId { get; set; }
        public string KodIzbyCelnej { get; set; }
        /// <summary>
        /// Flaga, czy sam płaci dług celny
        /// </summary>
        public int? SamPlaciDlugCelny { get; set; }
    }
}
