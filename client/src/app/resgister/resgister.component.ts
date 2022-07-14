import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { company } from '../_models/company';
import { AccountService } from '../_services/account.service';
import { GusService } from '../_services/gus.service';  
import { DialogComponent } from '@syncfusion/ej2-angular-popups';
import { isNullOrUndefined, EmitType } from '@syncfusion/ej2-base';
import { Router } from '@angular/router'; 
import { FormValidator, FormValidatorModel } from '@syncfusion/ej2-inputs'; 
import { FormControl, FormGroup, Validators, FormsModule, AbstractControl, FormBuilder } from '@angular/forms';
import { FormValidators } from '@syncfusion/ej2-angular-inputs';

@Component({
  selector: 'app-resgister',
  templateUrl: './resgister.component.html',
  styleUrls: ['./resgister.component.css']
})


export class ResgisterComponent implements OnInit {
 
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

  public selectedIndex: number = 0;
  @ViewChild('Dialog')
  public dialogObj: DialogComponent;
  @ViewChild('userForm') form: any;
  public width: string = '335px';
  public visible: boolean = false;
  public multiple: boolean = false;
  public showCloseIcon: Boolean = true;
  public formHeader: string = 'Success';
  public content: string = 'You have successfully registered, Thank you.';
  public target: string = '#control_wrapper';
  public isModal: boolean = true;
  public animationSettings: object = {
    effect: 'Zoom'
  };
  public UserDetails: UserDetails;

  @Output() cancelRegister = new EventEmitter();
  model:any={};
  company:company;
  isShown: boolean = false ; // hidden by default
  isShownDanezGus: boolean = true ; // hidden by default

  firstPageButton: boolean = false ; // hidden by default
 secondPageButton: boolean = false ; // hidden by default

  reactForm: FormGroup;

  constructor(private accountService: AccountService, private toastr: ToastrService, private gusService: GusService, private router: Router, private builder: FormBuilder) {


    this.createForm();

   }

  ngOnInit(): void {


    let formId: HTMLElement = <HTMLElement>document.getElementById('formId');
   // document.getElementById('formId').addEventListener(
   //   'submit',
   //   (e: Event) => {
   //     e.preventDefault();
   //     if (this.reactForm.valid) {
   //       alert('Customer details added!');
   //       this.reactForm.reset();
   //     }
   //   });

 
   

    this.company = {
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
    };

    
      this.renderedValue_ciagnik_siodlowy = this.company.ciagnikSiodlowy.toString(); 
      this.renderedValue_ciagnik_trojosiowy = this.company.ciagnikTrojosiowy.toString(); 
      this.renderedValue_ciagnik_typu_mega = this.company.ciagnikTypuMega.toString();  
      this.renderedValue_ciagnik_typu_mega_regul = this.company.ciagnikTypuMegaReagul.toString(); 
      this.renderedValue_value_jumbo_z_przyczepa = this.company.jumbo.toString(); 
      this.renderedValue_naczepa_oplandekowana = this.company.naczepaOplanegkowana.toString(); 
      this.renderedValue_mega_naczepa_oplandekowana = this.company.megaNaczepaOplanegkowana.toString(); 
 
 
  }

  createForm() {
    this.reactForm  = new FormGroup({
      'nip': new FormControl('', [FormValidators.required]),
      'miejscowosc': new FormControl('', [FormValidators.required]),
      'nazwa': new FormControl('', [FormValidators.required]),
      'kodPocztowy': new FormControl('', [FormValidators.required]),
      'ulica': new FormControl('', [FormValidators.required]),
    });
  }
 
  get nip() { return this.reactForm.get('nip'); }
  get miejscowosc() { return this.reactForm.get('miejscowosc'); }
  get nazwa() { return this.reactForm.get('nazwa'); }
  get kodPocztowy() { return this.reactForm.get('kodPocztowy'); }
  get ulica() { return this.reactForm.get('ulica'); }

onSubmit() {
    alert("Form Submitted!");
}

  async getCompanyByNip()
  {
    this.isShown = true;
    this.isShownDanezGus=false;
    // this.company = await this.gusService.GetCompanyByNip(this.company.nip);
     this.company = await this.gusService.GetCompanyByNip(this.company.nip);
     this.reactForm.value.nip =  this.company.nip;
     this.reactForm.value.miejscowosc =  this.company.miejscowosc;
     this.reactForm.value.nazwa =  this.company.nazwa;
     this.reactForm.value.kodPocztowy =  this.company.kodPocztowy;
     this.reactForm.value.ulica =  this.company.ulica;
 
  
     this.company.ciagnikSiodlowy = 0;
     this.company.ciagnikTrojosiowy= 0,
     this.company.ciagnikTypuMega=  0,
     this.company.ciagnikTypuMegaReagul=  0 
     this.company.jumbo=  0 
     this.company.naczepaOplanegkowana=  0 
     this.company.megaNaczepaOplanegkowana=  0 
     this.company.Password="password" 
     this.company.UserName="Dave" 
     this.company.UsernameDto="Dave" 
     this.company.dataZakonczeniaDzialalnosci = "2019-01-06T17:16:40"
     this.company.email="" 
     this.company.mobile="" 
     this.CheckIsValid();
  }

  register3(){}

  register(){ 
    this.accountService.register(this.company).subscribe(response => {
      console.log(response);
      this.nextBtnClick();
      this.cancel();
      setTimeout(() => {
        this.router.navigate(['/orders']);
    }, 5000);  //5s

    }, error=>{
      console.log(error);
      //this.toastr.error(error.error)
    });
  }

  cancel(){
    this.cancelRegister.emit(false);
  }


  public dlgBtnClick: EmitType<object> = () => {
    this.dialogObj.hide();
  }
  public dlgButtons: Object[] = [{ click: this.dlgBtnClick.bind(this), buttonModel: { content: 'Ok', isPrimary: true } }];
    @ViewChild('formElement') element: any;

   public Submit(): void {
    this.onFormSubmit();
  }
 public onFormSubmit(): void {
   this.dialogObj.show();
   this.form.reset();
   this.UserDetails = {
    nip: '',
    firstname: '',
    lastname: '',
    username: '',
    password: '',
    email:'',
    mobile: ''
  };

 }


 public prevBtnClick() {
  let carouselObj = (document.querySelector(".e-carousel") as any).ej2_instances[0];
  carouselObj.prev();
    }
  
    public nextBtnClick() {
  let carouselObj = (document.querySelector(".e-carousel") as any).ej2_instances[0];
  this.CheckIsValid();
  this.CheckIsSecondValid();
  carouselObj.next();
    }

  
   // this.renderedValue_mega_naczepa_oplandekowana = this.company.megaNaczepaOplanegkowana.toString(); 


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
    getSomeClass(){
     
    }
    CheckIsSecondValid() {
      if (this.company.email != ""  && this.company.mobile != ""  && this.company.Password != "" && this.company.UserName != ""   )
    {
      this.secondPageButton = true;
    }
    else
    {
      this.secondPageButton = false;
    }
  }


   
  CheckIsValid() {
   if (this.company.nip != ""  && this.company.miejscowosc != ""  && this.company.nazwa != "" && this.company.kodPocztowy != "" && this.company.ulica != "" )
    {
   this.firstPageButton = true;
  }
    else
  {
  this.firstPageButton = false;
 } 
}

saverange(newValue, area) {
  this.CheckIsSecondValid();
 // this.range = newValue;
 // this.Platform.ready().then(() => {
 //    this.rootRef.child("users").child(this.UserID).child('range').set(this.range)


 switch(area) {
  case 'email':
    this.company.email = newValue;
    this.CheckIsSecondValid();
    break;
  case 'y':
    // code block
    break;
  default:
    // code block
}
   
} 

}
export interface UserDetails {
  nip: string;
  firstname: string;
  lastname: string;
  username: string;
  password: string;
  email: string;
  mobile: string;
}



