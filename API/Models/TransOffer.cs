using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TransOffer
    {
        public int IdTransOffers { get; set; }
        /// <summary>
        /// Typ obiektu (LL[List Liniowy], ZL[Zlecenia])
        /// </summary>
        public string ObjType { get; set; }
        /// <summary>
        /// ID obiektu
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// ID rekordu
        /// </summary>
        public int? RecId { get; set; }
        /// <summary>
        /// Id of offer
        /// </summary>
        public int? OfferId { get; set; }
        /// <summary>
        /// Id of freight for which the offers are submitted
        /// </summary>
        public int? FreightId { get; set; }
        /// <summary>
        /// Identifies the company that submitted the offer
        /// </summary>
        public string CompanyId { get; set; }
        /// <summary>
        /// SPEED Name of the company that submitted the offer
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Name of the company that submitted the offer
        /// </summary>
        public string LegalName { get; set; }
        /// <summary>
        /// Date and time of creating the offer
        /// </summary>
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Currency of received offer
        /// </summary>
        public string PriceCurrency { get; set; }
        /// <summary>
        /// Price value
        /// </summary>
        public double? PriceValue { get; set; }
        /// <summary>
        /// Current status of offer
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Version required for replying to the offer
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Identifies employee of the company who submitted the offer
        /// </summary>
        public string TransId { get; set; }
        /// <summary>
        /// Legal (tax) company identifier
        /// </summary>
        public string VatId { get; set; }
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
