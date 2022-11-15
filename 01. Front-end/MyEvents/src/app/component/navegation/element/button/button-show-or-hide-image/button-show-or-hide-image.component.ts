import { Component, OnInit } from '@angular/core';
import { EventTable } from 'src/app/common/class-support/event-table/event-table';
import { EventsTableComponent } from 'src/app/component/application/events/events-table/events-table.component';

@Component({
  selector: 'app-button-show-or-hide-image',
  templateUrl: './button-show-or-hide-image.component.html',
  styleUrls: ['./button-show-or-hide-image.component.css']
})
export class ButtonShowOrHideComponent implements OnInit {

  constructor(private _eventsTableComponent: EventsTableComponent) { 
    this.eventTable = new EventTable();
  }

  public eventTable: EventTable;

  public mustShow: boolean = true;

  public showOrHide(){
    this._eventsTableComponent.showImages = !this._eventsTableComponent.showImages;
    this.mustShow = !this.mustShow;
  }

  ngOnInit() {
  }

}
