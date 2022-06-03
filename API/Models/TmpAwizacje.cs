using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpAwizacje
    {
        public int IdTmpAwizacje { get; set; }
        public int? IdSesjiKalk { get; set; }
        public string NrAwizacji { get; set; }
        public int? NrAwizacjiKolejny { get; set; }
        public int? NrAwizacjiRok { get; set; }
        public int? NrAwizacjiMies { get; set; }
        public DateTime? Data { get; set; }
        public int? ObjId { get; set; }
        public int? RecId { get; set; }
        public double? Waga { get; set; }
        public double? Obj { get; set; }
        public double? Ilosc { get; set; }
        public double? IloscPrzesylek { get; set; }
        public double? MiejscaPal { get; set; }
        public double? IloscPal { get; set; }
        public double? IloscPac { get; set; }
        public string Uwagi { get; set; }
        public int? PrzewoznikId { get; set; }
        public string Przewoznik { get; set; }
        public int? SamochodId { get; set; }
        public string Samochod { get; set; }
        public int? NaczepaId { get; set; }
        public string Naczepa { get; set; }
        public int? KierowcaId { get; set; }
        public string Kierowca { get; set; }
        public string KierowcaTel { get; set; }
        public int? MiejsceDostawyId { get; set; }
        public int? ListyLinioweZaWyId { get; set; }
        public int? OdbiorcaId { get; set; }
        public string Odbiorca { get; set; }
        public DateTime? DataDostawyOd { get; set; }
        public DateTime? DataDostawyDo { get; set; }
        public string Stan { get; set; }
        public string Status { get; set; }
        public string StatusMail { get; set; }
        public string StatusEmisja { get; set; }
        public int? Zalaczniki { get; set; }
        public string Lokalizacja { get; set; }
        public string Dzial { get; set; }
    }
}
