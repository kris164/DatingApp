using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Pozycje spłat do faktury - detal do tabeli FAKTURY
    /// </summary>
    public partial class FakturySplaty
    {
        public int IdFakturySplaty { get; set; }
        /// <summary>
        /// Relacja do faktury - tab: FAKTURY
        /// </summary>
        public int FakturyId { get; set; }
        /// <summary>
        /// Data spłaty
        /// </summary>
        public DateTime DataSplaty { get; set; }
        /// <summary>
        /// Numer wyciągu
        /// </summary>
        public string NrWyciagu { get; set; }
        /// <summary>
        /// Kwota spłaty w walucie faktury
        /// </summary>
        public double KwotaSplaty { get; set; }
        /// <summary>
        /// Relacja do tabeli kursów - tab: TABELA_KURSY_D
        /// </summary>
        public int? KursyWalutId { get; set; }
        /// <summary>
        /// Numer tabeli kursowej
        /// </summary>
        public string NrTabeliKursow { get; set; }
        /// <summary>
        /// Kurs waluty
        /// </summary>
        public double? KursWaluty { get; set; }
        /// <summary>
        /// Data tabeli kursowej
        /// </summary>
        public DateTime? DataTabeliKursow { get; set; }
        /// <summary>
        /// Relacja do kompensaty - tab: KOMPENSATY
        /// </summary>
        public int? KompensatyId { get; set; }
        /// <summary>
        /// Relacja do tabeli komunikacji z FK
        /// </summary>
        public int? KomunikacjaFkRkId { get; set; }
        /// <summary>
        /// Flaga, czy zapłata była przedpłatą
        /// </summary>
        public int? Przedplata { get; set; }
        /// <summary>
        /// Flaga, czy spłata w PLN
        /// </summary>
        public int? SplataWPln { get; set; }
        /// <summary>
        /// Kwota spłaty w PLN
        /// </summary>
        public double? KwotaSplatyWPln { get; set; }
        /// <summary>
        /// Retacja do użytkownika rej. spłate - tab: UZYTKOWNIK
        /// </summary>
        public int? UzytkownikId { get; set; }
        /// <summary>
        /// Nazwa użytkwnika
        /// </summary>
        public string Uzytkownik { get; set; }
        /// <summary>
        /// Relacja do wyciągu bankowego - tab: WYC_BANK
        /// </summary>
        public int? WycBankId { get; set; }
        /// <summary>
        /// Relacja do poz. wyciągu bankowego - tab: WYC_BANK_OPER
        /// </summary>
        public int? WycBankOperId { get; set; }
        public int? ZZaliczkowejId { get; set; }
        /// <summary>
        /// Kwota spłaty VAT (SplitPayment)
        /// </summary>
        public double? KwotaSplatyVat { get; set; }
        public int? PrzelewyDokId { get; set; }
    }
}
