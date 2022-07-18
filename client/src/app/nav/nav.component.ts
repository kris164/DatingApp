import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';
import { ToolbarComponent, MenuAnimationSettingsModel } from '@syncfusion/ej2-angular-navigations';

@Component({
  
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  public gridData;
  public pagesettings;
  model: any = {}
  loggedIn: boolean;

  constructor(public accountService: AccountService, private router: Router, private toastr:ToastrService) {
    this.gridData = (window as any).gridData;
    this.pagesettings = { pageCount: 3, pageSize: 7 };
   }

  ngOnInit(): void {

  }


  login() {
    this.accountService.login(this.model).subscribe(response => {
    this.router.navigateByUrl('/orders');
      console.log(response);
      this.loggedIn = true;
    }, error => {
       
    });
  }


  mojaflota()
  {

  }

  mojetransporty()
  {

  }


  private animationSettings: MenuAnimationSettingsModel = { effect: 'None' };

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
    this.loggedIn = false;
  }

  register() {
    //this.accountService.logout();
    this.router.navigateByUrl('/second-component');
    this.loggedIn = false;
  }

  isTournamentRoute() {
    return  this.router.url.includes("/second-component");
}
}
