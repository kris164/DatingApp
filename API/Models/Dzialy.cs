using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Działy systemowe
    /// </summary>
    public partial class Dzialy
    {
        public int IdDzialy { get; set; }
        /// <summary>
        /// Kod działu
        /// </summary>
        public string Kod { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Symbol używany w formacie numeracji w licznikach
        /// </summary>
        public string SymbolDoNumeracji { get; set; }
        /// <summary>
        /// Symbol używany w interfejsach do FK
        /// </summary>
        public string SymbolDoFk { get; set; }
        /// <summary>
        /// Dodatkowy symbol używany w interfejsach
        /// </summary>
        public string SymbolDod1 { get; set; }
        /// <summary>
        /// Dodatkowy symbol używany w interfejsach
        /// </summary>
        public string SymbolDod2 { get; set; }
        /// <summary>
        /// Dodatkowy symbol używany w interfejsach
        /// </summary>
        public string SymbolDod3 { get; set; }
        /// <summary>
        /// Symbol lokalizacji w sieci dystrybucyjnej
        /// </summary>
        public string SymbolWSieci { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na zlec. spedycyjne - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaSp { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na zlec. spedycyjne - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaSpP { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na zlec. transportowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaTr { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na zlec. transportowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaTrP { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na zlec. drobnicowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaDr { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na zlec. drobnicowe - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaDrP { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń przewoźnika na trasę drobnicową - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaLl { get; set; }
        /// <summary>
        /// Relacja do tekstu ustaleń klienta na trasę drobnicową - tab: TEKSTY_DO_WYDRUKOW
        /// </summary>
        public string UstaleniaLlZlec { get; set; }
        /// <summary>
        /// Flaga aktywnosci - IMPORT
        /// </summary>
        public int? Import { get; set; }
        /// <summary>
        /// Flaga aktywnosci - EKSPORT
        /// </summary>
        public int? Eksport { get; set; }
        /// <summary>
        /// Flaga aktywnosci - KRAJ
        /// </summary>
        public int? Kraj { get; set; }
        /// <summary>
        /// Domyślny opis ładunku paczki
        /// </summary>
        public int? DroDefOpisLadId { get; set; }
        /// <summary>
        /// Domyślnie pobieraj przeliczniki dla drobnicy z... 0 - globalne, 1 - kontrahent, 2 - partner
        /// </summary>
        public int? DroPrzelicznikiZ { get; set; }
        /// <summary>
        /// Domyślnie ustaw algorytm wagi oblicz. (-1 - wyłaczone)
        /// </summary>
        public int? DroAlgWagObl { get; set; }
        /// <summary>
        /// Wyłacz kontrole dopuszczalnych opakowań
        /// </summary>
        public int? BezKontrDopOpak { get; set; }
        /// <summary>
        /// Flaga, czy lokalizacja jest aktywny
        /// </summary>
        public int? Aktywny { get; set; }
        /// <summary>
        /// Relacja do lokalizacji nadrzędnej - tab: DZIALY
        /// </summary>
        public int? DzialNadrzId { get; set; }
        /// <summary>
        /// Kod działu nadrzędnego
        /// </summary>
        public string DzialNadrz { get; set; }
    }
}
