using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje cenniki kontrahenta
    /// </summary>
    public partial class KontrahenciCennikiDef
    {
        public int IdKontrahenciCennikiDef { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Typ cennika [P]rzychów, [K]oszt
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// Dotyczy obiektów typu [P]przesyłki, [Z]zlecenia, [T]tasy, [PR]omy
        /// </summary>
        public string Dotyczy { get; set; }
        /// <summary>
        /// Dotyczy lokalizacji lub *
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Dotyczy działu lub *
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// [N]agłówek przesyłki, pozycja [K]alkulacji
        /// </summary>
        public string Poziom { get; set; }
        /// <summary>
        /// Kierunek [P]odjecia, [D]ostawy, [I]nne
        /// </summary>
        public string Kierunek { get; set; }
        /// <summary>
        /// Marża
        /// </summary>
        public double? Marza { get; set; }
        /// <summary>
        /// Relacja do cennika - dostawa drobnicowa - tab: CENNIKI lub CENNIKI_SQL
        /// </summary>
        public int? CennikId { get; set; }
        /// <summary>
        /// Nazwa cennika/procedury SQL
        /// </summary>
        public string Cennik { get; set; }
        /// <summary>
        /// Dotyczy oddziału klienta lub *
        /// </summary>
        public string Oddzial { get; set; }
        /// <summary>
        /// Oddział ID
        /// </summary>
        public int? OddzialId { get; set; }
    }
}
