using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Formtext
    {
        public int IdFormtext { get; set; }
        /// <summary>
        /// forma - przeznaczenie wzorca
        /// </summary>
        public string Form { get; set; }
        /// <summary>
        /// rodzaj wzorca dla formy
        /// </summary>
        public string FormType { get; set; }
        /// <summary>
        /// opis wzorca
        /// </summary>
        public string FormDescr { get; set; }
        /// <summary>
        /// kraj
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// wersja językowa
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// czas utworzenia wzorca
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// czas ostatniej modyfikacji wzorca
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// definicja wzorca
        /// </summary>
        public string FormDef { get; set; }
        /// <summary>
        /// temat (max. 254 znaki)
        /// </summary>
        public string FormSubject { get; set; }
        /// <summary>
        /// papeteria/wzór: 0-brak/1-txt/2-html
        /// </summary>
        public short? TemplateType { get; set; }
        /// <summary>
        /// papeteria/wzór - nazwa pliku
        /// </summary>
        public string TemplateFile { get; set; }
        /// <summary>
        /// papeteria/wzór - dane
        /// </summary>
        public string Template { get; set; }
    }
}
