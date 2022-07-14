using System;
using System.Collections.Generic;
using API.DTOs;

namespace API.Models
{
    public partial class User 
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int? UzyttkownikId { get; set; }
        public  string  regon { get; set; }
    public string nip { get; set; }
    public string statusNip { get; set; }
    public string nazwa { get; set; }
    public string wojewodztwo { get; set; }
    public string powiat { get; set; }
    public string gmina { get; set; }
    public string miejscowosc { get; set; }
    public string kodPocztowy { get; set; }
    public string ulica { get; set; }
    public string nrNieruchomosci { get; set; }
    public string nrLokalu { get; set; }
    public string typ { get; set; }
    public int? silosID{ get; set; }
    public DateTime? dataZakonczeniaDzialalnosci { get; set; }
    public string miejscowoscPoczty { get; set; }
    
    public int? ciagnikSiodlowy { get; set; }
    public int? ciagnikTrojosiowy { get; set; }
    public int? ciagnikTypuMega { get; set; }
    public int? ciagnikTypuMegaReagul { get; set; }
    public int? jumbo { get; set; }
    public int? naczepaOplanegkowana { get; set; }
    public int? megaNaczepaOplanegkowana { get; set; }
    public string mobile { get; set; }
    public string email { get; set; }
    }
}
