using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SzablonyZlecenExt
    {
        public int IdSzablonyZlecen { get; set; }
        /// <summary>
        /// Informacje dla SFM-a
        /// </summary>
        public string InfoSfm { get; set; }
        /// <summary>
        /// Trasa zlecenia - id z mapy
        /// </summary>
        public string MapRouteid { get; set; }
        /// <summary>
        /// Relacja do profilu użytego do obliczeń trasy
        /// </summary>
        public int? MapProfilId { get; set; }
        /// <summary>
        /// Flaga, czy są dodatkowe pozycje kosztów
        /// </summary>
        public short? SaDodPozK { get; set; }
        /// <summary>
        /// Flaga, czy są dodatkowe pozycje przychodu
        /// </summary>
        public short? SaDodPozP { get; set; }
        /// <summary>
        /// Dedykowane: TARGOR
        /// </summary>
        public short? PotwPrzenWar { get; set; }
        /// <summary>
        /// Czas trwania zlecenia na potrzeby rozliczeń m-okresowych
        /// </summary>
        public double? CzasTrwaniaZlecenia { get; set; }
        /// <summary>
        /// Flaga, czy faktura na płatnika
        /// </summary>
        public short? FvNaPlatnika { get; set; }
        /// <summary>
        /// Flaga, czy jest niezgodnosc
        /// </summary>
        public short? Niezgodnosc { get; set; }
        /// <summary>
        /// Flaga, czy jest reklamacja
        /// </summary>
        public short? Reklamacja { get; set; }
        public int? PrzewoznikOddzialId { get; set; }
        public string PrzewoznikOddzialNazwa { get; set; }
        public string PrzewoznikOddzialAdres { get; set; }
        public string PrzewoznikOddzialMiasto { get; set; }
        public string PrzewoznikOddzialKod { get; set; }
        public string PrzewoznikOddzialKraj { get; set; }
        public string ProceduraMycia { get; set; }
        /// <summary>
        /// Informacje dla kierowcy
        /// </summary>
        public string InfoKier { get; set; }
        /// <summary>
        /// Informacje dla spedytora
        /// </summary>
        public string InfoSped { get; set; }
        /// <summary>
        /// Flaga, czy nie fakturować
        /// </summary>
        public short? NieFakturuj { get; set; }
        public short? ZlecKoszerne { get; set; }
        public short? MycieKoszerne { get; set; }
        /// <summary>
        /// Średni koszt za km
        /// </summary>
        public double? HereAverageKmCost { get; set; }
        /// <summary>
        /// Średni koszt godziny
        /// </summary>
        public double? HereAverageHourCost { get; set; }
        /// <summary>
        /// Koszt stały na trasę
        /// </summary>
        public double? HereRouteCost { get; set; }
        public string HereCostCurrency { get; set; }
        /// <summary>
        /// Wyznaczenie trasy: 1=szybka, 2=krótka, 3=optymalna
        /// </summary>
        public int? HereRouteCalculateType { get; set; }
        /// <summary>
        /// Liczy myto: 1=EUR
        /// </summary>
        public int? HereTollCalculate { get; set; }
        /// <summary>
        /// Naruszanie ograniczeń: 1=zgoda, 0=brak zgody, 2=unikaj
        /// </summary>
        public int? HereViolation { get; set; }
        /// <summary>
        /// Unikaj promów
        /// </summary>
        public int? HereFerries { get; set; }
        /// <summary>
        /// Unikaj autostrad
        /// </summary>
        public int? HereHighways { get; set; }
        /// <summary>
        /// Unikaj płatności
        /// </summary>
        public int? HerePayments { get; set; }
        /// <summary>
        /// Unikaj tuneli
        /// </summary>
        public int? HereTunels { get; set; }
        /// <summary>
        /// towary niebezpieczne
        /// </summary>
        public string HereHazardous { get; set; }
        public string HereTollCalculateBaseCurr { get; set; }
        public string HereTollCalculateOtherCurr { get; set; }
        public string MapLink { get; set; }
        public int? Sent { get; set; }
        public string RestrictedCountries { get; set; }
        public string RestrictedAreas { get; set; }
    }
}
