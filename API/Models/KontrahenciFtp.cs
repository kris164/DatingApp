using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje FTP dla kontrahentów
    /// </summary>
    public partial class KontrahenciFtp
    {
        public int IdKontrahenciFtp { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int KontrahId { get; set; }
        /// <summary>
        /// Adres serwera FTP
        /// </summary>
        public string Serwer { get; set; }
        /// <summary>
        /// Użytkownik
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Hasło
        /// </summary>
        public string Haslo { get; set; }
        /// <summary>
        /// Port
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Katalog do pobierania
        /// </summary>
        public string DirIn { get; set; }
        /// <summary>
        /// Katalog do wysyłania
        /// </summary>
        public string DirOut { get; set; }
    }
}
