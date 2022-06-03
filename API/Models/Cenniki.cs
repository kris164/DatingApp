using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Definicje cenników standardowych
    /// </summary>
    public partial class Cenniki
    {
        public int IdCenniki { get; set; }
        /// <summary>
        /// Nazwa cennika
        /// </summary>
        public string Nazwa { get; set; }
        /// <summary>
        /// Flaga, czy dotyczy FTL
        /// </summary>
        public int? Ftl { get; set; }
        /// <summary>
        /// Relacja do kontrahenta - tab: KONTRAHENCI
        /// </summary>
        public int? KlientId { get; set; }
        /// <summary>
        /// Symbol kontrahenta
        /// </summary>
        public string Klient { get; set; }
        /// <summary>
        /// Relacja do trasy - tab: TRASY
        /// </summary>
        public int? TrasaId { get; set; }
        /// <summary>
        /// Opis trasy
        /// </summary>
        public string Trasa { get; set; }
        /// <summary>
        /// Ważność cennika od
        /// </summary>
        public DateTime? DataOd { get; set; }
        /// <summary>
        /// Ważność cennika do
        /// </summary>
        public DateTime? DataDo { get; set; }
        /// <summary>
        /// Waluta cennika
        /// </summary>
        public string Waluta { get; set; }
        /// <summary>
        /// ID typu cennika - pobierane z XML-a
        /// </summary>
        public string TypId { get; set; }
        /// <summary>
        /// Typ cennika - pobierane z XML-a
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// ID celu cennika - pobierane z XML-a
        /// </summary>
        public string CelId { get; set; }
        /// <summary>
        /// Cel cennika - pobierane z XML-a
        /// </summary>
        public string Cel { get; set; }
        /// <summary>
        /// Flaga, czy automatycznie wypełniać wartościami
        /// </summary>
        public int? AutoFill { get; set; }
        /// <summary>
        /// Definicja - Ilość kolumn
        /// </summary>
        public int? DefCol { get; set; }
        /// <summary>
        /// Definicja - Ilosć wierszy
        /// </summary>
        public int? DefRow { get; set; }
        /// <summary>
        /// Definicja - Znaczenie kolumn
        /// </summary>
        public string DefColMean { get; set; }
        /// <summary>
        /// Definicja - Znaczenie wierszy
        /// </summary>
        public string DefRowMean { get; set; }
        /// <summary>
        /// Definicja - Interwał wierszy
        /// </summary>
        public int? DefColIntv { get; set; }
        /// <summary>
        /// Definicja - Interwał kolumn
        /// </summary>
        public int? DefRowIntv { get; set; }
        /// <summary>
        /// Definicja - Wartosć początkowa dla kolumn
        /// </summary>
        public int? DefColStart { get; set; }
        /// <summary>
        /// Definicja - Wartosć początkowa dla wierszy
        /// </summary>
        public int? DefRowStart { get; set; }
        /// <summary>
        /// Definicja wypełnienia - Wartość początkowa
        /// </summary>
        public double? DefFillStart { get; set; }
        /// <summary>
        /// Definicja wypełnienia - Interwał w wierszach
        /// </summary>
        public double? DefFillStepX { get; set; }
        /// <summary>
        /// Definicja wypełnienia - Interwał w kolumnach
        /// </summary>
        public double? DefFillStepY { get; set; }
        /// <summary>
        /// Definicja kolumn - format MemData
        /// </summary>
        public byte[] DefColTab { get; set; }
        /// <summary>
        /// Definicja wierszy - format MemData
        /// </summary>
        public byte[] DefRowTab { get; set; }
        /// <summary>
        /// Wypełniona tabela ze stawkami - format MemData
        /// </summary>
        public byte[] TabelaFrachtowa { get; set; }
        /// <summary>
        /// Lokalizacja
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// Sposób wyliczania ceny: Z, K, W
        /// </summary>
        public string CalcType { get; set; }
        /// <summary>
        /// Flaga, czy kody pocztowe zawierają symbol kraju
        /// </summary>
        public int? KodpocztKraj { get; set; }
        /// <summary>
        /// Wg jakiego kodu pocztowego ma się odbywać liczenie: ZLE,NAD,ODB
        /// </summary>
        public string KodpocztRodz { get; set; }
        /// <summary>
        /// Flaga, czy liczyć przedziałowo w wierszach
        /// </summary>
        public int? PrzedzialowoX { get; set; }
        /// <summary>
        /// Flaga, czy liczyć przedziałowo w kolumnach
        /// </summary>
        public int? PrzedzialowoY { get; set; }
        /// <summary>
        /// Dział
        /// </summary>
        public string Dzial { get; set; }
    }
}
