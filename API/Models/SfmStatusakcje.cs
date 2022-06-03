using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmStatusakcje
    {
        public int IdSfmStatusakcje { get; set; }
        /// <summary>
        /// numer statusu SFM
        /// </summary>
        public int? NrStat { get; set; }
        /// <summary>
        /// grupa statusu
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// symbol akcji dla statusu
        /// </summary>
        public string Akcja { get; set; }
        /// <summary>
        /// opis akcji
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// 0/1 dla zlecenia
        /// </summary>
        public short? AkcjaZlec { get; set; }
        /// <summary>
        /// 0/1 dla zdarzeń zlecenia
        /// </summary>
        public short? AkcjaZawy { get; set; }
        /// <summary>
        /// 0/1 dla polecenia wyjazdu
        /// </summary>
        public short? AkcjaPw { get; set; }
        /// <summary>
        /// 0/1 dla taboru
        /// </summary>
        public short? AkcjaTabor { get; set; }
        /// <summary>
        /// 0/1 dla kierowcy 1
        /// </summary>
        public short? AkcjaKier1 { get; set; }
        /// <summary>
        /// 0/1 dla kierowcy 2
        /// </summary>
        public short? AkcjaKier2 { get; set; }
        /// <summary>
        /// 0/1 dla zdarzeń zlec. głównego
        /// </summary>
        public short? AkcjaZawyGl { get; set; }
        /// <summary>
        /// 0/1 dla zdarzeń zlec. nadrzędnego
        /// </summary>
        public short? AkcjaZawyNd { get; set; }
    }
}
