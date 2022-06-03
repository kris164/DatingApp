using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class FakturyWzorce
    {
        public int IdFakturyWzorce { get; set; }
        public int? FrmId { get; set; }
        public string NazwaWzorca { get; set; }
        public string RodzFvOtrz { get; set; }
        public string RodzKosztow { get; set; }
        public string RodzKosztowExt { get; set; }
        public int? UwzglRozlKier { get; set; }
        public int? StrRozlKier { get; set; }
        public string TypKosztow { get; set; }
        public string KrajKosztow { get; set; }
        public int KontrahId { get; set; }
        public string KontrahSymbol { get; set; }
        public string KontrahNazwa { get; set; }
        public string KontrahAdres { get; set; }
        public string KontrahMiasto { get; set; }
        public string KontrahKod { get; set; }
        public string KontrahKraj { get; set; }
        public string KontrahNip { get; set; }
        public int? OddzialId { get; set; }
        public string OddzialNazwa { get; set; }
        public string OddzialAdres { get; set; }
        public string OddzialMiasto { get; set; }
        public string OddzialKod { get; set; }
        public string OddzialKraj { get; set; }
        public string FormaPlatnosci { get; set; }
        public int? ZaplGot { get; set; }
        public int TerminPlatnosci { get; set; }
        public int? PlatnikId { get; set; }
        public string Platnik { get; set; }
        public double? NettoPln { get; set; }
        public double? VatPln { get; set; }
        public double? BruttoPln { get; set; }
        public double NettoRazem { get; set; }
        public double PodatekRazem { get; set; }
        public double BruttoRazem { get; set; }
        public string Uwagi { get; set; }
        public int FakturaWalutowa { get; set; }
        public string Waluta { get; set; }
        public int? RozneKursy { get; set; }
        public int? KursyWalutId { get; set; }
        public int? KursyWalutTyp { get; set; }
        public string KursyWalutRodz { get; set; }
        public double KursWaluty { get; set; }
        public string NrTabeliKursow { get; set; }
        public DateTime? DataTabeliKursow { get; set; }
        public int? VKursyWalutId { get; set; }
        public int? VKursyWalutTyp { get; set; }
        public string VKursyWalutRodz { get; set; }
        public double? VKursWaluty { get; set; }
        public string VNrTabeliKursow { get; set; }
        public DateTime? VDataTabeliKursow { get; set; }
        public int? ImpUslug { get; set; }
        public int? ImpTowarow { get; set; }
        public int? KontoId { get; set; }
        public string Konto { get; set; }
        public int? Iban { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
        public string KontoFk { get; set; }
        public string KontoFkMa { get; set; }
        public string Mpk { get; set; }
        public int? EmisjaDoFk { get; set; }
        public int? GotowaDoFk { get; set; }
        public int? PomijajNaRap { get; set; }
        public int? TankDoPelna { get; set; }
        public string InfoOpiekuna { get; set; }
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
        public string DotLokalizacji { get; set; }
        /// <summary>
        /// Znacznik, czy koszt międzyokresowy
        /// </summary>
        public int? KosztyMo { get; set; }
        public int? VatWPln { get; set; }
    }
}
