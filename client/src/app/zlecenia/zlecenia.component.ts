import { Component, OnInit, ViewChild, enableProdMode } from '@angular/core';
import { BrowserModule, DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { DropDownListComponent } from '@syncfusion/ej2-angular-dropdowns';
import { DropDownListModule } from '@syncfusion/ej2-angular-dropdowns';
import { FilterService, GridModule , FilterSettingsModel, GridComponent,GroupService,IFilter,PageService,PageSettingsModel,SortService,VirtualScrollService  } from '@syncfusion/ej2-angular-grids';
import { ToastrService } from 'ngx-toastr';
 
import { AccountService } from '../_services/account.service';
import { getData } from './data';
 

if (!/localhost/.test(document.location.host)) {
  enableProdMode();
}

@Component({
  selector: 'app-zlecenia',
  templateUrl: './zlecenia.component.html',
  styleUrls: ['./zlecenia.component.css'],
  
  preserveWhitespaces: true,
  providers: [FilterService,VirtualScrollService,PageService,
    SortService,
    FilterService,
    GroupService],
    
})
export class ZleceniaComponent implements OnInit {   
    public customAttributes: Object;
    public filterOption: FilterSettingsModel = { type: 'Excel' };
    public pageSettings: PageSettingsModel;
  public dReady: boolean = false;
  public dtTime: boolean = false;
  public isDataBound: boolean = false;
  public isDataChanged: boolean = true;
  public intervalFun: any;
  public clrIntervalFun: any;
  public clrIntervalFun1: any;
  public clrIntervalFun2: any;    
  public dropSlectedIndex: number = null;
  public stTime: any;
  public data: Object;
  public dataq: any;
  public filter: Object;
  public filterSettings: Object;
  public selectionSettings: Object;  
  public height: string = '240px';
  @ViewChild('sample') 
  public listObj: DropDownListComponent;
  @ViewChild('overviewgrid')
  public gridInstance : GridComponent ;  
  public ddlData: Object[] = [
      { text: '1,000 Rows and 11 Columns', value: '1000' },
      { text: '10,000 Rows and 11 Columns', value: '10000' },
      { text: '1,00,000 Rows and 11 Columns', value: '100000' }      
  ]; 
  public fields: Object = { text: 'text', value: 'value' };
  public item: number[] = [1, 2, 3, 4, 5];  
  constructor(private accountService: AccountService, private toastr: ToastrService) { }
  public async ngOnInit(): Promise<void> {
    this.pageSettings = { pageSize: 15 };
    console.log(getData());
    console.log(await this.accountService.fetchData2());
      this.data = await  this.accountService.fetchData2();
      //this.data =  this.accountService.getOrders();
      this.filterSettings = { type: "Menu" };      
      this.filter = { type: "CheckBox" };    
     this.stTime = performance.now();
      this.selectionSettings = {persistSelection: true, type: "Multiple", checkboxOnly: true };
      this.customAttributes = {class: 'customcss'};
  }
  
  ngAfterViewInit(args: any): void {
      this.gridInstance.on('data-ready', function () {
          this.dReady = true;
      });
      document.getElementById('overviewgrid').addEventListener('DOMSubtreeModified', () => {  
          if (this.stTime && this.isDataChanged) {
              let msgEle = document.getElementById('msg');
              let val: any = (performance.now() - this.stTime).toFixed(0);
              this.stTime = null;                
              this.dtTime = false;
              this.isDataChanged = false;
              msgEle.innerHTML = 'Load Time: ' + "<b>" + val + "</b>" + '<b>ms</b>';
              msgEle.classList.remove('e-hide')
         }
          })
  }
  valueChange(args:any): void {
  this.listObj.hidePopup();	
      this.gridInstance.showSpinner();
      this.dropSlectedIndex = null;
       let index: number = this.listObj.value as number;         
       clearTimeout(this.clrIntervalFun2);
       this.clrIntervalFun2 = setTimeout(() => {
           this.isDataChanged = true;
           this.stTime = null;
           let contentElement: Element = this.gridInstance.contentModule.getPanel().firstChild as Element;
           contentElement.scrollLeft = 0;
           contentElement.scrollTop = 0;
           this.gridInstance.pageSettings.currentPage = 1;
           this.stTime = performance.now();
           this.gridInstance.dataSource =  this.data;
           this.gridInstance.hideSpinner();     
       }, 100);
  }
  onDataBound(args:any):void {
      clearTimeout(this.clrIntervalFun);
      clearInterval(this.intervalFun);
      this.dtTime = true;
  }

}