using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GdprOblivionPo
    {
        public int IdGdprOblivionPos { get; set; }
        public int GdprOblivionId { get; set; }
        /// <summary>
        /// Typ obiektu do zatarcia np. 1 - przesylka, 2 zlecenie
        /// </summary>
        public int? ObjId { get; set; }
        /// <summary>
        /// Id obiektu - np. id przesylki
        /// </summary>
        public int? RecId { get; set; }
        /// <summary>
        /// Typ podelementu np. NADAWCA, ODBIORCA, MIEJSCE_WY na przesyłce.
        /// </summary>
        public int? SubObjId { get; set; }
        /// <summary>
        /// Jeśli zacieramy dane i one są onalezione w słowniku np. KONTRAH_REPREZ to tu wstawiamy id obiketu - pracownik, kierowca etc.
        /// </summary>
        public int? SubjectObjId { get; set; }
        /// <summary>
        /// Id rekordu w tym słowniku
        /// </summary>
        public int? SubjectRecId { get; set; }
        /// <summary>
        /// Tu ustawimy typ obiektu który utworzymy w pomocniczej tabeli GPRS - obraz rekordy z tabeli operacyjnej
        /// </summary>
        public int? GdprSubjectObjId { get; set; }
        /// <summary>
        /// Tu wprowadzani id rekordu w tej tabeli pomocniczej GDPR (kopia z operacyjnej lub założenie rekordu w tym słowniku jeśli nie było go w operacyjnej
        /// </summary>
        public int? GdprSubjectRecId { get; set; }
        /// <summary>
        /// Pozycja oznaczona jako anulowana - będzie usunięta -  nie będzie podlegała obróbce przez ZAMAZANIE
        /// </summary>
        public int? Canceled { get; set; }
        public string ObjTable { get; set; }
        public DateTime? RecDate { get; set; }
        public string RecReference { get; set; }
        public string RecInfo { get; set; }
        public int? RecDataLp { get; set; }
        public int? GdprSubjectRecLp { get; set; }
        public int? GdprPersonsId { get; set; }
        public int? OrgIdGdprOblivionPos { get; set; }
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
