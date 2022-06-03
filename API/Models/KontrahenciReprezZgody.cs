using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Zgody marketingowe na PRACOWNIKACH
    /// </summary>
    public partial class KontrahenciReprezZgody
    {
        public int IdKontrahenciReprezZgody { get; set; }
        /// <summary>
        /// Relacja do pracownika - tab: KONTRAHENCI_REPREZ
        /// </summary>
        public int KontrahReprezId { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        public int? ZgodaTypId { get; set; }
        public int? Jest { get; set; }
        public DateTime? Data { get; set; }
        public int? GdprSourceId { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
