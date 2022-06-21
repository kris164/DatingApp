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
import { GridModule } from '@syncfusion/ej2-angular-grids';
import { DropDownListModule } from '@syncfusion/ej2-angular-dropdowns';
import { SharedModule } from './_modules/shared.module';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
 
 
const routes: Routes = [
  { path: 'orders', component: ZleceniaComponent, canActivate:[AuthGuard] },
  {
    path:'',
    runGuardsAndResolvers:'always',
    canActivate:[AuthGuard],
    children:[
      { path: 'second-component', component: ResgisterComponent },
      
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
    ZleceniaComponent,
    TestErrorsComponent,
    NotFoundComponent,
    ServerErrorComponent
  ],
  imports: [
    BrowserModule,   DropDownListModule,
    GridModule ,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule, 
    SharedModule,
     RouterModule.forRoot(routes),

  ],
  providers: [{
    provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi :true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
platformBrowserDynamic().bootstrapModule(AppModule);