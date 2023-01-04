import { EAlert } from './../../../../../common/enum/message/alert/alert-enums';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { EButton } from 'src/app/common/enum/button/button';
import { EYesOrNo } from 'src/app/common/enum/yes-or-no/yes-or-no';
import { EventsTableComponent } from '@app/component/application/events/events-table/events-table.component';

@Component({
  selector: 'app-button-delete',
  templateUrl: './button-delete.component.html',
  styleUrls: ['./button-delete.component.css']
})
export class ButtonDeleteComponent implements OnInit {

  constructor(public eventsTableComponent: EventsTableComponent) {
  }

  public deleteButton: string = EButton.Delete;
  public deleteThisRecord: string = EAlert.DeleteThisRecord;
  public yes: string = EYesOrNo.Yes;
  public no: string = EYesOrNo.No;
  public idEvent!: number;
  
  ngOnInit() {}

  modalRef?: BsModalRef;
  
  openModal(template: TemplateRef<any>) {
    this.eventsTableComponent.openModalDelete(template);
  }
 
  confirm(): void {
    this.eventsTableComponent.confirmDelete();
  }
 
  decline(): void {
    this.eventsTableComponent.declineDelete();
  }

}
