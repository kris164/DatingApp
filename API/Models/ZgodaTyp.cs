using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Typy zgody marketingowej na PRACOWNIKACH
    /// </summary>
    public partial class ZgodaTyp
    {
        public int IdZgodaTyp { get; set; }
        /// <summary>
        /// Opis na check boxach np. &quot;Mail&quot; &quot;Tel.&quot; &quot;Mail wła.&quot; &quot;Tel wła.&quot; &quot;Mail part.&quot; &quot;Tel part.&quot;
        /// </summary>
        public string Symbol1 { get; set; }
        /// <summary>
        /// Opis w polu grida np. &quot;M1&quot; &quot;T1&quot; &quot;M2&quot; &quot;T2&quot; &quot;M3&quot; &quot;T3&quot;
        /// </summary>
        public string Symbol2 { get; set; }
        /// <summary>
        /// Opis typu zgody np. dla formularza zgody np.&quot;Zgoda na otrzymywanie informacji marketingowo handlowych od @Firma drogą mailową&quot;
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Kolejność dla chceck box i innych
        /// </summary>
        public int? Lp { get; set; }
        public int? Aktywny { get; set; }
        public int? Systemowy { get; set; }
        /// <summary>
        /// Opis braku w polu grida np. &quot;bM1&quot; &quot;bT1&quot; &quot;bM2&quot; &quot;bT2&quot; &quot;bM3&quot; &quot;bT3&quot;
        /// </summary>
        public string Symbol3 { get; set; }
    }
}
