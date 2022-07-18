import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of, ReplaySubject } from 'rxjs';
import { catchError, map , filter, switchMap, retry, subscribeOn} from 'rxjs/operators';
import { Order } from '../_models/order';
import { User } from '../_models/user';
import { SearchResults } from '../_models/SearchResults'; 
import { company } from '../_models/company';

 @Injectable({
  providedIn: 'root'
})
export class AccountService {
   //return this.http.get<Order[]>(this.baseUrl + 'orders');
 



   existsinmaszon(model: company) {
    return this.http.post(this.baseUrl + 'account/existsinmaszon', model).pipe(
      map((user: company )=> {
        { 
          localStorage.setItem('user', JSON.stringify(user))
          this.currentComapnySource.next(user);
        }
        return user;
      })
    
      )
   }

  baseUrl= 'https://localhost:5002/api/';
  private currentUserSource = new ReplaySubject<User>(1);
  private currentComapnySource = new ReplaySubject<company>(1);
  private currentorders = new ReplaySubject<Order>();
  currentUserSource$ = this.currentUserSource.asObservable();
  currentComapnySource$ = this.currentComapnySource.asObservable();
  currentorders$ = this.currentorders.asObservable();
  totalAngularPackages: any;
    localVar:any;
    countries:Order[] = []
    companies:company[] = []
  constructor(private http: HttpClient) { 
   }

   getOrders2(){ 
    return this.http.get(this.baseUrl + 'orders').pipe( 
      map((response:Order[]) => {
        const user = response;
        if (user)
        { 
          return user
          localStorage.setItem('user', JSON.stringify(user))
           
        }
      })
      );
   }



   async getCompanies(){
    const data = await this.http.get<company[]>(this.baseUrl + 'users').toPromise();
    //console.log("Data: " + JSON.stringify(data)); 
    return data;
  }

    async fetchData2(){
    const data = await this.http.get<Order[]>(this.baseUrl + 'orders').toPromise();
    //console.log("Data: " + JSON.stringify(data)); 
    return data;
  }

   fetchData() {

    const promise = this.http.get<Order[]>(this.baseUrl + 'orders').toPromise();

      console.log(promise);  
    promise.then((data)=>{
      console.log("Promise resolved with: " + JSON.stringify(data));
      return JSON.stringify(data);
    }).catch((error)=>{
      console.log("Promise rejected with " + JSON.stringify(error));
    });
  }

   getOrders() {

     
    //return this.http.get<Order[]>(this.baseUrl + 'orders');

      this.http.get<Order[]>(this.baseUrl + 'orders').subscribe(posts => 
        {
          posts.forEach( post => { 
            console.log('bbbbb' + post.idZlecenia + ' NrZlecenia:' + post.nrZlecenia);
            this.countries.push(post);
            this.countries.push(post);
          
          }) ;

          
          return this.countries;
       });
 
}

   orders(){ 
   

    var rty= this.http.get('https://api.npms.io/v2/search?q=scope:angular').pipe(map(response => JSON.stringify(response)))
    .subscribe(result => {
      this.localVar = JSON.parse(result).data;
     // console.log(this.employeeList);
    },(error)=>{
      console.log(error);
    })

  const ccc=   this.http.get<SearchResults>('https://api.npms.io/v2/search?q=scope:angular').subscribe(data => {
      this.totalAngularPackages = data.total;
      
  });
      return  this.http.get<SearchResults>('https://api.npms.io/v2/search?q=scope:angular').subscribe(data => {
        this.totalAngularPackages = data.total;

    }) 
 }

 private handleError<T>(operation = 'operation', result?: T) {
  return (error: any): Observable<T> => {

    // TODO: send the error to remote logging infrastructure
    console.error(error); // log to console instead

    // TODO: better job of transforming error for user consumption
    console.log(`${operation} failed: ${error.message}`);

    // Let the app keep running by returning an empty result.
    return of(result as T);
  };
}

getHeroes(): Observable<Order[]> {
  return this.http.get<Order[]>(this.baseUrl + 'orders')
    .pipe(
     
      catchError(this.handleError<Order[]>('getHeroes', []))
    );
}

   login(model:any){ 
    return this.http.post(this.baseUrl + 'account/login', model).pipe( 
      map((response:User) => {
        const user = response;
        if (user)
        { 
          localStorage.setItem('user', JSON.stringify(user))
          this.currentUserSource.next(user);
        }
      })
      );
   }
register(model:company){
  return this.http.post(this.baseUrl + 'account/register', model).pipe(
  map((user: company )=> {
    { 
      localStorage.setItem('user', JSON.stringify(user))
      this.currentComapnySource.next(user);
    }
    return user;
  })

  ) 
}

update(model:company){
  return this.http.post(this.baseUrl + 'account/updateuser', model).pipe( )  
}
 

   setCurrentUser(user: User ){
    this.currentUserSource.next(user);
   }

   logout()
   {
    localStorage.removeItem('user') 
    this.currentUserSource.next(null);
   }
 
   
}
 