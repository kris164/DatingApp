using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmPosTro
    {
        public int IdSfmPos { get; set; }
        /// <summary>
        /// ID systemu w bazie SFM
        /// </summary>
        public int? IdSfmSystem { get; set; }
        /// <summary>
        /// TRO - identyfikacja Dallas
        /// </summary>
        public int? Idd { get; set; }
        /// <summary>
        /// TRO - identyfikator sterownika
        /// </summary>
        public int? Ident { get; set; }
        /// <summary>
        /// TRO - numer seryjny sterownika
        /// </summary>
        public int? DevSn { get; set; }
        /// <summary>
        /// TRO - ilość widzianych satelit
        /// </summary>
        public short? Satelity { get; set; }
        /// <summary>
        /// TRO - dane pomocnicze
        /// </summary>
        public int? Pomoc { get; set; }
        /// <summary>
        /// TRO - wejście cyfrowe
        /// </summary>
        public int? Cyfrwe { get; set; }
        /// <summary>
        /// TRO - wyjście cyfrowe
        /// </summary>
        public int? Cyfrwy { get; set; }
        /// <summary>
        /// TRO - Ślad aktywacji (dla CyfrWE)
        /// </summary>
        public int? Cyfrak { get; set; }
        /// <summary>
        /// TRO - (Atrax77) dane rozszerzeń (16 bajtów)
        /// </summary>
        public string Extax { get; set; }
        /// <summary>
        /// TRO - (Atrax77) temperatura1
        /// </summary>
        public short? Tmp1 { get; set; }
        /// <summary>
        /// TRO - (Atrax77) temperatura2
        /// </summary>
        public short? Tmp2 { get; set; }
        /// <summary>
        /// TRO - napięcie główne [V*10]
        /// </summary>
        public short? VGl { get; set; }
        /// <summary>
        /// TRO - napięcie rezerwowe [V*10]
        /// </summary>
        public short? VRez { get; set; }
        /// <summary>
        /// TRO - paliwo całkowite [L*10]
        /// </summary>
        public int? Paliwo { get; set; }
        /// <summary>
        /// TRO - skok paliwa (-/0-brak/1-tank/2-ubytek)
        /// </summary>
        public short? Skokpaliwa { get; set; }
    }
}
