using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KontrahenciMaxDlug
    {
        public int IdKontrahenciMaxDlug { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int OddzialWlasnyId { get; set; }
        /// <summary>
        /// Kwota maksymalnego zadłużenia przeteminowanego klienta
        /// </summary>
        public double? MaxDlug { get; set; }
        /// <summary>
        /// Waluta maksymalnego zadłużenia przeteminowanego klienta
        /// </summary>
        public string MaxDlugWal { get; set; }
        /// <summary>
        /// Kwota maksymalnego zadłużenia całkowitego klienta
        /// </summary>
        public double? MaxDlugCalk { get; set; }
        /// <summary>
        /// Waluta maksymalnego zadłużenia całkowitego klienta
        /// </summary>
        public string MaxDlugCalkWal { get; set; }
        /// <summary>
        /// Maksymalna ilość dni po terminie
        /// </summary>
        public double? MaxPrzeterm { get; set; }
        /// <summary>
        /// Flaga, czy liczyć zadłużenie również z niezafakturowanych zleceń
        /// </summary>
        public int? MaxDlugZlec { get; set; }
        /// <summary>
        /// Data ważności maksymalnego zadłużenia
        /// </summary>
        public DateTime? MaxDlugWaznosc { get; set; }
        /// <summary>
        /// Kwota ustalonej wpłaty
        /// </summary>
        public double? UstalonaWplata { get; set; }
        /// <summary>
        /// Waluta ustalonej wpłaty
        /// </summary>
        public string UstalonaWplataWal { get; set; }
        /// <summary>
        /// Data ważności ustalonej wpłaty
        /// </summary>
        public DateTime? UstalonaWplataWaznosc { get; set; }
        /// <summary>
        /// Korekta - maksymalna ilość dni po terminie
        /// </summary>
        public double? UstaloneMaxPrzeterm { get; set; }
        /// <summary>
        /// Data ważności korekty max dni
        /// </summary>
        public DateTime? UstaloneMaxPrzetermWaznosc { get; set; }
    }
}
