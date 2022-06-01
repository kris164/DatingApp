import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-resgister',
  templateUrl: './resgister.component.html',
  styleUrls: ['./resgister.component.css']
})
export class ResgisterComponent implements OnInit {
 
  @Output() cancelRegister = new EventEmitter();
  model:any={};


  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
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
