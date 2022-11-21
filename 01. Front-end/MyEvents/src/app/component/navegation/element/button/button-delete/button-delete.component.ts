import { EAlert } from './../../../../../common/enum/message/alert/alert-enums';
import { EActions } from './../../../../../common/enum/message/actions/actions-enums';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { EButton } from 'src/app/common/enum/button/button';
import { EYesOrNo } from 'src/app/common/enum/yes-or-no/yes-or-no';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-button-delete',
  templateUrl: './button-delete.component.html',
  styleUrls: ['./button-delete.component.css']
})
export class ButtonDeleteComponent implements OnInit {

  constructor(private modalService: BsModalService,
              private toastr: ToastrService) { 
  }

  public deleteButton: string = EButton.Delete;
  public deleteThisRecord: string = EAlert.DeleteThisRecord;
  public recordDeleted: string = EActions.RecordDeleted;
  public actionCanceled: string = EActions.ActionCanceled;
  public infoDeletedEvent: string = EActions.InfoDeletedEvent;
  public infoCanceledEvent: string = EActions.InfoCanceledEvent;
  public yes: string = EYesOrNo.Yes;
  public no: string = EYesOrNo.No;
  
  ngOnInit() {
  }

  modalRef?: BsModalRef;
  
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }
 
  confirm(): void {
    this.modalRef?.hide();
    this.toastr.success(this.infoDeletedEvent, this.recordDeleted);
  }
 
  decline(): void {
    this.modalRef?.hide();
    this.toastr.info(this.infoCanceledEvent,  this.actionCanceled);
  }

}
