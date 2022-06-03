using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprCategoryProcessingRegister
    {
        public int IdGdprCategoryProcessingRegister { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? AdministerContactDataId { get; set; }
        public string AdministerContactData { get; set; }
        public int? ProcessingCategoryId { get; set; }
        public string ProcessingCategory { get; set; }
        public int? SecurityMeasuresId { get; set; }
        public string SecurityMeasures { get; set; }
        public int? ProcessingTimeId { get; set; }
        public string ProcessingTime { get; set; }
        public int? CoProcessorContactDataId { get; set; }
        public string CoProcessorContactData { get; set; }
        public int? CategoryCoProcessingId { get; set; }
        public string CategoryCoProcessing { get; set; }
        public int? CoAdministerContactDataId { get; set; }
        public string CoAdministerContactData { get; set; }
        public int? CoAdministerRepresentativeContactDataId { get; set; }
        public string CoAdministerRepresentativeContactData { get; set; }
        public int? AdministerInspectorContactDataId { get; set; }
        public string AdministerInspectorContactData { get; set; }
        public int? ThirdCountryTransferId { get; set; }
        public string ThirdCountryTransfer { get; set; }
        public int? ThirdCountryTransferSecurityMeasuresId { get; set; }
        public string ThirdCountryTransferSecurityMeasures { get; set; }
        public int? Canceled { get; set; }
        public string StatusEmisja { get; set; }
        public int? Zalaczniki { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
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
