using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class ObjWzorzec
    {
        public int IdObjWzorzec { get; set; }
        /// <summary>
        /// funkcja - kontekst wykorzystania wzorca
        /// </summary>
        public string Funkcja { get; set; }
        /// <summary>
        /// dodatkowy wyróżnik w obrębie funkcji
        /// </summary>
        public string Wyroznik { get; set; }
        /// <summary>
        /// ID obiektu SPEED
        /// </summary>
        public int IdObj { get; set; }
        /// <summary>
        /// tabela główna obiektu - klucze typu {@pole}
        /// </summary>
        public string Tabela { get; set; }
        /// <summary>
        /// czas utworzenia wzorca
        /// </summary>
        public DateTime? DtCreate { get; set; }
        /// <summary>
        /// czas ostatniej modyfikacji wzorca
        /// </summary>
        public DateTime? DtModify { get; set; }
        /// <summary>
        /// opis wzorca
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// definicja wzorca tekstu
        /// </summary>
        public string Definicja { get; set; }
        /// <summary>
        /// definicje parametrów dodatkowych
        /// </summary>
        public string Parametry { get; set; }
        /// <summary>
        /// 0/1 - użyj SQL, generuj listę ID obiektów
        /// </summary>
        public short? Uzyjsql { get; set; }
        /// <summary>
        /// SQL - generator listy ID obiektów
        /// </summary>
        public string Sql { get; set; }
        /// <summary>
        /// SQL - dodatkowe źródło kluczy typu {$pole}
        /// </summary>
        public string SqlKlucze { get; set; }
        /// <summary>
        /// ID obiektu SPEED nadrzędnego do ID_Obj
        /// </summary>
        public int IdMasterObj { get; set; }
        /// <summary>
        /// wyróżnik grupy wzorców
        /// </summary>
        public string Grupa { get; set; }
    }
}
