import { Component, OnInit } from '@angular/core';
import { SelectionSettingsModel } from '@syncfusion/ej2-angular-dropdowns';
import {  GridComponent,   FilterService, FilterSettingsModel, PageSettingsModel, ToolbarService, ToolbarItems, EditService, EditSettingsModel, RowDataBoundEventArgs } from '@syncfusion/ej2-angular-grids';
import { ToastrService } from 'ngx-toastr';
import { company } from '../_models/company';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-carriers',
  templateUrl: './carriers.component.html',
  styleUrls: ['./carriers.component.css'],
  providers: [FilterService, EditService, ToolbarService]
})
export class CarriersComponent implements OnInit {
  public data: object[];
  public selectionOptions: SelectionSettingsModel;
public editSettings: EditSettingsModel;
public pageOptions: PageSettingsModel;
public toolbar: ToolbarItems[] | object;
public filterOptions: FilterSettingsModel;
public company: company;

  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  async ngOnInit(): Promise<void> {
    this.company = {
      id:0,
      regon: "",
      nip: "",
      statusNip: "",
      nazwa: "",
      wojewodztwo: "",
      powiat: "",
      gmina: "",
      miejscowosc: "",
      kodPocztowy: "",
      ulica: "",
      nrNieruchomosci: "",
      nrLokalu: "",
      typ: "F",
      silosID: 1,
      dataZakonczeniaDzialalnosci : "2019-01-06T17:16:40",
      miejscowoscPoczty: "",
      errors: [],
      ciagnikSiodlowy:  0,
      ciagnikTrojosiowy:  0,
      ciagnikTypuMega:  0,
      ciagnikTypuMegaReagul:  0,
      jumbo: 0,
      naczepaOplanegkowana:  0,
      megaNaczepaOplanegkowana:  0,
      Password : "",
      UserName: "",
      UsernameDto:  "Dave" ,
      email: "",
      mobile: "", 
      accepted: 0,
      Id_kontrah: 0 ,
    };
    this.data = await  this.accountService.getCompanies();
    this.editSettings = { allowEditing: true, allowAdding: false, allowDeleting: true, mode: 'Dialog' };
    this.toolbar = ['Add', 'Edit', 'Delete', 'Update', 'Cancel', 'Search'];
    this.selectionOptions = {  showCheckbox: true,
      showSelectAll: true};
    this.pageOptions = { pageSize: 5 };
    this.filterOptions = { type: 'CheckBox' };
    for (let i = 0; i < this.data.length; i++) {
      this.data[i]['List'] = i + 1;
    }
  }

  public rowDataBound(args): void {
    args.isSelectable = args.data.List % 5 === 0;
    }

    actionComplete(args) {
      if ((args.requestType === 'beginEdit' || args.requestType === 'add' || args.requestType === 'refresh')) {
          const dialog = args.dialog;
          const nip = 'nip';
          dialog.showCloseIcon = false;
         
          // change the header of the dialog
          dialog.header = args.requestType === 'beginEdit' ? 'Przewoźnik: ' + args.rowData['nip'] : 'Nowy Przewoźnik';
 
        } 

      switch(args.requestType) {
        case 'save':
       this.company.email = args.data?.email; 
       this.company.nazwa = args.data?.nazwa; 
        this.company.mobile = args.data?.mobile; 
        this.company.Id_kontrah = args.data?.Id_kontrah; 
        this.company.accepted = args.data?.accepted; 
        this.company.nip = args.data?.nip; 
        this.company.id = args.data.id; 

          
            this.accountService.update(this.company).subscribe(response => {
              console.log(response); 
              this.toastr.success("Zaktualizowano");
            }, error=>{
              console.log(error);
               this.toastr.error(error.error)
            });
         
        
          break;
        case 'y':
          // code block
          break;
        default:
          // code block
      }

    }

}
