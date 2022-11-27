import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from '@app/service/events/event.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { EMessage } from 'src/app/common/enum/message/message/message-enums';
import { Event } from '../../../../common/model/event';
import { eventTableFieldsFields } from '../../application-fields/event-fields/event-table/event-table-fields';
import { ApplicationEventsTitleComponent } from '../events-title/events-title.component';

@Component({
  selector: 'app-events-table',
  templateUrl: './events-table.component.html',
  styleUrls: ['./events-table.component.css']
})
export class EventsTableComponent implements OnInit {

  // propriedade da entidade
  public events: Event[] = [];

  // propriedades dos enumedores
  public noDataFound: string = EMessage.NoDataFound;
  public errorLoadingData: string = EMessage.ErrorLoadingData;

  // assets de imagem
  public sourceImages: string = '/assets/image/';
  public showImages: boolean = true;

  // classe de apoio
  public eventTableFields: eventTableFieldsFields;
  public applicationEventsTitleComponent: ApplicationEventsTitleComponent;

  constructor (public eventService: EventService, private toastr: ToastrService, private spinner: NgxSpinnerService, public router: Router) { 
    this.eventTableFields = new eventTableFieldsFields();
    this.applicationEventsTitleComponent = new ApplicationEventsTitleComponent(router);
  }

  ngOnInit (): void {
    this.get();
    this.spinner.show();
  }

  get (): void {
    this.eventService.getAllEvents().subscribe({
        next: (response: Event[]) => {
          this.events = response;
        },
        error: () => {
          this.spinner.hide();
          this.toastr.error(this.errorLoadingData)
        },
        complete: () => {
          this.spinner.hide()
        }
     });
   }

  eventDetail(id: number){
    this.router.navigate([`events/detail/${id}`]);
  }
}