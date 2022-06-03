using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmStatus
    {
        public int IdSfmStatus { get; set; }
        /// <summary>
        /// numer statusu SFM
        /// </summary>
        public int? NrStat { get; set; }
        /// <summary>
        /// grupa statusu
        /// </summary>
        public string Grupa { get; set; }
        /// <summary>
        /// skrócona nazwa statusu
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// opis statusu
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// 0/1 Daje możliwość wyłączenia obsługi statusu
        /// </summary>
        public short? Aktywny { get; set; }
        /// <summary>
        /// 0/1 dodaj do historii statusów (SFM_StatusHist)
        /// </summary>
        public short? Historia { get; set; }
        /// <summary>
        /// 0/1 wyświetlaj na stronie www
        /// </summary>
        public short? Www { get; set; }
        /// <summary>
        /// akcja dla zlecenia
        /// </summary>
        public string AkcjaZlec { get; set; }
        /// <summary>
        /// akcja dla zdarzeń zlecenia
        /// </summary>
        public string AkcjaZawy { get; set; }
        /// <summary>
        /// akcja dla polecenia wyjazdu
        /// </summary>
        public string AkcjaPw { get; set; }
        /// <summary>
        /// akcja dla taboru
        /// </summary>
        public string AkcjaTabor { get; set; }
        /// <summary>
        /// akcja dla kierowcy 1
        /// </summary>
        public string AkcjaKier1 { get; set; }
        /// <summary>
        /// akcja dla kierowcy 2
        /// </summary>
        public string AkcjaKier2 { get; set; }
        /// <summary>
        /// akcja dla zdarzeń zlec. głównego
        /// </summary>
        public string AkcjaZawyGl { get; set; }
        /// <summary>
        /// akcja dla zdarzeń zlec. nadrzędnego
        /// </summary>
        public string AkcjaZawyNd { get; set; }
        /// <summary>
        /// 0/1 utworz wiadomość typu alert
        /// </summary>
        public short? AlertMsg { get; set; }
        /// <summary>
        /// ID wzorca do utworzenia wiadomości
        /// </summary>
        public int? IdObjWzorzec { get; set; }
        /// <summary>
        /// poziom akcji zlecenia
        /// </summary>
        public int? PoziomZlec { get; set; }
        /// <summary>
        /// poziom akcji zdarzeń zlecenia
        /// </summary>
        public int? PoziomZawy { get; set; }
        /// <summary>
        /// poziom akcji zdarzeń zlec. głównego
        /// </summary>
        public int? PoziomZawyGl { get; set; }
        /// <summary>
        /// poziom akcji zdarzeń zlec. nadrzędnego
        /// </summary>
        public int? PoziomZawyNd { get; set; }
        /// <summary>
        /// poziom akcji polecenia wyjazdu
        /// </summary>
        public int? PoziomPw { get; set; }
        /// <summary>
        /// poziom akcji taboru
        /// </summary>
        public int? PoziomTabor { get; set; }
        /// <summary>
        /// poziom akcji kierowcy 1
        /// </summary>
        public int? PoziomKier1 { get; set; }
        /// <summary>
        /// poziom akcji kierowcy 2
        /// </summary>
        public int? PoziomKier2 { get; set; }
        /// <summary>
        /// 0/1 generuj alert gdy błędny czas statusu (SFM_Msg)
        /// </summary>
        public short? Alertdaty { get; set; }
        /// <summary>
        /// 0/1 nanieś status SPEED na rekord zlecenia
        /// </summary>
        public short? Nadajstatspeed { get; set; }
    }
}
