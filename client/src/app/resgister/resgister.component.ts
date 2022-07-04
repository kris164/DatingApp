import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { company } from '../_models/company';
import { AccountService } from '../_services/account.service';
import { GusService } from '../_services/gus.service';  
import { DialogComponent } from '@syncfusion/ej2-angular-popups';
import { isNullOrUndefined, EmitType } from '@syncfusion/ej2-base';

@Component({
  selector: 'app-resgister',
  templateUrl: './resgister.component.html',
  styleUrls: ['./resgister.component.css']
})


export class ResgisterComponent implements OnInit {
 
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
  constructor(private accountService: AccountService, private toastr: ToastrService, private gusService: GusService) { }

  ngOnInit(): void {
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
    };
  }

  async getCompanyByNip()
  {
    this.isShown = true;
    this.isShownDanezGus=false;
     this.company = await this.gusService.GetCompanyByNip(this.company.nip);
    
  }

  register3(){}

  register(){ 
    this.accountService.register(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error=>{
      console.log(error);
      this.toastr.error(error.error)
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
  carouselObj.next();
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

 
