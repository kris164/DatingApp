using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ObjKluczSql
    {
        public int IdObjKluczSql { get; set; }
        /// <summary>
        /// ID wzorca
        /// </summary>
        public int IdObjWzorzec { get; set; }
        /// <summary>
        /// nazwa klucza
        /// </summary>
        public string Klucz { get; set; }
        /// <summary>
        /// opis klucza
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// przykładowa wartość
        /// </summary>
        public string Wartosc { get; set; }
        /// <summary>
        /// 0/1 - czy generowanie listy
        /// </summary>
        public short Lista { get; set; }
        /// <summary>
        /// separator elementów listy
        /// </summary>
        public string Separator { get; set; }
        /// <summary>
        /// SQL - zapytanie źródła danych
        /// </summary>
        public string Sql { get; set; }
    }
}
