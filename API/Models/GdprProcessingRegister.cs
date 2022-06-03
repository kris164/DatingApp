using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprProcessingRegister
    {
        public int IdGdprProcessingRegister { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int? ActivityId { get; set; }
        public string Activity { get; set; }
        public int? OrgUnitId { get; set; }
        public string OrgUnit { get; set; }
        public int? PurposeId { get; set; }
        public string Purpose { get; set; }
        public int? CategoryPersonId { get; set; }
        public string CategoryPerson { get; set; }
        public int? CategoryDataId { get; set; }
        public string CategoryData { get; set; }
        public int? LegalBasisId { get; set; }
        public string LegalBasis { get; set; }
        public int? DataSourceId { get; set; }
        public string DataSource { get; set; }
        public int? CategoryDataDeletingDatePlannedId { get; set; }
        public string CategoryDataDeletingDatePlanned { get; set; }
        public int? CoAdministerContactDataId { get; set; }
        public string CoAdministerContactData { get; set; }
        public int? ProcessorDataId { get; set; }
        public string ProcessorData { get; set; }
        public int? CategoryRecipientId { get; set; }
        public string CategoryRecipient { get; set; }
        public int? SoftwareNameId { get; set; }
        public string SoftwareName { get; set; }
        public int? SecurityMeasuresId { get; set; }
        public string SecurityMeasures { get; set; }
        public int? DpiaStorageId { get; set; }
        public string DpiaStorage { get; set; }
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
