using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Liczniki indywidualne dla kontrahenta
    /// </summary>
    public partial class KontrahenciLiczniki
    {
        public int IdKontrahenciLiczniki { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KontrahId { get; set; }
        /// <summary>
        /// Prefix używany w formacie licznika
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// Licznik główny - używany, gdy LICZ_MIES = 0
        /// </summary>
        public int Licznik { get; set; }
        /// <summary>
        /// Rok licznika
        /// </summary>
        public int Rok { get; set; }
        /// <summary>
        /// Miesiąc licznika
        /// </summary>
        public int? Miesiac { get; set; }
        /// <summary>
        /// Postfix używany w formacie licznika
        /// </summary>
        public string Postfix { get; set; }
        /// <summary>
        /// Format licznika
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// Flaga, czy stała długość numeru licznika
        /// </summary>
        public short? StalaDlugLicz { get; set; }
        /// <summary>
        /// Ilość cyfr, gdy stała długość - uzywane, gdy STALA_DLUG_LICZ = 1
        /// </summary>
        public short? IloscCyfr { get; set; }
        /// <summary>
        /// Flaga, czy licznik miesięczny
        /// </summary>
        public short LiczMies { get; set; }
        /// <summary>
        /// Licznik dla miesiaca I - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? I { get; set; }
        /// <summary>
        /// Licznik dla miesiaca II - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Ii { get; set; }
        /// <summary>
        /// Licznik dla miesiaca III - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Iii { get; set; }
        /// <summary>
        /// Licznik dla miesiaca IV - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Iv { get; set; }
        /// <summary>
        /// Licznik dla miesiaca V - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? V { get; set; }
        /// <summary>
        /// Licznik dla miesiaca VI - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Vi { get; set; }
        /// <summary>
        /// Licznik dla miesiaca VII - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Vii { get; set; }
        /// <summary>
        /// Licznik dla miesiaca VIII - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Viii { get; set; }
        /// <summary>
        /// Licznik dla miesiaca IX - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Ix { get; set; }
        /// <summary>
        /// Licznik dla miesiaca X - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? X { get; set; }
        /// <summary>
        /// Licznik dla miesiaca XI - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Xi { get; set; }
        /// <summary>
        /// Licznik dla miesiaca XII - używany, gdy LICZ_MIES = 1
        /// </summary>
        public int? Xii { get; set; }
    }
}
