using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class OfertyDrobnUslugi
    {
        public int IdOfertyDrobnUslugi { get; set; }
        public int? OfertyDrobnId { get; set; }
        public string NrUslugi { get; set; }
        public string WarunkiDostawy { get; set; }
        public int? RelacjaId { get; set; }
        public string Relacja { get; set; }
        public string Kierunek { get; set; }
        public int? PartnerId { get; set; }
        public string Partner { get; set; }
        public string Usluga { get; set; }
        public int? ZaId { get; set; }
        public string ZaNazwa { get; set; }
        public string ZaAdres { get; set; }
        public string ZaMiasto { get; set; }
        public string ZaKod { get; set; }
        public string ZaKraj { get; set; }
        public string ZaTel { get; set; }
        public string ZaFax { get; set; }
        public string ZaKontakt { get; set; }
        public int? WyId { get; set; }
        public string WyNazwa { get; set; }
        public string WyAdres { get; set; }
        public string WyMiasto { get; set; }
        public string WyKod { get; set; }
        public string WyKraj { get; set; }
        public string WyTel { get; set; }
        public string WyFax { get; set; }
        public string WyKontakt { get; set; }
        public int? TabelaKursowId { get; set; }
        public string TabelaKursow { get; set; }
        public string Waluta { get; set; }
        public double? WagaObl { get; set; }
        public double? OdlObl { get; set; }
        public double? FrachtKlienta { get; set; }
    }
}
