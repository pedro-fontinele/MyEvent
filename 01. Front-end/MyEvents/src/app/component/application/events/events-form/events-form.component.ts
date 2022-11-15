import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { EButton } from 'src/app/common/enum/button/button';
import { EventService } from 'src/app/service/event.service';
import { EventsTableComponent } from '../events-table/events-table.component';

@Component({
  selector: 'app-events-form',
  templateUrl: './events-form.component.html',
  styleUrls: ['./events-form.component.css']
})
export class EventsFormComponent implements OnInit {

  public eventsTableComponent: EventsTableComponent;

  constructor (public eventService: EventService, private toastr: ToastrService, private spinner: NgxSpinnerService) {
    this.eventsTableComponent = new EventsTableComponent(eventService, toastr, spinner);
  }

  public events: Event[] = [];

  public searchButton: string = EButton.Search;

  // campo de pesquisa event
  private _filterList: string = '';
  public filteredEvents: any = [];

  public get filterList (){
    return this._filterList;
  }

  public set filterList (value: string){
    this._filterList = value;
    this.filteredEvents = this._filterList ? this.filterEvents(this._filterList) : this.eventsTableComponent.get();
  }

  public filterEvents(filterFor: string){
    filterFor = filterFor.toLocaleUpperCase();
    return this.events.filter((event: any) => event.theme.toLocaleUpperCase().indexOf(filterFor) !== -1)
  }

  ngOnInit() {
  }

}
