using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Obiekty pozycji książki pocztowej przychodzącej
    /// </summary>
    public partial class KsiazkaPocztowaOtrzPoz
    {
        public int IdKsiazkaPocztowaOtrzPoz { get; set; }
        /// <summary>
        /// Relacja do nagłówka książki - tab: KSIAZKA_POCZTOWA_OTRZ
        /// </summary>
        public int? KsiazkaPocztowaOtrzId { get; set; }
        /// <summary>
        /// Typ obiektu - tab: KS_POCZT_DOKUM
        /// </summary>
        public string ObiektTyp { get; set; }
        /// <summary>
        /// Systemowy ID obiektu
        /// </summary>
        public int? ObiektId { get; set; }
        /// <summary>
        /// Systemowy numer obiektu
        /// </summary>
        public string Obiekt { get; set; }
        /// <summary>
        /// Numer segregatora
        /// </summary>
        public string Segregator { get; set; }
        /// <summary>
        /// Relacja do nadawcy - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Kod kreskowy pozycji
        /// </summary>
        public string KodKreskowy { get; set; }
    }
}
