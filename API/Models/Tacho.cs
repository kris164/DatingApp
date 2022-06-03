using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Tacho
    {
        public int IdTacho { get; set; }
        public int IdFirma { get; set; }
        public DateTime Data { get; set; }
        public int IdKierowcy { get; set; }
        public int IdTaboru { get; set; }
        public string Kierowca { get; set; }
        public string Samochod { get; set; }
        public int Zatwierdzony { get; set; }
        public int? SrodekX { get; set; }
        public int? SrodekY { get; set; }
        public string Odchylenie { get; set; }
        public int? KmKoncowe { get; set; }
        public int? KmPoczatkowe { get; set; }
        public double? CzasRozpoczecia { get; set; }
        public string Adnotacje { get; set; }
        public double? CzasJazdy { get; set; }
        public double? CzasPracy { get; set; }
        public double? CzasDyzuru { get; set; }
        public double? CzasPostoju { get; set; }
        public double? AllKm { get; set; }
        public short? Error1 { get; set; }
        public short? Error2 { get; set; }
        public short? Error3 { get; set; }
        public short? Error4 { get; set; }
        public short? Zespolowa { get; set; }
        public short? Zaswiadczenie { get; set; }
        public short? Cyfrowe { get; set; }
        public DateTime? CzasOd { get; set; }
        public DateTime? DataDo { get; set; }
        public DateTime? CzasDo { get; set; }
        public string KodNieobecnosci { get; set; }
        public byte[] Skan { get; set; }
        public int? SourceSkan { get; set; }
        public int? CreateIdUser { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ModifyIdUser { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? DrogaPik1 { get; set; }
        public int? DrogaPik2 { get; set; }
        public short? IsReczna { get; set; }
        public int? ToRcpIdUser { get; set; }
        public DateTime? ToRcpDatetime { get; set; }
        public short? Korekta { get; set; }
        public DateTime? KorektaDt { get; set; }
        public int? KorektaUserId { get; set; }
        public DateTime? DataOtrzymania { get; set; }
    }
}
