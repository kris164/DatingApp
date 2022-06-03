using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Przekierowanium
    {
        public int IdPrzekierowania { get; set; }
        /// <summary>
        /// ID użytkownika
        /// </summary>
        public int IdUzytk { get; set; }
        /// <summary>
        /// nazwa użytkownika
        /// </summary>
        public string Uzytk { get; set; }
        /// <summary>
        /// docelowy numer telefonu
        /// </summary>
        public string Telefon { get; set; }
        /// <summary>
        /// 0-wył./ 1-włączony
        /// </summary>
        public short Aktywne { get; set; }
        /// <summary>
        /// 0-wszyscy/ 1-lista/ 2-moje pojazdy + lista
        /// </summary>
        public short? Status { get; set; }
        /// <summary>
        /// opis przekierowania
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// aktywne od godz.
        /// </summary>
        public DateTime? Godzod { get; set; }
        /// <summary>
        /// do godz.
        /// </summary>
        public DateTime? Godzdo { get; set; }
        /// <summary>
        /// 0/1 - włącza dodatkowy filtr wiadomości
        /// </summary>
        public short? Filtruj { get; set; }
        /// <summary>
        /// docelowy adres e-mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 0/1 - wyślij SMS
        /// </summary>
        public short? Sms { get; set; }
        /// <summary>
        /// 0/1 - wyślij e-mail
        /// </summary>
        public short? Eml { get; set; }
        /// <summary>
        /// 0/1 - w dni wolne od pracy aktywne przez 24 godz
        /// </summary>
        public short? Dniwolne24 { get; set; }
    }
}
