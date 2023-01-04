import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { EActions } from '@app/common/enum/message/actions/actions-enums';
import { EventService } from '@app/service/events/event.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { EMessage } from 'src/app/common/enum/message/message/message-enums';
import { Event } from '../../../../common/model/event';
import { EventTableFieldsFields } from '../../application-fields/event-fields/event-table/event-table-fields';
import { ApplicationEventsTitleComponent } from '../events-title/events-title.component';

@Component({
  selector: 'app-events-table',
  templateUrl: './events-table.component.html',
  styleUrls: ['./events-table.component.css']
})
export class EventsTableComponent implements OnInit {
  
  public events?: Event[];
  public idEvent!: number;
  public modalRef?: BsModalRef;
  public sourceImages: string = '/assets/image/';
  public showImages: boolean = true;
  public recordDeleted: string = EActions.RecordDeleted;
  public actionCanceled: string = EActions.ActionCanceled;
  public infoDeletedEvent: string = EActions.InfoDeletedEvent;
  public infoCanceledEvent: string = EActions.InfoCanceledEvent;
  public noDataFound: string = EMessage.NoDataFound;
  public errorLoadingData: string = EMessage.ErrorLoadingData;
  public unexpectedErrorOccurred: string = EMessage.UnexpectedErrorOccurred;
  public error: string = EMessage.Error;
  public eventTableFields: EventTableFieldsFields;
  public applicationEventsTitleComponent: ApplicationEventsTitleComponent;

  constructor (public eventService: EventService, public toastr: ToastrService, private spinner: NgxSpinnerService, public router: Router, private modalService: BsModalService) {
    this.eventTableFields = new EventTableFieldsFields();
    this.applicationEventsTitleComponent = new ApplicationEventsTitleComponent(router);
  }

  public ngOnInit(): void {
    this.getEvents();
    this.spinner.show();
  }

  public getEvents(): void {
    this.eventService.getAllEvents().subscribe({
        next: (response: Event[]) => {
          this.events = response;
        },
        error: () => {
          this.spinner.hide();
          this.toastr.error(this.errorLoadingData, this.noDataFound)
        },
        complete: () => {
          this.spinner.hide()
        }
     });
   }

  public editEvents(id: number): void{
    this.router.navigate([`events/detail/${id}`]);
  }
  
  public deleteEvent(id: number): void{
    this.idEvent = id;
  }

  public openModalDelete(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }
 
  public confirmDelete(): void {
    this.modalRef?.hide();
    this.spinner.show();
    this.eventService.deleteEventById(this.idEvent).subscribe({
        next: () => {},
        error: (error: any) => {
            console.log(error);
            this.spinner.hide();
            this.toastr.error(this.unexpectedErrorOccurred, this.error);
          },
        complete: () => {
            this.spinner.hide();
            this.toastr.success(this.infoDeletedEvent, this.recordDeleted);
            this.getEvents();
          }
     });
  }
 
  public declineDelete(): void {
    this.modalRef?.hide();
    this.toastr.info(this.infoCanceledEvent,  this.actionCanceled);
  }
}