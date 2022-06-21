import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of, ReplaySubject } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { Order } from '../_models/order';
import { User } from '../_models/user';
import { SearchResults } from '../_models/SearchResults';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl= 'https://localhost:5002/api/';
  private currentUserSource = new ReplaySubject<User>(1);
  private currentorders = new ReplaySubject<Order>();
  currentUserSource$ = this.currentUserSource.asObservable();
  currentorders$ = this.currentorders.asObservable();
  totalAngularPackages: any;

  constructor(private http: HttpClient) { 
   }

   orders(){ 
   
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
register(model:any){
  return this.http.post(this.baseUrl + 'account/register', model).pipe(
  map((user: User )=> {
    { 
      localStorage.setItem('user', JSON.stringify(user))
      this.currentUserSource.next(user);
    }
    return user;
  })

  )
  
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
