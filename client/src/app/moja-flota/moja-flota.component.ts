import { Component, Input, OnInit } from '@angular/core';
import { company } from '../_models/company';
import { User } from '../_models/user';
import { CompanyService } from '../_services/company.service';

@Component({
  selector: 'app-moja-flota',
  templateUrl: './moja-flota.component.html',
  styleUrls: ['./moja-flota.component.css']
})

 

export class MojaFlotaComponent implements OnInit {

  company:company;
  
  title = "Stepper input";
  @Input() initialValue = 0;
  @Input() step  = 1;
  @Input() min: number = 0;
  @Input() max: number = 10;
  @Input() symbol: string;
  @Input() ariaLabelLess: string;
  @Input() ariaLabelMore: string;
  
  renderedValue_ciagnik_siodlowy: string; 
  renderedValue_ciagnik_trojosiowy : string; 
  renderedValue_ciagnik_typu_mega: string;   
  renderedValue_ciagnik_typu_mega_regul: string;  
  renderedValue_value_jumbo_z_przyczepa: string;    
  renderedValue_naczepa_oplandekowana: string;     
  renderedValue_mega_naczepa_oplandekowana: string;  


  constructor(private companyService: CompanyService) { }

  async ngOnInit(): Promise<void> {

    this.company = {
      id:0,
      regon: "",
      nip: "",
      statusNip: "",
      nazwa: "",
      wojewodztwo: "",
      powiat: "",
      gmina: "",
      miejscowosc: "",
      kodPocztowy: "",
      ulica: "",
      nrNieruchomosci: "",
      nrLokalu: "",
      typ: "F",
      silosID: 1,
      dataZakonczeniaDzialalnosci: "",
      miejscowoscPoczty: "",
      errors: [],
      ciagnikSiodlowy:  0,
      ciagnikTrojosiowy:  0,
      ciagnikTypuMega:  0,
      ciagnikTypuMegaReagul:  0,
      jumbo: 0,
      naczepaOplanegkowana:  0,
      megaNaczepaOplanegkowana:  0,
      Password : "",
      UserName: "",
      UsernameDto:  "Dave" ,
      email: "",
      mobile: "", 
      accepted: 0,
      id_kontrah: 0 ,
    };



    const user: User = JSON.parse(localStorage.getItem('user'))
    this.company = await this.companyService.GetCompany(user.username);
    this.renderedValue_ciagnik_siodlowy = this.company.ciagnikSiodlowy.toString(); 
    this.renderedValue_ciagnik_trojosiowy = this.company.ciagnikTrojosiowy.toString(); 
    this.renderedValue_ciagnik_typu_mega = this.company.ciagnikTypuMega.toString();  
    this.renderedValue_ciagnik_typu_mega_regul = this.company.ciagnikTypuMegaReagul.toString(); 
    this.renderedValue_value_jumbo_z_przyczepa = this.company.jumbo.toString(); 
    this.renderedValue_naczepa_oplandekowana = this.company.naczepaOplanegkowana.toString(); 
    this.renderedValue_mega_naczepa_oplandekowana = this.company.megaNaczepaOplanegkowana.toString(); 
  }


  toggleMore_ciagnik_siodlowy()  {
    if (this.step + this.company.ciagnikSiodlowy <= this.max) {
      this.company.ciagnikSiodlowy = this.company.ciagnikSiodlowy +  this.step;
      this.renderedValue_ciagnik_siodlowy = this.company.ciagnikSiodlowy.toString()  ;
    }
  } 

  toggleLess_ciagnik_siodlowy() {
    if (this.company.ciagnikSiodlowy - this.step >= this.min) {
      this.company.ciagnikSiodlowy = this.company.ciagnikSiodlowy - this.step;
      this.renderedValue_ciagnik_siodlowy = this.company.ciagnikSiodlowy.toString();
    }
  } 

  toggleMore_ciagnik_trojosiowy()  {
    if (this.step + this.company.ciagnikTrojosiowy <= this.max) {
      this.company.ciagnikTrojosiowy = this.company.ciagnikTrojosiowy + this.step;
      this.renderedValue_ciagnik_trojosiowy = this.company.ciagnikTrojosiowy.toString()  ;
    }
  } 

  toggleLess_ciagnik_trojosiowy() {
    if (this.company.ciagnikTrojosiowy - this.step >= this.min) {
      this.company.ciagnikTrojosiowy = this.company.ciagnikTrojosiowy - this.step;
      this.renderedValue_ciagnik_trojosiowy = this.company.ciagnikTrojosiowy.toString();
    } 
  } 

  toggltoggleLess_ciagnik_trojosiowy_typu_mega()  {
    if (this.company.ciagnikTypuMega - this.step >= this.min) {
      this.company.ciagnikTypuMega = this.company.ciagnikTypuMega - this.step;
      this.renderedValue_ciagnik_typu_mega = this.company.ciagnikTypuMega.toString();
    } 
  } 
  toggleMore_ciagnik_trojosiowy_typu_mega() {

    if (this.step + this.company.ciagnikTypuMega <= this.max) {
      this.company.ciagnikTypuMega = this.company.ciagnikTypuMega + this.step;
      this.renderedValue_ciagnik_typu_mega = this.company.ciagnikTypuMega.toString()  ;
    }
  } 



  toggltoggleLess_ciagnik_trojosiowy_typu_mega_regul()  {
    if (this.company.ciagnikTypuMegaReagul - this.step >= this.min) {
      this.company.ciagnikTypuMegaReagul = this.company.ciagnikTypuMegaReagul - this.step;
      this.renderedValue_ciagnik_typu_mega_regul = this.company.ciagnikTypuMegaReagul.toString();
    }
  } 
  toggleMore_ciagnik_trojosiowy_typu_mega_regul() { 
    if (this.step + this.company.ciagnikTypuMegaReagul <= this.max) {
      this.company.ciagnikTypuMegaReagul = this.company.ciagnikTypuMegaReagul + this.step;
      this.renderedValue_ciagnik_typu_mega_regul = this.company.ciagnikTypuMegaReagul.toString()  ;
    }
  } 


  toggltoggleLess_jumbo_z_przyczepa()  {
    if (this.company.jumbo - this.step >= this.min) {
      this.company.jumbo = this.company.jumbo - this.step;
      this.renderedValue_value_jumbo_z_przyczepa = this.company.jumbo.toString();
    } 
  } 
  toggleMore_jumbo_z_przyczepa() { 
    if (this.step + this.company.jumbo <= this.max) {
      this.company.jumbo = this.company.jumbo + this.step;
      this.renderedValue_value_jumbo_z_przyczepa = this.company.jumbo.toString()  ;
    }
  } 

  
  toggleLess_naczepa_oplandekowana()  {
    if (this.company.naczepaOplanegkowana - this.step >= this.min) {
      this.company.naczepaOplanegkowana = this.company.naczepaOplanegkowana - this.step;
      this.renderedValue_naczepa_oplandekowana = this.company.naczepaOplanegkowana.toString();
    }
  } 
  toggleMore_naczepa_oplandekowana() { 
    if (this.step + this.company.naczepaOplanegkowana <= this.max) {
      this.company.naczepaOplanegkowana = this.company.naczepaOplanegkowana + this.step;
      this.renderedValue_naczepa_oplandekowana = this.company.naczepaOplanegkowana.toString()  ;
    }
  } 


  toggleLess_mega_naczepa_oplandekowana()  {
    if (this.company.megaNaczepaOplanegkowana - this.step >= this.min) {
      this.company.megaNaczepaOplanegkowana = this.company.megaNaczepaOplanegkowana - this.step;
      this.renderedValue_mega_naczepa_oplandekowana = this.company.megaNaczepaOplanegkowana.toString();
    }
  } 
  toggleMore_mega_naczepa_oplandekowana() { 
    if (this.step + this.company.megaNaczepaOplanegkowana <= this.max) {
      this.company.megaNaczepaOplanegkowana = this.company.megaNaczepaOplanegkowana + this.step;
      this.renderedValue_mega_naczepa_oplandekowana = this.company.megaNaczepaOplanegkowana.toString()  ;
    }

}
}
