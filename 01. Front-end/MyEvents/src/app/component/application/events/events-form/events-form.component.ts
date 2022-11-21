import { EFields } from './../../../../common/enum/field/field-enums';
import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { EButton } from 'src/app/common/enum/button/button';
import { EventService } from 'src/app/service/event.service';
import { EventsTableComponent } from '../events-table/events-table.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-events-form',
  templateUrl: './events-form.component.html',
  styleUrls: ['./events-form.component.css']
})
export class EventsFormComponent implements OnInit {

  constructor (public eventService: EventService, 
               public toastr: ToastrService, 
               public spinner: NgxSpinnerService, 
               public router: Router) {
    this.eventsTableComponent = new EventsTableComponent(eventService, toastr, spinner, router);
  }

  public eventsTableComponent: EventsTableComponent;

  public events: Event[] = [];

  public searchButton: string = EButton.Search;
  public newButton: string = EButton.New;
  public filterFields: string = EFields.Filter

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

  filterEvents(filterFor: string){
    filterFor = filterFor.toLocaleUpperCase();
    return this.events.filter((event: any) => event.theme.toLocaleUpperCase().indexOf(filterFor) !== -1)
  }

  routerDetail(): void{
    this.router.navigate(['/events/detail']);
  }

  ngOnInit() {
  }

}
