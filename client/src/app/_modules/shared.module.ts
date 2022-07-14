import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ToastrModule } from 'ngx-toastr';
import { MaskedTextBoxModule, NumericTextBox, NumericTextBoxModule, TextBoxModule } from '@syncfusion/ej2-angular-inputs'; 
import { DialogModule } from '@syncfusion/ej2-angular-popups'; 
import { CarouselModule,  ToolbarComponent  } from '@syncfusion/ej2-angular-navigations';   
import { GridAllModule,  GridModule} from '@syncfusion/ej2-angular-grids';
import {MatButtonModule} from '@angular/material/button';
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BsDropdownModule.forRoot()  ,
    ToastrModule.forRoot({
     positionClass :'toast-bottom-right'
   }),
   MaskedTextBoxModule, NumericTextBoxModule, DialogModule, CarouselModule  ,GridModule 
  ],
  exports:[ 
    BsDropdownModule,
    ToastrModule, MaskedTextBoxModule, NumericTextBoxModule, TextBoxModule, DialogModule, CarouselModule ,GridModule , ]
  })
export class SharedModule { }
