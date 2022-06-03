using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Blokady obiektów systemowych - punkty kontrolne
    /// </summary>
    public partial class BlokadyPk
    {
        public int IdBlokadyPk { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Procedura { get; set; }
        public string Grupa { get; set; }
        public int? ZatwZb { get; set; }
        public int? BlokadyTypyId { get; set; }
        public string ProceduraDomyslna { get; set; }
    }
}
