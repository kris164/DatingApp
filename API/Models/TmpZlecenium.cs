using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpZlecenium
    {
        public int IdTmpZlecenia { get; set; }
        /// <summary>
        /// Unikalny identyfikator sesji
        /// </summary>
        public int? IdSesjiKalk { get; set; }
        public int? KlientId { get; set; }
        public string RodzZlec { get; set; }
        public string Typ { get; set; }
        public int? PlatnikId { get; set; }
        public int? PrzewoznikId { get; set; }
        public string TypZlecenia { get; set; }
        public double? WagaLadunku { get; set; }
        public double? WagaLadunkuRz { get; set; }
        public double? ObjetoscLadunku { get; set; }
        public string TypOpakowania { get; set; }
        public double? IloscOpakowan { get; set; }
        public int? WymianaPalet { get; set; }
        public double? KwotaK { get; set; }
        public string WalutaK { get; set; }
        public string WalutaFvK { get; set; }
        public string TypKursK { get; set; }
        public int? TypTabK { get; set; }
        public double? OdcKrajowyK { get; set; }
        public double? OdcKrajowyVatK { get; set; }
        public string OdcKrajowyVatIdK { get; set; }
        public double? OdcUeK { get; set; }
        public double? OdcUeVatK { get; set; }
        public string OdcUeVatIdK { get; set; }
        public double? OdcZagranicznyK { get; set; }
        public double? OdcZagranicznyVatK { get; set; }
        public string OdcZagranicznyVatIdK { get; set; }
        public double? KwotaP { get; set; }
        public string WalutaP { get; set; }
        public string WalutaFvP { get; set; }
        public string TypKursP { get; set; }
        public int? TypTabP { get; set; }
        public double? OdcKrajowyP { get; set; }
        public double? OdcKrajowyVatP { get; set; }
        public string OdcKrajowyVatIdP { get; set; }
        public double? OdcUeP { get; set; }
        public double? OdcUeVatP { get; set; }
        public string OdcUeVatIdP { get; set; }
        public double? OdcZagranicznyP { get; set; }
        public double? OdcZagranicznyVatP { get; set; }
        public string OdcZagranicznyVatIdP { get; set; }
        public double? KwotaKUstalona { get; set; }
        public double? StawkaZaKm { get; set; }
        public double? StawkaZaWagaKm { get; set; }
        public double? KwotaPUstalona { get; set; }
        public double? StawkaZaKmP { get; set; }
        public double? StawkaZaWagaKmP { get; set; }
        public double? WartoscLadunku { get; set; }
        public string WartoscLadunkuWal { get; set; }
        public int? StatusKalk { get; set; }
        public string KursWgK { get; set; }
        public int? KursZDniaPK { get; set; }
        public string KursWgP { get; set; }
        public int? KursZDniaPP { get; set; }
        public DateTime? DataZlecenia { get; set; }
        public int? VatWPln { get; set; }
        public int? WymianaPaletRozl { get; set; }
        public int? WymianaPaletWysl { get; set; }
        public DateTime? WymianaPaletWyslData { get; set; }
        public int? IdZlecenia { get; set; }
        public int? FrmId { get; set; }
        public int? SamochodId { get; set; }
        public int? NaczepaId { get; set; }
        public string OpisTowaru { get; set; }
        public DateTime? WyData { get; set; }
        public string Samochod { get; set; }
        public string NrZlecenia { get; set; }
        public int? Kierowca1Id { get; set; }
        public string Kierowca1 { get; set; }
        public int? Anulowane { get; set; }
        public string Lokalizacja { get; set; }
    }
}
