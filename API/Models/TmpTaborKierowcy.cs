using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpTaborKierowcy
    {
        public int IdTmpTaborKierowcy { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? Zewnetrzne { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public int? TaborId { get; set; }
        public string NrRej { get; set; }
        public int? TaborNaczepyId { get; set; }
        public string NrRejNaczepy { get; set; }
        public int? KierowcaId { get; set; }
        public string NazwiskoImieKier { get; set; }
        public string NrDokKierowcy { get; set; }
        public int? LpKierowcy { get; set; }
        public DateTime? DataOd { get; set; }
        public DateTime? GodzOd { get; set; }
        public DateTime? DataDo { get; set; }
        public DateTime? GodzDo { get; set; }
        public int? StanLicznikaOd { get; set; }
        public int? StanLicznikaDo { get; set; }
        public int? PaliwoOd { get; set; }
        public int? PaliwoDo { get; set; }
        public int? StanLicznikaMtgOd { get; set; }
        public int? StanLicznikaMtgDo { get; set; }
        public int? PaliwoMtgOd { get; set; }
        public int? PaliwoMtgDo { get; set; }
        public int? AdblueOd { get; set; }
        public int? AdblueDo { get; set; }
        public string InfoDod { get; set; }
        public string WypP { get; set; }
        public string WypZ { get; set; }
        public int? Zalaczniki { get; set; }
        public int? Status { get; set; }
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
