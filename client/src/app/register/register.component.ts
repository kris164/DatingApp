import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { enableProdMode } from '@angular/core';
 

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  title = "Stepper input";
  @Input() initialValue;
  @Input() step: number = 0;
  @Input() min: number = 0;
  @Input() max: number = 0;
  @Input() symbol: string;
  @Input() ariaLabelLess: string;
  @Input() ariaLabelMore: string;
  renderedValue: string;
  value: number = 0;

  @Output() cancelRegister = new EventEmitter();
  model:any={};


  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
    this.value = this.initialValue
    this.renderedValue = this.value.toString() + this.symbol;
  }

  register(){ 
    this.accountService.register(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error=>{
      console.log(error);
    });
  }

  cancel(){
    this.cancelRegister.emit(false);
  }



}
