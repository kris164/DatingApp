using System.ComponentModel.DataAnnotations;
using BIRService.Models;

namespace API.GusModel
{
    public class CompanyModel
    {
          public Guid Id { get; set; }

        [Display(Name = "Nazwa firmy")]
        public string Name { get; set; }

        [Display(Name = "Adres firmy")]
        public string Address { get; set; }

        [Display(Name = "Nr Nip")]
        public string Vat { get; set; }

        [Display(Name = "Nr Regon")]
        public string Regon { get; set; }

        public List<ErrorModel> Errors { get; set; } = new();
    }
}