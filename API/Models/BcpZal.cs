using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BcpZal
    {
        public int IdZalaczniki { get; set; }
        public string Obiekt { get; set; }
        public string ObiektIdFldName { get; set; }
        public int? ObiektId { get; set; }
        public int? Obiekt2Id { get; set; }
        public string Rodzaj { get; set; }
        public int? Status { get; set; }
        public string OrgKatalog { get; set; }
        public string OrgNazwaPliku { get; set; }
        public string WewnKatalog { get; set; }
        public string WewnNazwaPliku { get; set; }
        public string Rozszezenie { get; set; }
        public string Opis { get; set; }
        public string Uzytkownik { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Godz { get; set; }
        public int? Edycja { get; set; }
        public int? Http { get; set; }
        public string HttpAdres { get; set; }
        public int? IsExported { get; set; }
        public DateTime? IsExportedDt { get; set; }
        public DateTime? ExtScanDt { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string CrFormatka { get; set; }
        public DateTime? DtModify { get; set; }
        public string NrPudla { get; set; }
        public int? Filelocation { get; set; }
    }
}
