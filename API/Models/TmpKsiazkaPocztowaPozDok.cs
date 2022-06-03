using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpKsiazkaPocztowaPozDok
    {
        public int IdTmpKsiazkaPocztowaPozDok { get; set; }
        public int? IdSesjiKalk { get; set; }
        public int? IdKsiazkaPocztowaPozDok { get; set; }
        /// <summary>
        /// Relacja do nagłówka książki - tab: KSIAZKA_POCZTOWA_POZ
        /// </summary>
        public int? KsiazkaPocztowaPozId { get; set; }
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
