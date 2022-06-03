using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Słownik prowincji
    /// </summary>
    public partial class Province
    {
        public int ProvinceId { get; set; }
        public string CountryCode { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }
    }
}
