using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class BoxSettingsHist
    {
        public int IdBoxSettingsHist { get; set; }
        /// <summary>
        /// typ zmiany I-insert /U-update /D-delete
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// data zmiany
        /// </summary>
        public DateTime ActionDt { get; set; }
        /// <summary>
        /// id użytkownika dokonującego zmiany
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// wersja programu
        /// </summary>
        public string AppVersion { get; set; }
        /// <summary>
        /// id głównych ustawień dla kontrolki
        /// </summary>
        public int IdBoxSettings { get; set; }
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
        /// nazwa tabeli w bazie danych
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// nazwa pola w tabeli bazy danych
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// typ pola (wartości jak w TFieldType)
        /// </summary>
        public short? FieldType { get; set; }
        /// <summary>
        /// wartości &quot;0.00&quot;, &quot;00:00&quot; traktuj jako puste
        /// </summary>
        public byte? ZeroEqEmpty { get; set; }
        /// <summary>
        /// wartość maksymalna
        /// </summary>
        public string ValueMin { get; set; }
        /// <summary>
        /// wartość minimalna
        /// </summary>
        public string ValueMax { get; set; }
        /// <summary>
        /// 0-default /1-normal /2-upper /3-lower
        /// </summary>
        public short? CharCase { get; set; }
        /// <summary>
        /// zapytanie do walidacji edytowanej wartości
        /// </summary>
        public string ValidSql { get; set; }
        /// <summary>
        /// powód zmiany / informacje dodatkowe
        /// </summary>
        public string Notes { get; set; }
    }
}
