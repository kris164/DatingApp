using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje cennika SQL
    /// </summary>
    public partial class CennikiSqlPoz
    {
        public int IdCennikiSqlPoz { get; set; }
        /// <summary>
        /// Relacja do nagłówka definicji - tab: CENNIKI_SQL
        /// </summary>
        public int? IdCennikiSql { get; set; }
        /// <summary>
        /// Nazwa pozycji
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Nazwa tabeli w bazie
        /// </summary>
        public string TabelaSql { get; set; }
        /// <summary>
        /// Plik XLS
        /// </summary>
        public byte[] Xls { get; set; }
        /// <summary>
        /// Definicja kolumn
        /// </summary>
        public byte[] Kolumny { get; set; }
        /// <summary>
        /// Definicja wierszy
        /// </summary>
        public byte[] Wiersze { get; set; }
        public string Tabela { get; set; }
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
