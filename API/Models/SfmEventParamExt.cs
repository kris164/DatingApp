using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class SfmEventParamExt
    {
        public int IdSfmEventParam { get; set; }
        /// <summary>
        /// opis zdarzenia/ wartość parametru
        /// </summary>
        public string Opis { get; set; }
    }
}
