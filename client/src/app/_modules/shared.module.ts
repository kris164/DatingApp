import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ToastrModule } from 'ngx-toastr';
import { MaskedTextBoxModule, NumericTextBox, NumericTextBoxModule, TextBoxModule } from '@syncfusion/ej2-angular-inputs'; 
import { DialogModule } from '@syncfusion/ej2-angular-popups'; 
import { CarouselModule } from '@syncfusion/ej2-angular-navigations';   
import { GridAllModule,  GridModule} from '@syncfusion/ej2-angular-grids';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BsDropdownModule.forRoot()  ,
    ToastrModule.forRoot({
     positionClass :'toast-bottom-right'
   }),
   MaskedTextBoxModule, NumericTextBoxModule, DialogModule, CarouselModule  
  ],
  exports:[ 
    BsDropdownModule,
    ToastrModule, MaskedTextBoxModule, NumericTextBoxModule, TextBoxModule, DialogModule, CarouselModule   ]
  })
export class SharedModule { }
