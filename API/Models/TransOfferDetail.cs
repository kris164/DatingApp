using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TransOfferDetail
    {
        public int IdTransOfferDetails { get; set; }
        /// <summary>
        /// Id of offer
        /// </summary>
        public int? OfferId { get; set; }
        /// <summary>
        /// lp of offer detail
        /// </summary>
        public int? Lp { get; set; }
        /// <summary>
        /// Current status of offer
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// Date and time of creating the offer
        /// </summary>
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Name of the user who create an offer detail
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Valid to
        /// </summary>
        public DateTime? ValidTo { get; set; }
        /// <summary>
        /// comment Description
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Currency of received offer
        /// </summary>
        public string PriceCurrency { get; set; }
        /// <summary>
        /// Price value
        /// </summary>
        public double? PriceValue { get; set; }
        public string IsShipper { get; set; }
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
    }
}
