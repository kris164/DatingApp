using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Boxsetting
    {
        public int IdBoxsettings { get; set; }
        /// <summary>
        /// klasa okna
        /// </summary>
        public string BoxClass { get; set; }
        /// <summary>
        /// nazwa okna
        /// </summary>
        public string BoxName { get; set; }
        /// <summary>
        /// typ okna
        /// </summary>
        public string BoxType { get; set; }
        /// <summary>
        /// opis okna
        /// </summary>
        public string BoxDesc { get; set; }
        /// <summary>
        /// klasa kontrolki
        /// </summary>
        public string CtrlClass { get; set; }
        /// <summary>
        /// nazwa kontrolki
        /// </summary>
        public string CtrlName { get; set; }
        /// <summary>
        /// opis kontrolki
        /// </summary>
        public string CtrlDesc { get; set; }
        /// <summary>
        /// nazwa pola w tabeli bazy danych
        /// </summary>
        public string Fieldname { get; set; }
        /// <summary>
        /// nazwa tabeli w bazie danych
        /// </summary>
        public string Tablename { get; set; }
        /// <summary>
        /// wartości &quot;0.00&quot;, &quot;00:00&quot; traktuj jako puste
        /// </summary>
        public short? ZeroEqEmpty { get; set; }
        /// <summary>
        /// typ pola (wartości jak w TFieldType)
        /// </summary>
        public short? Fieldtype { get; set; }
        /// <summary>
        /// wartość maksymalna
        /// </summary>
        public string Valuemin { get; set; }
        /// <summary>
        /// wartość minimalna
        /// </summary>
        public string Valuemax { get; set; }
        /// <summary>
        /// 0-default /1-normal /2-upper /3-lower
        /// </summary>
        public short? Charcase { get; set; }
        /// <summary>
        /// zapytanie do walidacji edytowanej wartości
        /// </summary>
        public string Validsql { get; set; }
        /// <summary>
        /// powód zmiany / informacje dodatkowe
        /// </summary>
        public string Notes { get; set; }
    }
}
