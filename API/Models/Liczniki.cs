using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Liczniki systemowe
    /// </summary>
    public partial class Liczniki
    {
        /// <summary>
        /// Systemowy identyfikator licznika
        /// </summary>
        public int IdLicznika { get; set; }
        public int IdLiczniki { get; set; }
        /// <summary>
        /// Na który rok
        /// </summary>
        public int? NaRok { get; set; }
        /// <summary>
        /// Na którą lokalizację
        /// </summary>
        public string NaLokalizacje { get; set; }
        /// <summary>
        /// Prefix - używane w formacie licznika
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// Wartość licznika (ma sens gdy LICZ_MIES = 0)
        /// </summary>
        public int Licznik { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int Rok { get; set; }
        /// <summary>
        /// *pole nie używane*
        /// </summary>
        public int? Miesiac { get; set; }
        /// <summary>
        /// Postfix - używane w formacie licznika
        /// </summary>
        public string Postfix { get; set; }
        /// <summary>
        /// Format licznika
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// Opis licznika
        /// </summary>
        public string Opis { get; set; }
        /// <summary>
        /// Flaga, czy stałą długość części liczbowej
        /// </summary>
        public short? StalaDlugLicz { get; set; }
        /// <summary>
        /// Ilość cyfr w części liczbowej (ma sens gdy STALA_DLUG_LICZ = 1)
        /// </summary>
        public short? IloscCyfr { get; set; }
        /// <summary>
        /// Flaga, czy licznik miesięczny
        /// </summary>
        public short LiczMies { get; set; }
        /// <summary>
        /// Flaga, czy licznik posiada podliczniki
        /// </summary>
        public short Podliczniki { get; set; }
        /// <summary>
        /// Wartość licznika dla mies I (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? I { get; set; }
        /// <summary>
        /// Wartość licznika dla mies II (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Ii { get; set; }
        /// <summary>
        /// Wartość licznika dla mies III (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Iii { get; set; }
        /// <summary>
        /// Wartość licznika dla mies IV (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Iv { get; set; }
        /// <summary>
        /// Wartość licznika dla mies V (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? V { get; set; }
        /// <summary>
        /// Wartość licznika dla mies VI (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Vi { get; set; }
        /// <summary>
        /// Wartość licznika dla mies VII (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Vii { get; set; }
        /// <summary>
        /// Wartość licznika dla mies VIII (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Viii { get; set; }
        /// <summary>
        /// Wartość licznika dla mies IX (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Ix { get; set; }
        /// <summary>
        /// Wartość licznika dla mies X (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? X { get; set; }
        /// <summary>
        /// Wartość licznika dla mies XI (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Xi { get; set; }
        /// <summary>
        /// Wartość licznika dla mies XII (ma sens gdy LICZ_MIES = 1)
        /// </summary>
        public int? Xii { get; set; }
        /// <summary>
        /// Flaga, czy aktywne zamykanie okresów dla licznika
        /// </summary>
        public short? ZamykanieOkr { get; set; }
        /// <summary>
        /// Na który dział
        /// </summary>
        public string NaDzial { get; set; }
        /// <summary>
        /// Procedura POST
        /// </summary>
        public string ProceduraSql { get; set; }
        /// <summary>
        /// Delta zmiany licznika
        /// </summary>
        public int Delta { get; set; }
        /// <summary>
        /// Czy właczona ind. obsługa kontroli zamk. okresu
        /// </summary>
        public short ZamykanieOkrInd { get; set; }
    }
}
