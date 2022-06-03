using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TTacho
    {
        public int IdTacho { get; set; }
        public int IdFirma { get; set; }
        public DateTime Data { get; set; }
        public int IdKierowcy { get; set; }
        public int IdTaboru { get; set; }
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
    }
}
