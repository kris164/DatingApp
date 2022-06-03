using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class KierowcyExt
    {
        public int IdKierowcy { get; set; }
        /// <summary>
        /// czas obliczeń
        /// </summary>
        public DateTime? TDtStanNa { get; set; }
        /// <summary>
        /// ostatni odpoczynek tygodniowy
        /// </summary>
        public DateTime? TDtOstOdpTyg { get; set; }
        /// <summary>
        /// ostatni odpoczynek dzienny
        /// </summary>
        public DateTime? TDtOstOdpD { get; set; }
        /// <summary>
        /// liczba godzin jazdy za ost. 2 tyg.
        /// </summary>
        public double? TJazda2Tyg { get; set; }
        /// <summary>
        /// liczba godzin jazdy za ost. tydzień
        /// </summary>
        public double? TJazdaTyg { get; set; }
        /// <summary>
        /// liczba godzin jazdy w bieżącym dniu
        /// </summary>
        public double? TJazdaD { get; set; }
        /// <summary>
        /// ostatnia aktywność różna od odpoczynku
        /// </summary>
        public DateTime? TDtOstPracy { get; set; }
        /// <summary>
        /// (0/1) czy ostatni odpoczynek tygodniowy był skrócony
        /// </summary>
        public short? TOdpTygSkrocony { get; set; }
        /// <summary>
        /// status TACHO
        /// </summary>
        public string TTachoStat { get; set; }
        /// <summary>
        /// czas statusu TACHO
        /// </summary>
        public DateTime? TTachoDt { get; set; }
        /// <summary>
        /// początek ostatniej doby
        /// </summary>
        public DateTime? TDtPoczDoby { get; set; }
        /// <summary>
        /// liczba godzin pozostałej jazdy w bieżącym dniu
        /// </summary>
        public double? TMozeJechacD { get; set; }
        /// <summary>
        /// liczba godzin pozostałej jazdy w bieżącym tygodniu
        /// </summary>
        public double? TMozeJechacTyg { get; set; }
        /// <summary>
        /// liczba godzin do następnego odpoczynku tygodniowego
        /// </summary>
        public double? TNastOdpTyg { get; set; }
        /// <summary>
        /// liczba godzin pierwszej nieodebranej rekompensaty
        /// </summary>
        public double? TRekompIle { get; set; }
        /// <summary>
        /// do kiedy należy odebrać pierwszą nieodebraną rekompensatę
        /// </summary>
        public DateTime? TRekompDoKiedy { get; set; }
        /// <summary>
        /// liczba godzin pracy w bieżącym dniu
        /// </summary>
        public double? TPracaD { get; set; }
        /// <summary>
        /// liczba godzin dyżuru w bieżącym dniu
        /// </summary>
        public double? TDyzurD { get; set; }
        /// <summary>
        /// liczba wydłużonych jazd
        /// </summary>
        public int? TWydluzoneJazdy { get; set; }
        /// <summary>
        /// liczba skróconych odpoczynków
        /// </summary>
        public int? TSkroconeOdp { get; set; }
        /// <summary>
        /// liczba pozostałych wydłużonych jazd (10h)
        /// </summary>
        public int? TPozostaleJazdy10h { get; set; }
        /// <summary>
        /// liczba pozostałych skróconych odpoczynków
        /// </summary>
        public int? TPozostaleOdp9h { get; set; }
        /// <summary>
        /// liczba godzin pozostałej pracy w bieżącym dniu
        /// </summary>
        public double? TMozePracowacD { get; set; }
        /// <summary>
        /// początek następnego odpoczynku dziennego
        /// </summary>
        public DateTime? TDtNastOdpD { get; set; }
        public string Statistics { get; set; }
    }
}
