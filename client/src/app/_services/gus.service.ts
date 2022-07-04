import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { company } from '../_models/company';

@Injectable({
    providedIn: 'root'
  })

export class GusService {

    baseUrl= 'https://localhost:5002/api/'; 

constructor(private http: HttpClient) { 
}


async GetCompanyByNip(model:any){
    const data = await this.http.get<company>(this.baseUrl + 'gus/' + model).toPromise();
    //console.log("Data: " + JSON.stringify(data)); 
    return data;
  }



}
