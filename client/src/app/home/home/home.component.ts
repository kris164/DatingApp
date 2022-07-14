import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit { 
  registerMode = false; 
  constructor(private router: Router ) { }

  ngOnInit(): void {
   
  }

registerToogle(){
this.registerMode = !this.registerMode; 
this.router.navigate(['/second-component']);
}

 

cancelRegisterMode(event: boolean){
  this.registerMode = event;
}



}


