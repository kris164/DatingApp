import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http'
import { FormsModule} from '@angular/forms'
 
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home/home.component';

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ResgisterComponent } from './resgister/resgister.component';
import { ZleceniaComponent } from './zlecenia/zlecenia.component';
import { RouterModule, Routes } from '@angular/router';
 
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { ToastrModule } from 'ngx-toastr';
import { AuthGuard } from './_guards/auth.guard'; 
import { DropDownListModule } from '@syncfusion/ej2-angular-dropdowns';
import { SharedModule } from './_modules/shared.module';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component'; 
import { RegisterComponent } from './register/register.component'; 
import {CUSTOM_ELEMENTS_SCHEMA} from '@angular/core';
import { GridAllModule, GridModule } from '@syncfusion/ej2-angular-grids';
const routes: Routes = [
  //{ path: 'second-component', component: ResgisterComponent },
  { path: '', component: HomeComponent },
  { path: 'orders', component: ZleceniaComponent, canActivate:[AuthGuard] },
  {
    path:'',
    runGuardsAndResolvers:'always',
    canActivate:[AuthGuard],
    children:[
    // { path: 'second-component', component: ResgisterComponent },
    // { path: '', component: RegisterComponent },
      
    ]
  } ,
  {path: 'errors', component: TestErrorsComponent},
  {path: 'not-found', component: NotFoundComponent},
  {path: 'server-error', component: ServerErrorComponent},
  { path: '**', component: AppComponent, pathMatch:'full' },
];

@NgModule({
  declarations: [
 
    AppComponent,
    NavComponent,
    HomeComponent,
    ResgisterComponent, 
    TestErrorsComponent,
    NotFoundComponent,
    ServerErrorComponent, RegisterComponent
  ],
  imports: [
    BrowserModule,   DropDownListModule, 
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule, 
    SharedModule,
     RouterModule.forRoot(routes), GridModule
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi :true
  }],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule { }
platformBrowserDynamic().bootstrapModule(AppModule);